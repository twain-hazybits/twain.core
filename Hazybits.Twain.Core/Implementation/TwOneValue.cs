using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazybits.Twain.Core.Implementation
{
    internal abstract class TwOneValue<T> : TwainStructure<T>, Interfaces.ITwOneValue
    {
        public abstract ItemType ItemType { get; set; }

        public abstract IntPtr Item { get; set; }
    }
}
