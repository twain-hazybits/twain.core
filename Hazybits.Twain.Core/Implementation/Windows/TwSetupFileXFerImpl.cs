using System;
namespace Hazybits.Twain.Core.Implementation.Windows
{
    internal class TwSetupFileXFerImpl : TwSetupFileXFer<Structures.TwSetupFileXFerStruct>
    {
        public override string FileName { get { return Structure.FileName; } set { Structure.FileName = value; } }
        public override Int16 Format { get { return Structure.Format; } set { Structure.Format = value; } }
        public override Int16 VRefNum { get { return Structure.VRefNum; } set { Structure.VRefNum = value; } }
	}
}
