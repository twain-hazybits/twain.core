using System;
namespace Hazybits.Twain.Core.Implementation.Interfaces
{
    public interface ITwSetupFileXFer : ITwainStructure
    {
        string FileName { get; set; }
        Int16 Format { get; set; }
		Int16 VRefNum { get; set; }
	}
}
