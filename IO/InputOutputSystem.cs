namespace HardwareSignalsLibrary.IO
{
    public class InputOutputSystem : IInputOutputSystem
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
    }                
}