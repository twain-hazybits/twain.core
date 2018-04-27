using System;

namespace Hazybits.Twain.Core.Implementation.Interfaces
{
    public interface ITwEnumeration : ITwainStructure
    {
        ItemType ItemType { get; set; }
        uint NumItems { get; set; }
        uint CurrentIndex { get; set; }
        uint DefaultIndex { get; set; }
        //public byte[] ItemList;
    }
}
