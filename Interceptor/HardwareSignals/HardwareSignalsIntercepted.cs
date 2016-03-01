using System;
using HardwareSignalsLibrary.IO.Hardware;

namespace HardwareSignalsLibrary.Interceptor.HardwareSignals
{
    internal class HardwareSignalsIntercepted : IHardwareSignals
    {
        private readonly IHardwareSignals baseSignalsWrapper;
        private readonly IHardwareSignalsInterceptor interceptor;

        public HardwareSignalsIntercepted(IHardwareSignals baseSignalsWrapper, IHardwareSignalsInterceptor interceptor)
        {
            if (baseSignalsWrapper == null)
            {
                throw new ArgumentNullException("baseSignalsWrapper");
            }

            if (interceptor == null)
            {
                throw new ArgumentNullException("interceptor");
            }

            this.baseSignalsWrapper = baseSignalsWrapper;
            this.interceptor = interceptor;
        }             

        public void Start()
        {
            interceptor.Start();
            baseSignalsWrapper.Start();
        }

        public void Stop()
        {
            interceptor.Stop();
            baseSignalsWrapper.Stop();
        }

        public float ReadAnalogInput(int index)
        {
            float input = baseSignalsWrapper.ReadAnalogInput(index);
            float handledInput = interceptor.ReadAnalogInputHandle(index, input);
            return handledInput;
        }

        public int AnalogInputsCount
        {
            get { return baseSignalsWrapper.AnalogInputsCount; }
        }

        public int[] AnalogInputs
        {
            get
            {
                int[] analogInputs = baseSignalsWrapper.AnalogInputs;
                int[] handledInputs = interceptor.AnalogInputsHandle(analogInputs);
                return handledInputs;
            }
        }

        public bool ReadDigitalInput(int index)
        {
            bool input = baseSignalsWrapper.ReadDigitalInput(index);
            bool handledInput = interceptor.ReadDigitalInputHandle(index, input);
            return handledInput;
        }

        public int DigitalInputsCount
        {
            get { return baseSignalsWrapper.DigitalInputsCount; }
        }

        public bool[] DigitalInputs
        {
            get
            {
                bool[] analogInputs = baseSignalsWrapper.DigitalInputs;
                bool[] handledInputs = interceptor.DigitalInputsHandle(analogInputs);
                return handledInputs;
            }
        }

        public void WriteDigitalOuput(int index, bool value)
        {
            bool handledOutput = interceptor.WriteDigitalOuputHandle(index, value);
            baseSignalsWrapper.WriteDigitalOuput(index, handledOutput);
        }

        public int DigitalOuputsCount
        {
            get { return baseSignalsWrapper.DigitalOuputsCount; }
        }

        public void WriteAnalogOuput(int index, float value)
        {
            float handledOutput = interceptor.WriteAnalogOuputHandle(index, value);
            baseSignalsWrapper.WriteAnalogOuput(index, handledOutput);
        }

        public int AnalogOuputsCount
        {
            get { return baseSignalsWrapper.AnalogOuputsCount; }
        }

        public void WriteDigitalIndicator(int index, byte value)
        {
            byte handledOutput = interceptor.WriteDigitalIndicatorHandle(index, value);
            baseSignalsWrapper.WriteDigitalIndicator(index, handledOutput);
        }

        public int DigitalIndicatorsCount
        {
            get { return baseSignalsWrapper.DigitalIndicatorsCount; }
        }
    }
}