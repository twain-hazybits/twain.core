using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazybits.Twain.Tester
{
    static class TwainStructuresExtensions
    {
        public static string ToFormattedString(this Hazybits.Twain.Core.TwainStructures.TwIdentity identity)
        {
            var resultTemplate = "Id={0}" + Environment.NewLine +
                                    "Version.MajorNum = {1}" + Environment.NewLine +
                                    "Version.MinorNum = {2}" + Environment.NewLine +
                                    "Version.Language = {3}" + Environment.NewLine +
                                    "Version.Country = {4}" + Environment.NewLine +
                                    "Version.Info = {5}" + Environment.NewLine +
                                    "ProtocolMajor = {6}" + Environment.NewLine +
                                    "ProtocolMinor = {7}" + Environment.NewLine +
                                    "SupportedGroups = {8}" + Environment.NewLine +
                                    "Manufacturer = {9}" + Environment.NewLine +
                                    "ProductFamily = {10}" + Environment.NewLine +
                                    "ProductName = {11}";

            return string.Format(resultTemplate, identity.Id, identity.Version.MajorNum, identity.Version.MinorNum, identity.Version.Language,
                identity.Version.Country, identity.Version.Info, identity.ProtocolMajor, identity.ProtocolMinor, identity.SupportedGroups,
                identity.Manufacturer, identity.ProductFamily, identity.ProductName);
        }

        public static string ToFormattedString(this Hazybits.Twain.Core.TwainStructures.TwStatus status)
        {
            return string.Format("ConditionCode = {0}", status.ConditionCode);
        }

        public static string ToFormattedString(this Hazybits.Twain.Core.TwainStructures.TwCapability capability)
        {
            var resultTemplate = "ItemType: {0}" + Environment.NewLine +
                                "Item: {1}";

            // todo: convert container pointer to real value
            return string.Format(resultTemplate, capability.ContainerType, capability.Container);
        }

        public static string ToFormattedString(this Hazybits.Twain.Core.TwainStructures.TwEnumeration twEnumeration)
        {
            var resultTemplate = "ItemType: {0}" + Environment.NewLine +
                                "NumItems: {1}" + Environment.NewLine +
                                "CurrentIndex: {2}" + Environment.NewLine +
                                "DefaultIndex {3}";

            return string.Format(resultTemplate, twEnumeration.ItemType, twEnumeration.NumItems, twEnumeration.CurrentIndex, twEnumeration.DefaultIndex);
        }

        public static string ToFormattedString(this Hazybits.Twain.Core.TwainStructures.TwOneValue twOneValue)
        {
            var resultTemplate = "ItemType: {0}";

            return string.Format(resultTemplate, twOneValue.ItemType);
        }
    }
}