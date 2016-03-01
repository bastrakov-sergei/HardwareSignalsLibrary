using HardwareSignalsLibrary.Interceptor.HardwareSignals;
using HardwareSignalsLibrary.IO.Hardware;

namespace HardwareSignalsLibrary
{
    public static class HardwareSignalsFactory
    {              
        public static IHardwareSignals Create(IHardwareSignals baseWrapper, IHardwareSignalsInterceptor interceptor)
        {
            return new HardwareSignalsIntercepted(baseWrapper, interceptor);
        }          
    }
}
