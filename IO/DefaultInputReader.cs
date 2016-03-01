namespace HardwareSignalsLibrary.IO
{
    public class DefaultInputReader : IInputReader
    {
        public T Get<T>(string key)
        {
            return default(T);
        }
    }
}