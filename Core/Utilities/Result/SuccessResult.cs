namespace Core.Utilities.Result
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(success: true, message)
        {

        }
        public SuccessResult() : base(success: true)
        {

        }
    }
}