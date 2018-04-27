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
    public abstract class StructWithData<T> : TwainStructure<T> where T : ITwainStructure
    {
        public virtual ItemType ItemType { get; set; }

        protected uint StructureDataItemsCount { get; set; }

        protected byte[] StructureData { get; set; }

        protected abstract IntPtr GetStructureDataPointer(IntPtr structurePtr);

        public override IntPtr GetStructurePtr()
        {
            return base.GetStructurePtr();
        }

        public override void ReadStructureFromPtr(IntPtr ptr)
        {
            base.ReadStructureFromPtr(ptr);

            var itemsDataSize = (int)StructureDataItemsCount * ItemType.SizeOf();

            var buffer = new byte[itemsDataSize];
            Marshal.Copy(GetStructureDataPointer(ptr), buffer, 0, itemsDataSize);
            StructureData = buffer;
        }

        protected delegate void ReadItem(IntPtr ptr, int index);

        protected void ReadItems(ReadItem readDelegate)
        {
            var ptr = Marshal.AllocHGlobal(StructureData.Length);
            Marshal.Copy(StructureData, 0, ptr, StructureData.Length);
            try
            {
                for (var i = 0; i < StructureDataItemsCount; i++)
                {
                    readDelegate(ptr, i);
                }
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }
        }

        #region Methods for getting items

        protected IList<UInt16> GetUInt16Items()
        {
            var items = new List<UInt16>();

            ReadItems((ptr, index) =>
            {
                items.Add((UInt16)Marshal.ReadInt16(ptr, index));
            });
            return items;
        }

        protected IList<bool> GetBoolItems()
        {
            var items = new List<bool>();

            //todo: verify whether bool values shoul be read this way
            ReadItems((ptr, index) => { items.Add(Marshal.ReadByte(ptr, index) == 1); });

            return items;
        }

        protected IList<Int16> GetInt16Items()
        {
            var items = new List<Int16>();
            ReadItems((ptr, index) => { items.Add(Marshal.ReadInt16(ptr, index)); });
            return items;
        }

        protected IList<Int32> GetInt32Items()
        {
            var items = new List<Int32>();
            ReadItems((ptr, index) => { items.Add(Marshal.ReadInt32(ptr, index)); });
            return items;
        }

        protected IList<UInt32> GetUInt32Items()
        {
            var items = new List<UInt32>();
            ReadItems((ptr, index) => { items.Add((UInt32)Marshal.ReadInt32(ptr, index)); });
            return items;
        }

        protected IList<sbyte> GetInt8Items()
        {
            var items = new List<sbyte>();
            ReadItems((ptr, index) => { items.Add((sbyte)Marshal.ReadByte(ptr, index)); });
            return items;
        }

        protected IList<byte> GetUInt8Items()
        {
            var items = new List<byte>();
            ReadItems((ptr, index) => { items.Add(Marshal.ReadByte(ptr, index)); });
            return items;
        }

#endregion

    }
}
