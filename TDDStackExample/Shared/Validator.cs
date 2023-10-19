using System.ComponentModel.DataAnnotations;

namespace TDDStackExample.Shared;

public class Validator<T> 
    where T : class
{
    private readonly T Model;

    public Validator(T obj)
    {
        Model = obj;
    }

    public bool Validate()
    {
        ValidationContext ctx = new ValidationContext(Model, null, null);
        List<ValidationResult> results = new();
        bool result = System.ComponentModel.DataAnnotations.Validator.TryValidateObject(Model, ctx, results, true);

        return (result);
    }
}