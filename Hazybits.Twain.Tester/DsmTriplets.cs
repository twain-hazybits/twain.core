using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hazybits.Twain.Core;

namespace Hazybits.Twain.Tester
{
    static class DsmTriplets
    {
        public static TripletChoiceInfo ControlIdentity = new TripletChoiceInfo {
            DG = DataGroup.Control,
            DAT = DataArgumentType.Identity,
            MSGs = new List<Message> { Message.CloseDs, Message.GetDefault, Message.GetFirst, Message.GetNext, Message.OpenDs, Message.Set, Message.UserSelect }
        };

        public static TripletChoiceInfo ControlParent = new TripletChoiceInfo
        {
            DG = DataGroup.Control,
            DAT = DataArgumentType.Parent,
            MSGs = new List<Message> { Message.OpenDsm, Message.CloseDsm }
        };

        public static TripletChoiceInfo ControlStatus = new TripletChoiceInfo
        {
            DG = DataGroup.Control,
            DAT = DataArgumentType.Status,
            MSGs = new List<Message> { Message.Get }
        };
    }
}
