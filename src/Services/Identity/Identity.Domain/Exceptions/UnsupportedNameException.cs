namespace sattec.Identity.Domain.Exceptions;

public class UnsupportedNameException : Exception
{
    public UnsupportedNameException(string code)
        : base($"Name \"{code}\" is unsupported.")
    {
    }
}
