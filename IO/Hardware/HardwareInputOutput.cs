using System;
using System.Collections.Generic;

namespace HardwareSignalsLibrary.IO.Hardware
{
    public class HardwareInputOutput : IInputReader, IOutputWriter
    {
        private readonly IHardwareSignals hardwareSignals;
        private readonly IDictionary<string, int> analogInputsConfiguration;
        private readonly IDictionary<string, int> digitalInputsConfiguration;
        private readonly IDictionary<string, int> analogOutputsConfiguration;
        private readonly IDictionary<string, int> digitalOutputsConfiguration;
        private readonly IDictionary<string, int> indicatorsConfiguration;

        public HardwareInputOutput(HardwareInputConfiguration configuration)
        {
            hardwareSignals = configuration.Signals;

            analogInputsConfiguration = configuration.AnalogInputsConfiguration;
            digitalInputsConfiguration = configuration.DigitalInputsConfiguration;
            analogOutputsConfiguration = configuration.AnalogOutputsConfiguration;
            digitalOutputsConfiguration = configuration.DigitalOutputsConfiguration;
            indicatorsConfiguration = configuration.IndicatorsConfiguration;
        }

        public float ReadAnalogInput(string key)
        {
            return Read(analogInputsConfiguration, key, hardwareSignals.ReadAnalogInput);
        }

        public bool ReadDigitalInput(string key)
        {
            return Read(digitalInputsConfiguration, key, hardwareSignals.ReadDigitalInput);
        }

        public void WriteAnalogOuput(string key, float value)
        {
            Write(analogOutputsConfiguration, key, value, hardwareSignals.WriteAnalogOuput);
        }

        public void WriteDigitalOuput(string key, bool value)
        {
            Write(digitalOutputsConfiguration, key, value, hardwareSignals.WriteDigitalOuput);
        }

        public void WriteDigitalIndicator(string key, byte value)
        {
            Write(indicatorsConfiguration, key, value, hardwareSignals.WriteDigitalIndicator);
        }

        private static T Read<T>(IDictionary<string, int> conf, string key, Func<int, T> func)
        {
            if (!conf.ContainsKey(key))
            {
                return default(T);
            }
            return func(conf[key]);
        }

        private static void Write<T>(IDictionary<string, int> conf, string key, T value, Action<int, T> func)
        {
            if (conf.ContainsKey(key))
            {
                func(conf[key], value);
            }
        }
    }
}