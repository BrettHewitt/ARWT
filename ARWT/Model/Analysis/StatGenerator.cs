﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARWT.Model.Smoothing;
using ARWT.Model.Whiskers;
using ARWT.ModelInterface.Analysis;
using ARWT.ModelInterface.Results;
using ARWT.ModelInterface.Smoothing;
using ARWT.ModelInterface.Whiskers;

namespace ARWT.Model.Analysis
{
    internal class StatGenerator : ModelObjectBase
    {

        private double[] _LeftSignal;
        public double[] LeftSignal
        {
            get
            {
                return _LeftSignal;
            }
            set
            {
                if (Equals(_LeftSignal, value))
                {
                    return;
                }

                _LeftSignal = value;

                MarkAsDirty();
            }
        }


        private double[] _RightSignal;
        public double[] RightSignal
        {
            get
            {
                return _RightSignal;
            }
            set
            {
                if (Equals(_RightSignal, value))
                {
                    return;
                }

                _RightSignal = value;

                MarkAsDirty();
            }
        }


        private int _StartFrame;
        public int StartFrame
        {
            get
            {
                return _StartFrame;
            }
            set
            {
                if (Equals(_StartFrame, value))
                {
                    return;
                }

                _StartFrame = value;

                MarkAsDirty();
            }
        }


        private int _EndFrame;
        public int EndFrame
        {
            get
            {
                return _EndFrame;
            }
            set
            {
                if (Equals(_EndFrame, value))
                {
                    return;
                }

                _EndFrame = value;

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


        private ISmoothingBase _SmoothingFunction;
        public ISmoothingBase SmoothingFunction
        {
            get
            {
                return _SmoothingFunction;
            }
            set
            {
                if (Equals(_SmoothingFunction, value))
                {
                    return;
                }

                _SmoothingFunction = value;

                MarkAsDirty();
            }
        }


        private double _LeftWhiskerFrequency;
        public double LeftWhiskerFrequency
        {
            get
            {
                return _LeftWhiskerFrequency;
            }
            set
            {
                if (Equals(_LeftWhiskerFrequency, value))
                {
                    return;
                }

                _LeftWhiskerFrequency = value;

                MarkAsDirty();
            }
        }
        
        private double _RightWhiskerFrequnecy;
        public double RightWhiskerFrequnecy
        {
            get
            {
                return _RightWhiskerFrequnecy;
            }
            set
            {
                if (Equals(_RightWhiskerFrequnecy, value))
                {
                    return;
                }

                _RightWhiskerFrequnecy = value;

                MarkAsDirty();
            }
        }


        private double _LeftWhiskerAmplitude;
        public double LeftWhiskerAmplitude
        {
            get
            {
                return _LeftWhiskerAmplitude;
            }
            set
            {
                if (Equals(_LeftWhiskerAmplitude, value))
                {
                    return;
                }

                _LeftWhiskerAmplitude = value;

                MarkAsDirty();
            }
        }


        private double _RightWhiskerAmplitude;
        public double RightWhiskerAmplitude
        {
            get
            {
                return _RightWhiskerAmplitude;
            }
            set
            {
                if (Equals(_RightWhiskerAmplitude, value))
                {
                    return;
                }

                _RightWhiskerAmplitude = value;

                MarkAsDirty();
            }
        }
        
        private double _LeftMeanOffset;
        public double LeftMeanOffset
        {
            get
            {
                return _LeftMeanOffset;
            }
            set
            {
                if (Equals(_LeftMeanOffset, value))
                {
                    return;
                }

                _LeftMeanOffset = value;

                MarkAsDirty();
            }
        }
        
        private double _RightMeanOffset;
        public double RightMeanOffset
        {
            get
            {
                return _RightMeanOffset;
            }
            set
            {
                if (Equals(_RightMeanOffset, value))
                {
                    return;
                }

                _RightMeanOffset = value;

                MarkAsDirty();
            }
        }


        private double _LeftAverageRetractionVelocity;
        public double LeftAverageRetractionVelocity
        {
            get
            {
                return _LeftAverageRetractionVelocity;
            }
            set
            {
                if (Equals(_LeftAverageRetractionVelocity, value))
                {
                    return;
                }

                _LeftAverageRetractionVelocity = value;

                MarkAsDirty();
            }
        }


        private double _LeftAverageProtractionVelocity;
        public double LeftAverageProtractionVelocity
        {
            get
            {
                return _LeftAverageProtractionVelocity;
            }
            set
            {
                if (Equals(_LeftAverageProtractionVelocity, value))
                {
                    return;
                }

                _LeftAverageProtractionVelocity = value;

                MarkAsDirty();
            }
        }


        private double _RightAverageRetractionVelocity;
        public double RightAverageRetractionVelocity
        {
            get
            {
                return _RightAverageRetractionVelocity;
            }
            set
            {
                if (Equals(_RightAverageRetractionVelocity, value))
                {
                    return;
                }

                _RightAverageRetractionVelocity = value;

                MarkAsDirty();
            }
        }


        private double _RightAverageProtractionVelocity;
        public double RightAverageProtractionVelocity
        {
            get
            {
                return _RightAverageProtractionVelocity;
            }
            set
            {
                if (Equals(_RightAverageProtractionVelocity, value))
                {
                    return;
                }

                _RightAverageProtractionVelocity = value;

                MarkAsDirty();
            }
        }


        private double _LeftAverageAngularVelocity;
        public double LeftAverageAngularVelocity
        {
            get
            {
                return _LeftAverageAngularVelocity;
            }
            set
            {
                if (Equals(_LeftAverageAngularVelocity, value))
                {
                    return;
                }

                _LeftAverageAngularVelocity = value;

                MarkAsDirty();
            }
        }

        private double _RightAverageAngularVelocity;
        public double RightAverageAngularVelocity
        {
            get
            {
                return _RightAverageAngularVelocity;
            }
            set
            {
                if (Equals(_RightAverageAngularVelocity, value))
                {
                    return;
                }

                _RightAverageAngularVelocity = value;

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


        private int _SmoothRepeats;
        public int SmoothRepeats
        {
            get
            {
                return _SmoothRepeats;
            }
            set
            {
                if (Equals(_SmoothRepeats, value))
                {
                    return;
                }

                _SmoothRepeats = value;

                MarkAsDirty();
            }
        }


        public double[][] Generate(Dictionary<int, ISingleFrameExtendedResults> results, double frameRate, bool onlyForInteracting = false)
        {
            //Get signal
            IWhiskerAverageAngles angles = new WhiskerAverageAngles();
            angles.StartFrame = StartFrame;
            angles.EndFrame = EndFrame;
            var allAngles = angles.GetWhiskerAngles(results, onlyForInteracting);

            if (allAngles == null || !allAngles.Any() || (allAngles[0].Count == 0 && allAngles[1].Count == 0))
            {
                return null;
            }

            LeftSignal = allAngles[0].Select(x => x.Value).ToArray();
            RightSignal = allAngles[1].Select(x => x.Value).ToArray();

            double[] leftSignal = LeftSignal;
            double[] rightSignal = RightSignal;
            if (SmoothingFunction != null)
            {
                for (int i = 0; i < SmoothRepeats; i++)
                {
                    leftSignal = SmoothingFunction.Smooth(leftSignal);
                    rightSignal = SmoothingFunction.Smooth(rightSignal);
                }
            }

            LeftSignal = leftSignal;
            RightSignal = rightSignal;

            IFrequency frequency = new Frequency();
            frequency.UseDft = false;
            frequency.Signal = LeftSignal;
            frequency.FrameRate = frameRate;
            frequency.UseDft = UseDft;
            double[] leftZeroed, rightZeroed;
            double lefFequency = frequency.GetFrequency(out leftZeroed);
            frequency.Signal = RightSignal;
            double rightFrequency = frequency.GetFrequency(out rightZeroed);
            Console.WriteLine($"Left Freq: {lefFequency}, Right freq: {rightFrequency}");
            LeftWhiskerFrequency = lefFequency;
            RightWhiskerFrequnecy = rightFrequency;

            //Get amplitude
            Amplitude amp = new Amplitude();
            LeftWhiskerAmplitude = amp.GetMaxAmpitude(LeftSignal);
            RightWhiskerAmplitude = amp.GetMaxAmpitude(RightSignal);

            //Get mean offset
            MeanOffset offSet = new MeanOffset();
            LeftMeanOffset = offSet.GetMeanOffset(LeftSignal);
            RightMeanOffset = offSet.GetMeanOffset(RightSignal); 

            SingleWhiskerProtractionRetraction proRetLeft = new SingleWhiskerProtractionRetraction();
            SingleWhiskerProtractionRetraction proRetRight = new SingleWhiskerProtractionRetraction();
            proRetLeft.FrameRate = 500;
            proRetRight.FrameRate = 500;
            proRetLeft.AngleSignal = LeftSignal;
            proRetRight.AngleSignal = RightSignal;

            LeftAverageAngularVelocity = proRetLeft.MeanAngularVelocity;
            LeftAverageProtractionVelocity = proRetLeft.MeanProtractionVelocity;
            LeftAverageRetractionVelocity = proRetLeft.MeanRetractionVelocity;

            RightAverageAngularVelocity = proRetRight.MeanAngularVelocity;
            RightAverageProtractionVelocity = proRetRight.MeanProtractionVelocity;
            RightAverageRetractionVelocity = proRetRight.MeanRetractionVelocity;


            return new double[][] {leftZeroed, rightZeroed};
        }
    }
}
