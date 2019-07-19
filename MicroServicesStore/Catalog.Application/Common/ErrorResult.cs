namespace Catalog.Application.Common
{
    public sealed class ErrorResult : Result
    {
        public ErrorResult() : base(false, string.Empty)
        {

        }

        public ErrorResult(string message) : base(false, message)
        {

        }
    }
}
