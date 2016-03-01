namespace HardwareSignalsLibrary.IO
{
    public interface IOutputWriter
    {
        void WriteAnalogOuput(string key, float value);

        void WriteDigitalOuput(string key, bool value);

        void WriteDigitalIndicator(string key, byte value);
    }
}