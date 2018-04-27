using Hazybits.Twain.Core.Implementation.Interfaces;

namespace Hazybits.Twain.Core.TwainStructures
{
    public class TwStatus : TwainStructure<ITwStatus>, ITwStatus
	{
		public TwStatus()
		{
			PlatformStructure = Implementation.FactoryImpl.CreateTwStatus();
		}

        public ConditionCode ConditionCode { get { return PlatformStructure.ConditionCode; } set { PlatformStructure.ConditionCode = value; } }
	}
}
