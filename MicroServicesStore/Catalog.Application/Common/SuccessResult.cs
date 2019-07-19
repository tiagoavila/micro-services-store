namespace Catalog.Application.Common
{
    public sealed class SuccessResult : Result
    {
        public SuccessResult() : base(true, string.Empty)
        {

        }

        public SuccessResult(string message) : base(true, message)
        {

        }
    }
}
