using System;

namespace HardwareSignalsLibrary.IO.Hardware
{             
    public interface IHardwareSignals : IDisposable
    {
        void Start();
        void Stop();

        float ReadAnalogInput(int index);
        int AnalogInputsCount { get; }
        int[] AnalogInputs { get; }

        bool ReadDigitalInput(int index);
        int DigitalInputsCount { get; }
        bool[] DigitalInputs { get; }

        void WriteAnalogOuput(int index, float value);
        int AnalogOuputsCount { get; }

        void WriteDigitalOuput(int index, bool value);
        int DigitalOuputsCount { get; }

        void WriteDigitalIndicator(int index, byte value);
        int DigitalIndicatorsCount { get; }
    }
}
