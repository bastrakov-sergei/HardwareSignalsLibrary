namespace HardwareSignalsLibrary.IO
{
    public interface IInputReader
    {
        T Get<T>(string key);
    }
}