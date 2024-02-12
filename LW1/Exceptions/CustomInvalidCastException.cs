namespace LW1.Exceptions;

public class CustomInvalidCastException : InvalidCastException
{
    public string AdditionalInfo { get; private set; }

    public CustomInvalidCastException(string additionalInfo)
        :base()
    {
        AdditionalInfo = additionalInfo;
    }
}