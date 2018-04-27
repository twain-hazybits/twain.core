using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazybits.Twain.Core.Supplementary
{
    static class ItemTypeExtention
    {
        public static int SizeOf(this ItemType itemType)
        {
            switch (itemType)
            {
                case ItemType.Bool:
                    return sizeof(bool);
                case ItemType.UInt16:
                    return sizeof(ushort);
                case ItemType.Fix32:
                    throw new NotImplementedException("Not implemeted this yet");
                case ItemType.Frame:
                    throw new NotImplementedException("Not implemeted this yet");
                case ItemType.Handle:
                    throw new NotImplementedException("Not implemeted this yet");
                case ItemType.Int16:
                    return sizeof(short);
                case ItemType.Int32:
                    return sizeof(Int32);
                case ItemType.Int8:
                    return sizeof(sbyte);
                case ItemType.Str128:
                    throw new NotImplementedException("Not implemeted this yet");
                case ItemType.Str255:
                    throw new NotImplementedException("Not implemeted this yet");
                case ItemType.Str32:
                    throw new NotImplementedException("Not implemeted this yet");
                case ItemType.Str64:
                    throw new NotImplementedException("Not implemeted this yet");
                case ItemType.UInt32:
                    return sizeof(UInt32);
                case ItemType.UInt8:
                    return sizeof(byte);
            }
            return 0;
        }
    }
}
