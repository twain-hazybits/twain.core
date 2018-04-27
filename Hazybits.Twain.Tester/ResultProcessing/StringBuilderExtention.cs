using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hazybits.Twain.Core;
using Hazybits.Twain.Core.TwainStructures;

namespace Hazybits.Twain.Tester.ResultProcessing
{
    static class StringBuilderExtention
    {
        private delegate IEnumerable GetItemsDataDelegate(TwEnumeration twEnumeration);
        private static IList<KeyValuePair<ItemType, GetItemsDataDelegate>> ItemsDataGetters = new List<KeyValuePair<ItemType, GetItemsDataDelegate>>
        {
            new KeyValuePair<ItemType, GetItemsDataDelegate>(ItemType.UInt16, GetUInt16ItemsData),
            new KeyValuePair<ItemType, GetItemsDataDelegate>(ItemType.Int16, GetInt16ItemsData),
            new KeyValuePair<ItemType, GetItemsDataDelegate>(ItemType.Int32, GetInt32ItemsData),
            new KeyValuePair<ItemType, GetItemsDataDelegate>(ItemType.UInt32, GetUInt32ItemsData),
        };

        private delegate object GetItemDataDelegate(TwOneValue twOneValue);
        private static IList<KeyValuePair<ItemType, GetItemDataDelegate>> ItemDataGetters = new List<KeyValuePair<ItemType, GetItemDataDelegate>>
        {
            new KeyValuePair<ItemType, GetItemDataDelegate>(ItemType.UInt16, GetUInt16ItemData),
            new KeyValuePair<ItemType, GetItemDataDelegate>(ItemType.Int16, GetInt16ItemData),
            new KeyValuePair<ItemType, GetItemDataDelegate>(ItemType.UInt32, GetUInt32ItemData),
            new KeyValuePair<ItemType, GetItemDataDelegate>(ItemType.Int32, GetInt32ItemData),
        };

        public static void AppendTwOneValueItem(this StringBuilder str, Capability capability, TwOneValue twOneValue)
        {
            var getter = ItemDataGetters.FirstOrDefault((g) => { return g.Key == twOneValue.ItemType; });
            if (getter.Equals(default(KeyValuePair<ItemType, GetItemDataDelegate>)))
                throw new NotImplementedException(string.Format("The getter for this type ({0}) is not implemented.", twOneValue.ItemType));

            var val = getter.Value(twOneValue);
            str.AppendFormat("{0}", CapabilitiesEnumConverter.Convert(capability, val));
        }

        public static void AppendTwOneValueFlagItem(this StringBuilder str, TwOneValue twOneValue, Type enumType)
        {
            var getter = ItemDataGetters.FirstOrDefault((g) => { return g.Key == twOneValue.ItemType; });
            if (getter.Equals(default(KeyValuePair<ItemType, GetItemDataDelegate>)))
                throw new NotImplementedException(string.Format("The getter for this type ({0}) is not implemented.", twOneValue.ItemType));

            var val = getter.Value(twOneValue);
            var values = Enum.GetValues(enumType);
            var enumVal = Enum.ToObject(enumType, val);
            str.AppendFormat("{0}", enumVal);
        }

        public static void AppendTwEnumerationItems(this StringBuilder str, Capability capability, TwEnumeration twEnumeration)
        {
            var getter = ItemsDataGetters.FirstOrDefault((g) => { return g.Key == twEnumeration.ItemType; });
            if (getter.Equals(default(KeyValuePair<ItemType, GetItemsDataDelegate>)))
                throw new NotImplementedException(string.Format("The getter for this type ({0}) is not implemented.", twEnumeration.ItemType));

            var list = getter.Value(twEnumeration);
            foreach (var item in list)
            {
                str.AppendLine();
                str.AppendFormat("{0}", CapabilitiesEnumConverter.Convert(capability, item));
            }
        }

        #region TwEnumeration Items Data getters

        private static IEnumerable GetUInt16ItemsData(TwEnumeration twEnumeration)
        {
            return twEnumeration.GetUInt16Items();
        }
        private static IEnumerable GetInt16ItemsData(TwEnumeration twEnumeration)
        {
            return twEnumeration.GetInt16Items();
        }

        private static IEnumerable GetUInt32ItemsData(TwEnumeration twEnumeration)
        {
            return twEnumeration.GetUInt32Items();
        }
        private static IEnumerable GetInt32ItemsData(TwEnumeration twEnumeration)
        {
            return twEnumeration.GetInt32Items();
        }

        #endregion

        #region TwOneValue Item data getters

        private static object GetUInt16ItemData(TwOneValue twOneValue)
        {
            return twOneValue.GetUInt16Item();
        }
        private static object GetInt16ItemData(TwOneValue twOneValue)
        {
            return twOneValue.GetInt16Item();
        }

        private static object GetUInt32ItemData(TwOneValue twOneValue)
        {
            return twOneValue.GetUInt32Item();
        }
        private static object GetInt32ItemData(TwOneValue twOneValue)
        {
            return twOneValue.GetInt32Item();
        }

        #endregion
    }
}
