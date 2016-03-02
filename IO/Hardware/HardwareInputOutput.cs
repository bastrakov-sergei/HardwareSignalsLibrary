using System;
using System.Collections.Generic;

namespace HardwareSignalsLibrary.IO.Hardware
{
    public class HardwareInputOutput : IInputReader, IOutputWriter
    {
        private readonly IHardwareSignals hardwareSignals;
        private HardwareInputOutputConfiguration configuration;

        public HardwareInputOutput(IHardwareSignals hardwareSignals)
        {
            this.hardwareSignals = hardwareSignals;
        }

        public void SetConfiguration(HardwareInputOutputConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void Start()
        {
            hardwareSignals.Start();
        }

        public void Stop()
        {
            hardwareSignals.Stop();
        }

        public float ReadAnalogInput(string key)
        {
            return Read(configuration.AnalogInputsConfiguration, key, hardwareSignals.ReadAnalogInput);
        }

        public bool ReadDigitalInput(string key)
        {
            return Read(configuration.DigitalInputsConfiguration, key, hardwareSignals.ReadDigitalInput);
        }

        public void WriteAnalogOuput(string key, float value)
        {
            Write(configuration.AnalogOutputsConfiguration, key, value, hardwareSignals.WriteAnalogOutput);
        }

        public void WriteDigitalOuput(string key, bool value)
        {
            Write(configuration.DigitalOutputsConfiguration, key, value, hardwareSignals.WriteDigitalOutput);
        }

        public void WriteDigitalIndicator(string key, byte value)
        {
            Write(configuration.IndicatorsConfiguration, key, value, hardwareSignals.WriteDigitalIndicator);
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