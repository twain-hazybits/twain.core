using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazybits.Twain.Tester
{
    class CapabilityValue
    {
        public Hazybits.Twain.Core.Capability Capability { get; set; }
        public Type PissibleValues { get; set; }
        public Hazybits.Twain.Core.ItemType ItemType { get; set; }

        public override string ToString()
        {
            return Capability.ToString();
        }
    }
}
