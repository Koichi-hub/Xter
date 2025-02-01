using FluentResults;

namespace XterWebApi.Common.Errors
{
    public class NotFoundError(string message) : Error(message)
    {
    }
}
