namespace MesTestsEnTDD;

public class Validator<T>
{
    private readonly T _obj;

    public Validator(T obj)
    {
        _obj = obj;
    }

    public bool Validate()
    {
        return (true);
    }
}