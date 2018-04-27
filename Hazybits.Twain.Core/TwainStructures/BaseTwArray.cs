using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Hazybits.Twain.Core.Implementation.Interfaces;

namespace Hazybits.Twain.Core.TwainStructures
{
    public abstract class BaseTwArray<T> : StructWithData<T> where T : ITwainStructure
    {
        public virtual uint NumItems { get => StructureDataItemsCount; set => StructureDataItemsCount = value; }

        #region Methods for getting items

        public new IList<UInt16> GetUInt16Items()
        {
            return base.GetUInt16Items();
        }

        public new IList<bool> GetBoolItems()
        {
            return base.GetBoolItems();
        }

        public new IList<Int16> GetInt16Items()
        {
            return base.GetInt16Items();
        }

        public new IList<Int32> GetInt32Items()
        {
            return base.GetInt32Items();
        }

        public new IList<UInt32> GetUInt32Items()
        {
            return base.GetUInt32Items();
        }

        public new IList<sbyte> GetInt8Items()
        {
            return base.GetInt8Items();
        }

        public new IList<byte> GetUInt8Items()
        {
            return base.GetUInt8Items();
        }

        #endregion

    }
}
