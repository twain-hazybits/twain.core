namespace Hazybits.Twain.Core.Implementation
{
    internal abstract class TwStatus<T> : TwainStructure<T>, Interfaces.ITwStatus
    {
        public abstract ConditionCode ConditionCode { get; set; }
    }
}
