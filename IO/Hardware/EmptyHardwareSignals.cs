namespace HardwareSignalsLibrary.IO.Hardware
{
    public class HardwareInputOutputSystem
    {
        private IHardwareSignals hardwareSignals;
    }

    public class EmptyHardwareSignals : IHardwareSignals
    {
        private readonly int[] analogInputs;
        private readonly bool[] digitalInputs;
        private readonly bool[] digitalOutputs;
        private readonly float[] analogOutputs;
        private readonly byte[] digitalIndicators;

        public EmptyHardwareSignals(int analogInputsCount, int digitalInputsCount, int digitalOuputsCount, int analogOuputsCount, int digitalIndicatorsCount)
        {
            analogInputs = new int[analogInputsCount];
            digitalInputs = new bool[digitalInputsCount];
            digitalOutputs = new bool[digitalOuputsCount];
            analogOutputs = new float[analogOuputsCount];
            digitalIndicators = new byte[digitalIndicatorsCount];
        }

        public void Start()
        {
        }

        public void Stop()
        {
        }

        public float ReadAnalogInput(int index)
        {
            return analogInputs[index];
        }

        public int AnalogInputsCount
        {
            get { return analogInputs.Length; }
        }

        public int[] AnalogInputs
        {
            get { return analogInputs; }
        }

        public bool ReadDigitalInput(int index)
        {
            return digitalInputs[index];
        }

        public int DigitalInputsCount
        {
            get { return digitalInputs.Length; }
        }

        public bool[] DigitalInputs
        {
            get { return digitalInputs; }
        }

        public void WriteDigitalOuput(int index, bool value)
        {
            digitalOutputs[index] = value;
        }

        public int DigitalOuputsCount
        {
            get { return digitalOutputs.Length; }
        }

        public void WriteAnalogOuput(int index, float value)
        {
            analogOutputs[index] = value;
        }

        public int AnalogOuputsCount
        {
            get { return analogOutputs.Length; }
        }

        public void WriteDigitalIndicator(int index, byte value)
        {
            digitalIndicators[index] = value;
        }

        public int DigitalIndicatorsCount
        {
            get { return digitalIndicators.Length; }
        }
    }
}