using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hazybits.Twain.Core;

namespace Hazybits.Twain.Tester
{
    static class DataSourceTriplets
    {
        public static TripletChoiceInfo ControlCapability = new TripletChoiceInfo
        {
            DG = DataGroup.Control,
            DAT = DataArgumentType.Capability,
            MSGs = new List<Message> {
                Message.Get,
                Message.GetCurrent,
                Message.GetDefault,
                //Message.GetHelp,
                //Message.GetLabel,
                //Message.GetLabelNum,
                Message.QuerySupport,
                Message.Reset,
                Message.ResetAll,
                Message.Set /*, Message.SetConstraint*/ }
        };
    }
}
