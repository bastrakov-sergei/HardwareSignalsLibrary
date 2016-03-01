namespace HardwareSignalsLibrary.IO
{
    public class DefaultInputReader : IInputReader
    {
        public float ReadAnalogInput(string key)
        {
            return 0.0f;
        }

        public bool ReadDigitalInput(string key)
        {
            return false;
        }
    }
}