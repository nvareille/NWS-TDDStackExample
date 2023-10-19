using TDDStackExample.Shared.Models;

namespace MesTestsEnTDD;

[TestClass]
public class ValidatorTests
{
    [TestMethod]
    public void InsciptionValide()
    {
        Validator<InscriptionModel> validator = new Validator<InscriptionModel>(new InscriptionModel
        {
            Email = "n.vareille@normandiewebschool.fr",
            Password = "Margoulin42",
            Number = 29
        });

        Assert.IsTrue(validator.Validate());
    }

    [TestMethod]
    public void InsciptionInvalide()
    {
        Validator<InscriptionModel> validator = new Validator<InscriptionModel>(new InscriptionModel
        {
            Email = "n.vareille@normandiewebschool",
            Password = "Margoulin42",
            Number = 29
        });

        Assert.IsFalse(validator.Validate());
    }
}