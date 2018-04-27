using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazybits.Twain.Core.Implementation
{
    internal abstract class TwEnumeration<T> : TwainStructure<T>, Interfaces.ITwEnumeration
    {
        public abstract ItemType ItemType { get; set; }
        public abstract uint NumItems { get; set; }
        public abstract uint CurrentIndex { get; set; }
        public abstract uint DefaultIndex { get; set; }
        public abstract IntPtr Items { get; set; }
    }
}
