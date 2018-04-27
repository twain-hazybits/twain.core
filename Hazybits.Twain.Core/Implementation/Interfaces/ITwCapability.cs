using System;
namespace Hazybits.Twain.Core.Implementation.Interfaces
{
    public interface ITwCapability : ITwainStructure
    {
        Capability Capability { get; set; }
        ContainerType ContainerType { get; set; }
        IntPtr Container { get; set; }
	}
}
