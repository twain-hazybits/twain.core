using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Hazybits.Twain.Core.Implementation.Interfaces;
using Hazybits.Twain.Core.Supplementary;

namespace Hazybits.Twain.Core.TwainStructures
{
    public class TwOneValue : StructWithData<ITwOneValue>, ITwOneValue
    {
        public TwOneValue()
        {
            StructureDataItemsCount = 1;
            PlatformStructure = Implementation.FactoryImpl.CreateTwOneValue();
        }

        public override ItemType ItemType { get { return PlatformStructure.ItemType; } set { ItemType = value; } }

        protected override IntPtr GetStructureDataPointer(IntPtr structurePtr)
        {
            return structurePtr + sizeof(ItemType);
        }

        #region Methods for getting items

        public UInt16 GetUInt16Item()
        {
            return GetUInt16Items()[0];
        }

        public bool GetBoolItem()
        {
            return GetBoolItems()[0];
        }

        public Int16 GetInt16Item()
        {
            return GetInt16Items()[0];
        }

        public Int32 GetInt32Item()
        {
            return GetInt32Items()[0];
        }

        public UInt32 GetUInt32Item()
        {
            return GetUInt32Items()[0];
        }

        public sbyte GetInt8Item()
        {
            return GetInt8Items()[0];
        }

        public byte GetUInt8Item()
        {
            return GetUInt8Items()[0];
        }

        #endregion
    }
}
