using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hazybits.Twain.Core;

namespace Hazybits.Twain.Tester
{
    class TripletChoiceInfo
    {
        public DataGroup DG;
        public DataArgumentType DAT;
        public IList<Message> MSGs = new List<Message>();
    }

    class TripletHandlerParams
    {
        public DataGroup DG;
        public DataArgumentType DAT;
        public Message MSG;

        public DataSourceManager DSM;
        public Hazybits.Twain.Core.TwainStructures.TwIdentity DataSource;
        public Hazybits.Twain.Core.TwainStructures.TwCapability Capability;
    }

    delegate string HandleTriplet(TripletHandlerParams handlerParams);

    class TripletChoice
    {
        public TripletChoiceInfo ChoiceInfo { get; private set; }

        public HandleTriplet HandleTripletDelegate;

        //public TripletChoice(HandleTriplet handleTripletDelegate, DataGroup dg, DataArgumentType dat, params Hazybits.Twain.Core.Message[] msgs)
        public TripletChoice(HandleTriplet handleTripletDelegate, TripletChoiceInfo choiceInfo)
        {
            ChoiceInfo = choiceInfo;
            HandleTripletDelegate = handleTripletDelegate;
        }
    }
}
