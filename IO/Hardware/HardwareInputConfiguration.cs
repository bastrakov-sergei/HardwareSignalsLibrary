using System.Collections.Generic;

namespace HardwareSignalsLibrary.IO.Hardware
{
    public sealed class HardwareInputConfiguration
    {
        private IDictionary<string, int> analogInputsConfiguration = new Dictionary<string, int>();
        private IDictionary<string, int> digitalInputsConfiguration = new Dictionary<string, int>();
        private IDictionary<string, int> analogOutputsConfiguration = new Dictionary<string, int>();
        private IDictionary<string, int> digitalOutputsConfiguration = new Dictionary<string, int>();
        private IDictionary<string, int> indicatorsConfiguration = new Dictionary<string, int>();
        public IHardwareSignals Signals { get; set; }

        public IDictionary<string, int> AnalogInputsConfiguration
        {
            get { return analogInputsConfiguration; }
            set { analogInputsConfiguration = value; }
        }

        public IDictionary<string, int> DigitalInputsConfiguration
        {
            get { return digitalInputsConfiguration; }
            set { digitalInputsConfiguration = value; }
        }

        public IDictionary<string, int> AnalogOutputsConfiguration
        {
            get { return analogOutputsConfiguration; }
            set { analogOutputsConfiguration = value; }
        }

        public IDictionary<string, int> DigitalOutputsConfiguration
        {
            get { return digitalOutputsConfiguration; }
            set { digitalOutputsConfiguration = value; }
        }

        public IDictionary<string, int> IndicatorsConfiguration
        {
            get { return indicatorsConfiguration; }
            set { indicatorsConfiguration = value; }
        }
    }
}