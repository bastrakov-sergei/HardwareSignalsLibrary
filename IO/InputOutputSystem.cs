namespace HardwareSignalsLibrary.IO
{              
    public class InputOutputSystem : IInputOutputSystem
    {
        private readonly InputReaderProxy inputReaderProxy = new InputReaderProxy();
        private readonly OutputWriterProxy outputWriterProxy = new OutputWriterProxy();

        public IInputReader In
        {
            get { return inputReaderProxy; }
            set { inputReaderProxy.BaseInputReader = value; }
        }

        public IOutputWriter Out
        {
            get { return outputWriterProxy; }
            set { outputWriterProxy.BaseOutputWriter = value; }
        }

        public float ReadAnalogInput(string key)
        {
            return ((IInputReader) inputReaderProxy).ReadAnalogInput(key);
        }

        public bool ReadDigitalInput(string key)
        {
            return ((IInputReader) inputReaderProxy).ReadDigitalInput(key);
        }

        public void WriteAnalogOuput(string key, float value)
        {
            ((IOutputWriter) outputWriterProxy).WriteAnalogOuput(key, value);
        }

        public void WriteDigitalOuput(string key, bool value)
        {
            ((IOutputWriter) outputWriterProxy).WriteDigitalOuput(key, value);
        }

        public void WriteDigitalIndicator(string key, byte value)
        {
            ((IOutputWriter) outputWriterProxy).WriteDigitalIndicator(key, value);
        }
    }                
}