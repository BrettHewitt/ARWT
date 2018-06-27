﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARWT.ModelInterface.Analysis;

namespace ARWT.Model.Analysis
{
    internal class Frequency : ModelObjectBase, IFrequency
    {
        private double[] _Signal;
        public double[] Signal
        {
            get
            {
                return _Signal;
            }
            set
            {
                if (Equals(_Signal, value))
                {
                    return;
                }

                _Signal = value;

                MarkAsDirty();
            }
        }


        private double _FrameRate;
        public double FrameRate
        {
            get
            {
                return _FrameRate;
            }
            set
            {
                if (Equals(_FrameRate, value))
                {
                    return;
                }

                _FrameRate = value;

                MarkAsDirty();
            }
        }
        
        private bool _UseDft;
        public bool UseDft
        {
            get
            {
                return _UseDft;
            }
            set
            {
                if (Equals(_UseDft, value))
                {
                    return;
                }

                _UseDft = value;

                MarkAsDirty();
            }
        }

        public double GetFrequency(out double[] zeroed)
        {
            if (UseDft)
            {
                double bestFrequency;
                var result = BrettFFT.BrettDFT(Signal, out zeroed, out bestFrequency, FrameRate, 1, 50, 0.1);

                return bestFrequency;
            }
            zeroed = null;
            return CalculateFrequency(Signal, FrameRate, 1);
        }

        public double CalculateFrequency(double[] signal, double frameRate, double frameInterval)
        {
            //Smooth signal using box-car filter
            double[] smoothedSignal = BoxCarFilter(signal);
            
            //Find peaks from smoothed signal
            int[] peaks = FindPeaks(smoothedSignal);

            if (peaks.Length < 2)
            {
                return 0;
            }

            //Find peaks from original signal
            int[] rawPeaks = new int[peaks.Length];

            for (int i = 0; i < peaks.Length; i++)
            {
                rawPeaks[i] = FindClosestPeak(peaks[i], signal);
            }

            //Calculate average frames between peaks
            int peakCounter = 0;
            double cumulativePeak = 0;

            for (int i = 1; i < rawPeaks.Length; i++)
            {
                cumulativePeak += rawPeaks[i] - rawPeaks[i - 1];
                peakCounter++;
            }

            double averageFramesBetweenPeak = cumulativePeak / peakCounter;

            return (frameRate / frameInterval) / averageFramesBetweenPeak;
        }

        private int[] FindPeaks(double[] smoothedSignal, int range = 2)
        {
            List<int> peaks = new List<int>();

            for (int i = range; i < smoothedSignal.Length - range; i++)
            {
                double currentValue = smoothedSignal[i];

                bool isPeak = true;

                for (int j = -range; j <= range; j++)
                {
                    if (j == 0)
                    {
                        continue;
                    }

                    double testValue = smoothedSignal[i - j];

                    if (testValue > currentValue)
                    {
                        isPeak = false;
                        break;
                    }
                }

                if (isPeak)
                {
                    peaks.Add(i);
                }
            }

            return peaks.ToArray();
        }

        private double[] BoxCarFilter(double[] signal)
        {
            double[] filter = new double[] { 0.2, 0.2, 0.2, 0.2, 0.2 };
            double[] result = new double[signal.Length];
            double[] borderedSignal = new double[signal.Length + 4];

            for (int i = -2; i < signal.Length + 2; i++)
            {
                if (i < 0)
                {
                    borderedSignal[i + 2] = signal[0];
                }
                else if (i >= signal.Length)
                {
                    borderedSignal[i + 2] = signal.Last();
                }
                else
                {
                    borderedSignal[i + 2] = signal[i];
                }
            }

            for (int i = 2; i < borderedSignal.Length - 2; i++)
            {
                //Start at 2, finish at length - 2
                result[i - 2] = (borderedSignal[i - 2] * filter[0]) + (borderedSignal[i - 1] * filter[1]) + (borderedSignal[i] * filter[2]) + (borderedSignal[i + 1] * filter[3]) + (borderedSignal[i + 2] * filter[4]);
            }

            return result;
        }

        private int FindClosestPeak(int index, double[] signal)
        {
            double currentValue = signal[index];

            //Go left or right?
            double leftValue;
            double rightValue;

            if (index - 1 < 0)
            {
                rightValue = signal[index + 1];

                if (currentValue > rightValue)
                {
                    //This is a peak already
                    return index;
                }
                else
                {
                    //Scan right
                    return ScanRightForPeak(index, signal);
                }
            }
            else if (index + 1 >= signal.Length)
            {
                leftValue = signal[index - 1];

                if (currentValue > leftValue)
                {
                    //This is a peak already
                    return index;
                }
                else
                {
                    //Scan left
                    return ScanLeftForPeak(index, signal);
                }
            }
            else
            {
                leftValue = signal[index - 1];
                rightValue = signal[index + 1];

                if (currentValue < leftValue && currentValue < rightValue)
                {
                    //We're at a valley, look both ways maybe?
                    int leftIndex = ScanLeftForPeak(index, signal);
                    int rightIndex = ScanRightForPeak(index, signal);

                    int leftDelta = Math.Abs(index - leftIndex);
                    int rightDelta = Math.Abs(index - rightIndex);

                    if (leftDelta <= rightDelta)
                    {
                        return leftIndex;
                    }
                    else
                    {
                        return rightIndex;
                    }
                }
                else if (currentValue < leftValue)
                {
                    //Go left
                    return ScanLeftForPeak(index, signal);
                }
                else if (currentValue < rightValue)
                {
                    //Go right
                    return ScanRightForPeak(index, signal);
                }
                else
                {
                    //We're already at a peak
                    return index;
                }
            }

            return 0;
        }

        private int ScanLeftForPeak(int index, double[] signal)
        {
            int testIndex = index;
            double currentValue = signal[testIndex];
            double testValue = signal[testIndex - 1];

            while (currentValue < testValue)
            {
                testIndex--;

                if (testIndex <= 0)
                {
                    return testIndex;
                }

                currentValue = signal[testIndex];
                testValue = signal[testIndex - 1];
            }

            return testIndex;
        }

        private int ScanRightForPeak(int index, double[] signal)
        {
            int testIndex = index;
            double currentValue = signal[testIndex];
            double testValue = signal[testIndex + 1];

            while (currentValue < testValue)
            {
                testIndex++;

                if (testIndex >= signal.Length - 1)
                {
                    return testIndex;
                }

                currentValue = signal[testIndex];
                testValue = signal[testIndex + 1];
            }

            return testIndex;
        }
    }
}
