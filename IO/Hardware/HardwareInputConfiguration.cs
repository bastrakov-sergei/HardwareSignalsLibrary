using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace HardwareSignalsLibrary.IO.Hardware
{
    [Serializable]
    public class HardwareInputOutputConfiguration 
    {
        private class HardwareInputOutputConfigurationJsonSection
        {
            public string Name { get; set; }
            public Dictionary<string, int> Config { get; set; }
        }

        public Dictionary<string, int> AnalogInputsConfiguration = new Dictionary<string, int>();
        public Dictionary<string, int> DigitalInputsConfiguration = new Dictionary<string, int>();
        public Dictionary<string, int> AnalogOutputsConfiguration = new Dictionary<string, int>();
        public Dictionary<string, int> DigitalOutputsConfiguration = new Dictionary<string, int>();
        public Dictionary<string, int> IndicatorsConfiguration = new Dictionary<string, int>();


        public string ToJson()
        {
            return JsonConvert.SerializeObject(new[]
            {
                new HardwareInputOutputConfigurationJsonSection
                {
                    Name = "analogInputsConfiguration",
                    Config = AnalogInputsConfiguration
                },
                new HardwareInputOutputConfigurationJsonSection
                {
                    Name = "analogOutputsConfiguration",
                    Config = AnalogOutputsConfiguration
                },
                new HardwareInputOutputConfigurationJsonSection
                {
                    Name = "digitalInputsConfiguration",
                    Config = DigitalInputsConfiguration
                },
                new HardwareInputOutputConfigurationJsonSection
                {
                    Name = "digitalOutputsConfiguration",
                    Config = DigitalOutputsConfiguration
                },
                new HardwareInputOutputConfigurationJsonSection
                {
                    Name = "indicatorsConfiguration",
                    Config = IndicatorsConfiguration
                }
            }, Formatting.Indented);
        }

        public static HardwareInputOutputConfiguration FromJson(string json)
        {
            HardwareInputOutputConfiguration configuration = new HardwareInputOutputConfiguration();
            HardwareInputOutputConfigurationJsonSection[] dictionaries =
                JsonConvert.DeserializeObject<HardwareInputOutputConfigurationJsonSection[]>(json);

            HardwareInputOutputConfigurationJsonSection configurationJsonSection;

            configurationJsonSection = dictionaries.FirstOrDefault(s => s.Name == "analogInputsConfiguration");
            configuration.AnalogInputsConfiguration = configurationJsonSection != null
                ? configurationJsonSection.Config
                : new Dictionary<string, int>();

            configurationJsonSection = dictionaries.FirstOrDefault(s => s.Name == "analogOutputsConfiguration");
            configuration.AnalogOutputsConfiguration = configurationJsonSection != null
                ? configurationJsonSection.Config
                : new Dictionary<string, int>();

            configurationJsonSection = dictionaries.FirstOrDefault(s => s.Name == "digitalInputsConfiguration");
            configuration.DigitalInputsConfiguration = configurationJsonSection != null
                ? configurationJsonSection.Config
                : new Dictionary<string, int>();

            configurationJsonSection = dictionaries.FirstOrDefault(s => s.Name == "digitalOutputsConfiguration");
            configuration.DigitalOutputsConfiguration = configurationJsonSection != null
                ? configurationJsonSection.Config
                : new Dictionary<string, int>();

            configurationJsonSection = dictionaries.FirstOrDefault(s => s.Name == "indicatorsConfiguration");
            configuration.IndicatorsConfiguration = configurationJsonSection != null
                ? configurationJsonSection.Config
                : new Dictionary<string, int>();

            return configuration;
        }
    }
}