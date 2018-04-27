namespace Hazybits.Twain.Core.Implementation.Interfaces
{
    internal interface IFactoryImpl
    {
        IDsmWrapper CreateDsmWrapper();
        ITwainIdentity CreateTwainIdentity();
        ITwVersion CreateTwVersion();
        ITwStatus CreateTwStatus();
        ITwUserInterface CreateTwUserInterface();
        ITwPendingXFers CreateTwPendingXFers();
        ITwEntrypoint CreateTwEntryPoint();
        ITwSetupFileXFer CreateTwSetupFileXFer();
        ITwFix32 CreateTwFix32();
        ITwFrame CreateTwFrame();
        ITwCapability CreateTwCapability();
        ITwEnumeration CreateTwEnumeration();
        ITwOneValue CreateTwOneValue();
    }
}
