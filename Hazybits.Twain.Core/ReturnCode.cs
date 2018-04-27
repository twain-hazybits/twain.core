namespace Hazybits.Twain.Core
{
    public enum ReturnCode
    {
        Success = 0,
        Failure = 1,
        CheckStatus = 2,
        Cancel = 3,
        DsEvent = 4,
        NotDsEvent = 5,
        XFerDone = 6,
        EndOfList = 7,
        InfoNotSupported = 8,
        DataNotAvailable = 9,
        CustomBase = 0x8000
    }
}
