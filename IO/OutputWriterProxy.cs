namespace HardwareSignalsLibrary.IO
{
    public class OutputWriterProxy : IOutputWriter
    {
        private IOutputWriter baseOutputWriter = new DefaultOutputWriter();

        public IOutputWriter BaseOutputWriter
        {
            get { return baseOutputWriter; }
            set { baseOutputWriter = value ?? new DefaultOutputWriter(); }
        }

        public void WriteAnalogOuput(string key, float value)
        {
            BaseOutputWriter.WriteAnalogOuput(key, value);
        }

        public void WriteDigitalOuput(string key, bool value)
        {
            BaseOutputWriter.WriteDigitalOuput(key, value);
        }

        public void WriteDigitalIndicator(string key, byte value)
        {
            BaseOutputWriter.WriteDigitalIndicator(key, value);
        }
    }
}