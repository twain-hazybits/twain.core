using System;
namespace Hazybits.Twain.Core.Implementation.Windows
{
    internal class TwCapabilityImpl : TwCapability<Structures.TwCapabilityStruct>
    {
        public override Capability Capability { get { return Structure.Capability; } set { Structure.Capability = value; } }
        public override ContainerType ContainerType { get { return Structure.ContainerType; } set { Structure.ContainerType = value; } }
        public override IntPtr Container { get { return Structure.Container; } set { Structure.Container = value; } }
	}
}
