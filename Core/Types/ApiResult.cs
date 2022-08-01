namespace CleanArchitecture.Core.Types;

public class ApiResult<T>
{
    public ApiResult(T data)
    {
        this.Data = data;
    }
    public bool IsSuccess { get; set; } = true;
    public T Data { get; set; }
    public string Message { get; set; }
}