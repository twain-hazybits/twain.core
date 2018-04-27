using System;
using Hazybits.Twain.Core.Implementation.Interfaces;

namespace Hazybits.Twain.Core.TwainStructures
{
    public class TwCapability : TwainStructure<ITwCapability>, ITwCapability
     {
        public TwCapability()
        {
            PlatformStructure = Implementation.FactoryImpl.CreateTwCapability();
        }

        public Capability Capability { get { return PlatformStructure.Capability; } set { PlatformStructure.Capability = value; } }
        public ContainerType ContainerType { get { return PlatformStructure.ContainerType; } set { PlatformStructure.ContainerType = value; } }
        public IntPtr Container { get { return PlatformStructure.Container; } set { PlatformStructure.Container = value; } }

        public TwEnumeration GetTwEnumeration()
        {
            var twEnumeration = new TwEnumeration();
            twEnumeration.ReadStructureFromPtr(Container);
            return twEnumeration;
        }

        public TwOneValue GetOneValue()
        {
            var twOneValue = new TwOneValue();
            twOneValue.ReadStructureFromPtr(Container);
            return twOneValue;
        }
    }
}
