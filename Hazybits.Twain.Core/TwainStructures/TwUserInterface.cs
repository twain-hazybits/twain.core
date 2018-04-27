using System;
using Hazybits.Twain.Core.Implementation.Interfaces;

namespace Hazybits.Twain.Core.TwainStructures
{
    public class TwUserInterface : TwainStructure<ITwUserInterface>, ITwUserInterface
	{
	    public TwUserInterface()
	    {
		    PlatformStructure = Implementation.FactoryImpl.CreateTwUserInterface();
		}

        public bool ShowUi { get { return PlatformStructure.ShowUi; } set { PlatformStructure.ShowUi = value; } }

        public bool ModalUi { get { return PlatformStructure.ModalUi; } set { PlatformStructure.ModalUi = value; } }

        public IntPtr Parent { get { return PlatformStructure.Parent; } set { PlatformStructure.Parent = value; } }
	}
}
