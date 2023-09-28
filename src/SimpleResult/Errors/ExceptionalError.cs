using SimpleResult.Core;

namespace SimpleResult;

public record ExceptionalError : BaseError, IExceptionalError
{
    public Exception Exception { get; init; }

    public ExceptionalError(Exception exception)
        : base(exception.Message)
    {
        Exception = exception;
    }

    public ExceptionalError(string message, Exception exception)
        : base(message)
    {
        Exception = exception;
    }

    public ExceptionalError(Exception exception, IError causedBy)
        : base(exception.Message, causedBy)
    {
        Exception = exception;
    }

    public ExceptionalError(Exception exception, params IError[] causedBy)
        : base(exception.Message, causedBy)
    {
        Exception = exception;
    }

    public ExceptionalError(Exception exception, IEnumerable<IError> causedBy)
        : base(exception.Message, causedBy)
    {
        Exception = exception;
    }
}