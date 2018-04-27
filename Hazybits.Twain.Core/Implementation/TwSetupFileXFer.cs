using System;

namespace Hazybits.Twain.Core.Implementation
{
    internal abstract class TwSetupFileXFer<T> : TwainStructure<T>, Interfaces.ITwSetupFileXFer
    {
        public abstract string FileName { get; set; }
		public abstract Int16 Format { get; set; }
		public abstract Int16 VRefNum { get; set; }
	}
}
