using TDDStackExample.Shared;
using TDDStackExample.Shared.Models;

namespace MesTestsEnTDD;

[TestClass]
public class InscriptionModelValidatorTests
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
    public void InsciptionInvalideNoEmail()
    {
        Validator<InscriptionModel> validator = new Validator<InscriptionModel>(new InscriptionModel
        {
            Email = "",
            Password = "Margoulin42",
            Number = 29
        });

        Assert.IsFalse(validator.Validate());
    }

    [TestMethod]
    public void InscriptionInvalideBadEmail()
    {
        Validator<InscriptionModel> validator = new Validator<InscriptionModel>(new InscriptionModel
        {
            Email = "n.vareille@normandiewebschool@r",
            Password = "Margoulin42",
            Number = 29
        });

        Assert.IsFalse(validator.Validate());
    }

    [TestMethod]
    public void InsciptionInvalideNoMDP()
    {
        Validator<InscriptionModel> validator = new Validator<InscriptionModel>(new InscriptionModel
        {
            Email = "n.vareille@normandiewebschool.fr",
            Password = "",
            Number = 29
        });

        Assert.IsFalse(validator.Validate());
    }

    [TestMethod]
    public void InsciptionValideNoAge()
    {
        Validator<InscriptionModel> validator = new Validator<InscriptionModel>(new InscriptionModel
        {
            Email = "n.vareille@normandiewebschool.fr",
            Password = "Margoulin42"
        });

        Assert.IsFalse(validator.Validate());
    }

    [TestMethod]
    public void InsciptionInvalideNoMajeur()
    {
        Validator<InscriptionModel> validator = new Validator<InscriptionModel>(new InscriptionModel
        {
            Email = "n.vareille@normandiewebschool@",
            Password = "Margoulin42",
            Number = 11
        });

        Assert.IsFalse(validator.Validate());
    }
}