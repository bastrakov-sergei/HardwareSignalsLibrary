using System.Collections.Generic;

namespace HardwareSignalsLibrary.IO.Hardware
{
    public sealed class HardwareInputConfiguration
    {
        public IHardwareSignals Signals { get; set; }
        public IDictionary<int, string> AnalogInputsConfiguration { get; set; }
        public IDictionary<int, string> DigitalInputsConfiguration { get; set; }
        public IDictionary<string, int> AnalogOutputsConfiguration { get; set; }
        public IDictionary<string, int> DigitalOutputsConfiguration { get; set; }
        public IDictionary<string, int> IndicatorsConfiguration { get; set; }
    }
}