namespace HardwareSignalsLibrary.Interceptor.IO
{
    public interface IInputInterceptor
    {
        float ReadAnalogInputHandle(string key, float value);
        bool ReadDigitalInputHandle(string key, bool value);
    }
}