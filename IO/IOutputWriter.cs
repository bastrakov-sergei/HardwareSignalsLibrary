namespace HardwareSignalsLibrary.IO
{
    public interface IOutputWriter
    {
        void Set<T>(string key, T value);
    }
}