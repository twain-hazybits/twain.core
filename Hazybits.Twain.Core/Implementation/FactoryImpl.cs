using System;
using Hazybits.Twain.Core.Implementation.Interfaces;

namespace Hazybits.Twain.Core.Implementation
{
    internal sealed class FactoryImpl
    {
        private static TwainSystem _system = TwainSystem.Unknown;
        private static IFactoryImpl _factory;

		private static IFactoryImpl Factory
		{
			get
			{
				if (_factory == null)
				{
					switch (System)
					{
						case TwainSystem.Windows:
							_factory = new Windows.FactoryImpl();
							break;
					}
				}

				return _factory;
			}
		}

		private static TwainSystem System
        {
            get 
            {
                if (_system == TwainSystem.Unknown)
                {
                    if (Environment.OSVersion.ToString().Contains("Microsoft Windows"))
                    {
                        _system = TwainSystem.Windows;
                    }
                }

                if (_system == TwainSystem.Unknown)
                    throw new TwainException("Unsupported system has detected.");

                return _system;
            }
        }

        public static IDsmWrapper CreateDsmWrapper()
        {
            return Factory.CreateDsmWrapper();
        }

        public static ITwainIdentity CreateTwainIdentity()
        {
            return Factory.CreateTwainIdentity();
        }

        public static ITwVersion CreateTwVersion()
        {
            return Factory.CreateTwVersion();
        }

        public static ITwStatus CreateTwStatus()
        {
            return Factory.CreateTwStatus();
        }

        public static ITwUserInterface CreateTwUserInterface()
        {
            return Factory.CreateTwUserInterface();
        }

        public static ITwPendingXFers CreateTwPendingXFers()
        {
            return Factory.CreateTwPendingXFers();
        }

        public static ITwEntrypoint CreateTwEntryPoint()
        {
            return Factory.CreateTwEntryPoint();
        }

        public static ITwSetupFileXFer CreateTwSetupFileXFer()
        {
            return Factory.CreateTwSetupFileXFer();
        }

        public static ITwFix32 CreateTwFix32()
        {
            return Factory.CreateTwFix32();
        }

        public static ITwFrame CreateTwFrame()
        {
            return Factory.CreateTwFrame();
        }

        public static ITwCapability CreateTwCapability()
        {
            return Factory.CreateTwCapability();
        }

        public static ITwEnumeration CreateTwEnumeration()
        {
            return Factory.CreateTwEnumeration();
        }

        public static ITwOneValue CreateTwOneValue()
        {
            return Factory.CreateTwOneValue();
        }
    }
}
