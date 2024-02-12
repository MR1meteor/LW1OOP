namespace LW1.Exceptions;

public class InvalidValidationException<T> : Exception
{
    public T ValueObject { get; private set; }
    public string Description { get; private set; }
    
    public InvalidValidationException(T valueObject, string description)
    {
        ValueObject = valueObject;
        Description = description;
    }
}