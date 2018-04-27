using System;

namespace Hazybits.Twain.Core.Implementation.Interfaces
{
    public interface ITwUserInterface : ITwainStructure
    {
        bool ShowUi { get; set; }
        bool ModalUi { get; set; }
        IntPtr Parent { get; set; }
    }
}
