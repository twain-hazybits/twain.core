using System;
using Hazybits.Twain.Core.Implementation.Interfaces;

namespace Hazybits.Twain.Core.Implementation
{
    internal abstract class TwCapability<T> : TwainStructure<T>, ITwCapability
    {
		public abstract Capability Capability { get; set; }
		public abstract ContainerType ContainerType { get; set; }
		public abstract IntPtr Container { get; set; }
    }
}
