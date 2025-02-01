using FluentResults;

namespace XterWebApi.Common.Extensions
{
    public static class ResultExtensions
    {
        public static ApiResult ToApiResult(this Result result)
        {
            if (result.IsSuccess)
                return ApiResult.Success();

            var error = result.Errors.First();
            return ApiResult.Fail(TransformError(error));
        }

        public static ApiResult<T> ToApiResult<T>(this Result<T> result)
        {
            if (result.IsSuccess)
                return ApiResult<T>.Success(result.Value);

            var error = result.Errors.First();
            return ApiResult<T>.Fail(TransformError(error));
        }

        private static ApiResult.ErrorDTO TransformError(IError error)
        {
            var errorCode = TransformErrorCode(error);

            return new ApiResult.ErrorDTO(errorCode, error.Message);
        }

        private static int TransformErrorCode(IError error)
        {
            if (error.Metadata.TryGetValue("ErrorCode", out var errorCode))
                return (int)errorCode;

            return default;
        }
    }
}
