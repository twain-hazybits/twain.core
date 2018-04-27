using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazybits.Twain.Tester
{
    static class Capabilities
    {
        private static IList<CapabilityValue> values = new List<CapabilityValue>
        {
            new CapabilityValue {Capability = Hazybits.Twain.Core.Capability.Compression, PissibleValues = typeof(Hazybits.Twain.Core.Constants.TwCP), ItemType = Hazybits.Twain.Core.ItemType.Int16 },
            new CapabilityValue {Capability = Hazybits.Twain.Core.Capability.Compression, PissibleValues = typeof(Hazybits.Twain.Core.Constants.TwCP), ItemType = Hazybits.Twain.Core.ItemType.Int16 },
        };

        public static IList<CapabilityValue> Values { get { return values; } }
    }
}
