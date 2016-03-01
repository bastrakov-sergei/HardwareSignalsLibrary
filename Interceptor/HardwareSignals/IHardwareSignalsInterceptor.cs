namespace HardwareSignalsLibrary.Interceptor.HardwareSignals
{
    public interface IHardwareSignalsInterceptor
    {
        void Start();
        void Stop();

        float ReadAnalogInputHandle(int index, float value);
        int[] AnalogInputsHandle(int[] values);

        bool ReadDigitalInputHandle(int index, bool value);
        bool[] DigitalInputsHandle(bool[] values);

        bool WriteDigitalOuputHandle(int index, bool value);
        float WriteAnalogOuputHandle(int index, float value);
        byte WriteDigitalIndicatorHandle(int index, byte value);
    }
}