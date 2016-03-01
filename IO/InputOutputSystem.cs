namespace HardwareSignalsLibrary.IO
{
    public class InputOutputSystem : IInputOutputSystem, IInputReader, IOutputWriter
    {
        private IInputReader inDictionary = new DefaultInputReader();
        private IOutputWriter outDictionary = new DefaultOutputWriter();

        public IInputReader In
        {
            get { return inDictionary; }
            set { inDictionary = value; }
        }

        public IOutputWriter Out
        {
            get { return outDictionary; }
            set { outDictionary = value; }
        }

        public T Get<T>(string key)
        {
            return inDictionary.Get<T>(key);
        }

        public void Set<T>(string key, T value)
        {
            outDictionary.Set(key, value);
        }
    }                
}