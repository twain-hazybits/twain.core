using Hazybits.Twain.Core.Implementation.Interfaces;

namespace Hazybits.Twain.Core.Implementation.Windows
{
    internal class TwVersionImpl : TwVersion<Structures.TwVersionStruct>
    {
        public TwVersionImpl() { }

        public TwVersionImpl(Structures.TwVersionStruct versionStruct)
        {
            Structure.MajorNum = versionStruct.MajorNum;
            Structure.MinorNum = versionStruct.MinorNum;
            Structure.Language = versionStruct.Language;
            Structure.Country = versionStruct.Country;
	        Structure.Info = versionStruct.Info;
        }

	    public TwVersionImpl(ITwVersion versionStruct)
	    {
		    Structure.MajorNum = versionStruct.MajorNum;
		    Structure.MinorNum = versionStruct.MinorNum;
		    Structure.Language = versionStruct.Language;
		    Structure.Country = versionStruct.Country;
		    Structure.Info = versionStruct.Info;
	    }

		public override ushort MajorNum { get { return Structure.MajorNum; } set { Structure.MajorNum = value; } }
        public override ushort MinorNum { get { return Structure.MinorNum; } set { Structure.MinorNum = value; } }
        public override ushort Language { get { return Structure.Language; } set { Structure.Language = value; } }
        public override ushort Country { get { return Structure.Country; } set { Structure.Country = value; } }
        public override string Info { get { return Structure.Info; } set { Structure.Info = value; } }
    }
}
