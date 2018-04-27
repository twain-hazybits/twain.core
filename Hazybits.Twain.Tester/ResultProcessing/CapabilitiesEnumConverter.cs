using System;
using System.Collections.Generic;
using System.Linq;
using Hazybits.Twain.Core;

namespace Hazybits.Twain.Tester.ResultProcessing
{
    static class CapabilitiesEnumConverter
    {
        class CapabilityConverterTripple
        {
            public Capability Capability { get; set; }
            public Type CapabilityEnumType { get; set; }
        }

        private static IList<CapabilityConverterTripple> Converters = new List<CapabilityConverterTripple>
        {
            new CapabilityConverterTripple {Capability = Capability.Compression, CapabilityEnumType = typeof(TWCP)},
            //todo: add other capabilities here
        };

        public static string Convert(Capability capability, object item)
        {
            var converter = Converters.FirstOrDefault((c) => { return c.Capability == capability; });
            if (converter == null)
                return item.ToString();

            var valueOfCapabilityType = Enum.ToObject(converter.CapabilityEnumType, item);
            return valueOfCapabilityType.ToString();
        }
    }
}
