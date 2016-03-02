namespace HardwareSignalsLibrary.IO.Hardware
{             
    public interface IHardwareSignals
    {
        void Start();
        void Stop();

        float ReadAnalogInput(int index);
        int AnalogInputsCount { get; }
        int[] AnalogInputs { get; }

        bool ReadDigitalInput(int index);
        int DigitalInputsCount { get; }
        bool[] DigitalInputs { get; }

        void WriteAnalogOutput(int index, float value);
        int AnalogOutputsCount { get; }

        void WriteDigitalOutput(int index, bool value);
        int DigitalOutputsCount { get; }

        void WriteDigitalIndicator(int index, byte value);
        int DigitalIndicatorsCount { get; }
    }
}
