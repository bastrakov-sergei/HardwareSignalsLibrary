namespace HardwareSignalsLibrary.IO
{
    public class InputReaderProxy : IInputReader
    {
        private IInputReader baseInputReader = new DefaultInputReader();

        public IInputReader BaseInputReader
        {
            get { return baseInputReader; }
            set { baseInputReader = value ?? new DefaultInputReader(); }
        }

        public float ReadAnalogInput(string key)
        {
            return BaseInputReader.ReadAnalogInput(key);
        }

        public bool ReadDigitalInput(string key)
        {
            return BaseInputReader.ReadDigitalInput(key);
        }
    }
}