using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Testing;
using TDDStackExample.Server;
using TDDStackExample.Shared.Models;

namespace MesTestsEnTDD;

[TestClass]
public class IndexControllerTests
{
    readonly WebApplicationFactory<MyApplicationBuilder> _factory = new WebApplicationFactory<MyApplicationBuilder>();

    [TestMethod]
    public async Task InscriptionBadRequest()
    {
        HttpClient client = _factory.CreateClient();
        HttpResponseMessage response = await client.PostAsJsonAsync("http://localhost:5000/api/index", new InscriptionModel
        {
            Email = "yrousselle@normandiewebsch@@o",
            Password = "Symfony42",
            Number = 21
        });

        Assert.AreEqual(new BadRequestResult().StatusCode, (int)response.StatusCode);
    }

    [TestMethod]
    public async Task InscriptionOK()
    {
        HttpClient client = _factory.CreateClient();
        HttpResponseMessage response = await client.PostAsJsonAsync("http://localhost:5000/api/index", new InscriptionModel
        {
            Email = "yrousselle@normandiewebschool.fr",
            Password = "Symfony42",
            Number = 21
        });

        Assert.AreEqual(new OkResult().StatusCode, (int)response.StatusCode);
    }

    [TestCleanup]
    public void Cleanup()
    {
        _factory.Dispose();
    }
}