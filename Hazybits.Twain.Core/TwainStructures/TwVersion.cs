using Hazybits.Twain.Core.Implementation.Interfaces;

namespace Hazybits.Twain.Core.TwainStructures
{
    public class TwVersion : TwainStructure<ITwVersion>, ITwVersion
	{
        public TwVersion()
        {
            PlatformStructure = Implementation.FactoryImpl.CreateTwVersion();
        }

        public TwVersion(ITwVersion version)
        {
			PlatformStructure = Implementation.FactoryImpl.CreateTwVersion();
            MajorNum = version.MajorNum;
            MinorNum = version.MinorNum;
            Language = version.Language;
            Country = version.Country;
            Info = version.Info;
		}

        public ushort MajorNum { get { return PlatformStructure.MajorNum; } set { PlatformStructure.MajorNum = value; } }
        public ushort MinorNum { get { return PlatformStructure.MinorNum; } set { PlatformStructure.MinorNum = value; } }
        public ushort Language { get { return PlatformStructure.Language; } set { PlatformStructure.Language = value; } }
        public ushort Country { get { return PlatformStructure.Country; } set { PlatformStructure.Country = value; } }
        public string Info { get { return PlatformStructure.Info; } set { PlatformStructure.Info = value; } }
	}
}
