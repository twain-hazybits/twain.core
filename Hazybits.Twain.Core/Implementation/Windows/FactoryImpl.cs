using Hazybits.Twain.Core.Implementation.Interfaces;

namespace Hazybits.Twain.Core.Implementation.Windows
{
    internal class FactoryImpl : IFactoryImpl
    {
        public IDsmWrapper CreateDsmWrapper()
        {
            return new DsmWrapper();
        }
        
		public ITwainIdentity CreateTwainIdentity()
		{
			return new TwIdentityImpl();
		}

		public ITwVersion CreateTwVersion()
		{
			return new TwVersionImpl();
		}

		public ITwStatus CreateTwStatus()
		{
			return new TwStatusImpl();
		}

		public ITwUserInterface CreateTwUserInterface()
		{
			return new TwUserInterfaceImpl();
		}

		public ITwPendingXFers CreateTwPendingXFers()
		{
			return new TwPendingXFersImpl();
		}

		public ITwEntrypoint CreateTwEntryPoint()
		{
			return new TwEntrypointImpl();
		}

        public ITwSetupFileXFer CreateTwSetupFileXFer()
        {
            return new TwSetupFileXFerImpl();
        }

        public ITwFix32 CreateTwFix32()
        {
            return new TwFix32Impl();
        }

        public ITwFrame CreateTwFrame()
        {
            return new TwFrameImpl();
        }

        public ITwCapability CreateTwCapability()
        {
            return new TwCapabilityImpl();
        }

        public ITwEnumeration CreateTwEnumeration()
        {
            return new TwEnumerationImpl();
        }

        public ITwOneValue CreateTwOneValue()
        {
            return new TwOneValueImpl();
        }

    }
}
