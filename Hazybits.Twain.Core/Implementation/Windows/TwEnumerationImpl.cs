using System;
using Hazybits.Twain.Core.Implementation.Interfaces;

namespace Hazybits.Twain.Core.Implementation.Windows
{
    internal class TwEnumerationImpl : TwEnumeration<Structures.TwEnumerationStruct>
    {
        public TwEnumerationImpl() {}

        public TwEnumerationImpl(Structures.TwEnumerationStruct twEnumerationStruct)
        {
            Structure.ItemType = twEnumerationStruct.ItemType;
            Structure.NumItems = twEnumerationStruct.NumItems;
            Structure.CurrentIndex = twEnumerationStruct.CurrentIndex;
            Structure.DefaultIndex = twEnumerationStruct.DefaultIndex;
        }

        public TwEnumerationImpl(ITwEnumeration twEnumerationStruct)
        {
            Structure.ItemType = twEnumerationStruct.ItemType;
            Structure.NumItems = twEnumerationStruct.NumItems;
            Structure.CurrentIndex = twEnumerationStruct.CurrentIndex;
            Structure.DefaultIndex = twEnumerationStruct.DefaultIndex;
        }

        public override ItemType ItemType { get { return Structure.ItemType; } set { Structure.ItemType = value; } }
        public override uint NumItems { get { return Structure.NumItems; } set { Structure.NumItems = value; } }
        public override uint CurrentIndex { get { return Structure.CurrentIndex; } set { Structure.CurrentIndex = value; } }
        public override uint DefaultIndex { get { return Structure.DefaultIndex; } set { Structure.DefaultIndex = value; } }
        public override IntPtr Items { get { return Structure.Items; } set { Structure.Items = value; } }
    }
}
