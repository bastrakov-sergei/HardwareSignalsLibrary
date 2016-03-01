namespace HardwareSignalsLibrary.IO
{
    public interface IInputReader
    {
        float ReadAnalogInput(string key);

        bool ReadDigitalInput(string key);
    }
}