using System;
using Hazybits.Twain.Core.Implementation.Interfaces;

namespace Hazybits.Twain.Core.TwainStructures
{
    public class TwSetupFileXFer : TwainStructure<ITwSetupFileXFer>, ITwSetupFileXFer
    {
        public TwSetupFileXFer()
        {
            PlatformStructure = Implementation.FactoryImpl.CreateTwSetupFileXFer();
        }

        public string FileName { get {return PlatformStructure.FileName; } set {PlatformStructure.FileName = value;} }
        public Int16 Format { get { return PlatformStructure.Format; } set { PlatformStructure.Format = value; } }
        public Int16 VRefNum { get { return PlatformStructure.VRefNum; } set { PlatformStructure.VRefNum = value; } }

	}
}
