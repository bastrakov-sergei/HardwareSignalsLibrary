namespace HardwareSignalsLibrary.IO
{      
    public interface IInputOutputSystem
    {
        IInputReader In { get; }
        IOutputWriter Out { get; }
    }
}