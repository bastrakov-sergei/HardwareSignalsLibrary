namespace HardwareSignalsLibrary.Interceptor.IO
{
    public interface IOutputInterceptor
    {
        bool WriteDigitalOuputHandle(string key, bool value);
        float WriteAnalogOuputHandle(string key, float value);
        byte WriteDigitalIndicatorHandle(string key, byte value);
    }
}