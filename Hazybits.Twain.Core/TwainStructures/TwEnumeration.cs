using System;
using Hazybits.Twain.Core.Implementation.Interfaces;

namespace Hazybits.Twain.Core.TwainStructures
{
    public class TwEnumeration : BaseTwArray<ITwEnumeration>, ITwEnumeration
    {
        public TwEnumeration()
        {
            PlatformStructure = Implementation.FactoryImpl.CreateTwEnumeration();
        }

        public override ItemType ItemType { get { return PlatformStructure.ItemType; } set { PlatformStructure.ItemType = value; } }
        public override uint NumItems { get { return PlatformStructure.NumItems; } set { PlatformStructure.NumItems = value; } }
        public uint CurrentIndex { get { return PlatformStructure.CurrentIndex; } set { PlatformStructure.CurrentIndex = value; } }
        public uint DefaultIndex { get { return PlatformStructure.DefaultIndex; } set { PlatformStructure.DefaultIndex = value; } }

        protected override IntPtr GetStructureDataPointer(IntPtr structurePtr)
        {
            return structurePtr + sizeof(ItemType) + sizeof(uint) * 3;
        }
    }
}
