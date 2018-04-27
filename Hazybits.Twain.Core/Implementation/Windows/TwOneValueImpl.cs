using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hazybits.Twain.Core.Implementation.Interfaces;

namespace Hazybits.Twain.Core.Implementation.Windows
{
    internal class TwOneValueImpl : TwOneValue<Structures.TwOneValueStruct>
    {
        public TwOneValueImpl() { }

        public TwOneValueImpl(Structures.TwOneValueStruct twOneValueStruct)
        {
            Structure.ItemType = twOneValueStruct.ItemType;
        }

        public TwOneValueImpl(ITwOneValue twOneValue)
        {
            Structure.ItemType = twOneValue.ItemType;
        }

        public override ItemType ItemType { get { return Structure.ItemType; } set { Structure.ItemType = value; } }

        public override IntPtr Item { get { return Structure.Item; } set { Structure.Item = value; } }
    }
}
