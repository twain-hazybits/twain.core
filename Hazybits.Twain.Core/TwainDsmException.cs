
namespace Hazybits.Twain.Core
{
    public class TwainDsmException : TwainException
    {
        public TwainDsmException(ReturnCode error, ConditionCode conditionCode) : base(TwainDsmException.GetErrorMessage(error, conditionCode))
        {
        }

        private static string GetErrorMessage(ReturnCode error, ConditionCode conditionCode)
        {
            // todo: update the method with real error messages.
            return string.Format("error message should be here. error code: {0}, coditionCode: {1}", error, conditionCode);
        }
    }
}
