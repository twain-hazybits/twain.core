using System;

namespace Hazybits.Twain.Core.Implementation
{
    internal abstract class TwUserInterface<T> : TwainStructure<T>, Interfaces.ITwUserInterface
    {
        public abstract bool ModalUi { get; set; }
        public abstract IntPtr Parent { get; set; }
        public abstract bool ShowUi { get; set; }
    }
}
