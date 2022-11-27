namespace sattec.Identity.Application.Common.Exceptions;

public class FoundException : Exception
{
    public FoundException()
        : base()
    {
    }

    public FoundException(string message)
        : base(message)
    {
    }

    public FoundException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public FoundException(string phoneNumber, object key)
        : base($"Entity \"{phoneNumber}\" ({key}) was found.")
    {
    }
}
