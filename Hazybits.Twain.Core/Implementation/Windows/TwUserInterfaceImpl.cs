using System;

namespace Hazybits.Twain.Core.Implementation.Windows
{
    internal class TwUserInterfaceImpl : TwUserInterface<Structures.TwUserInterfaceStruct>
    {
        public override bool ShowUi
        {
            get { return Structure.ShowUI == 1; }
            set { Structure.ShowUI = (ushort)(value ? 1 : 0); }
        }

        public override bool ModalUi
        {
            get { return Structure.ModalUI == 1; }
            set { Structure.ModalUI = (ushort) (value ? 1 : 0); }
        }

        public override IntPtr Parent
        {
            get { return Structure.hParent; }
            set { Structure.hParent = value; }
        }
    }
}
