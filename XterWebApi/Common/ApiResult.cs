namespace XterWebApi.Common
{
    public class ApiResult
    {
        public bool IsSuccess { get; set; }
        public ErrorDTO? Error { get; set; }

        public static ApiResult Success()
        {
            return new ApiResult { IsSuccess = true };
        }

        public static ApiResult Fail(ErrorDTO error)
        {
            return new ApiResult { Error = error };
        }

        public class ErrorDTO
        {
            public ErrorDTO(int code, string message)
            {
                Code = code;
                Message = message;
            }

            public int Code { get; set; }

            public string Message { get; set; }
        }
    }

    public class ApiResult<T> : ApiResult
    {
        public T? Data { get; set; }

        public static ApiResult<T> Success(T data)
        {
            return new ApiResult<T> { IsSuccess = true, Data = data };
        }

        public static new ApiResult<T> Fail(ErrorDTO error)
        {
            return new ApiResult<T> { Error = error };
        }
    }
}
