
namespace Hazybits.Twain.Core.Implementation.Windows
{
    internal class TwStatusImpl : TwStatus<Structures.TwStatusStruct>
    {
        public override ConditionCode ConditionCode { get { return (ConditionCode)Structure.ConditionCode; } set { Structure.ConditionCode = (ushort)value; } }
    }
}
