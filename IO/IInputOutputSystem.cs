namespace HardwareSignalsLibrary.IO
{
    public interface IInputOutputSystem : IInputReader, IOutputWriter
    {
        IInputReader In { get; }
        IOutputWriter Out { get; }
    }
}