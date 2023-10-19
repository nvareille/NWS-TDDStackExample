using Microsoft.AspNetCore.Mvc;
using TDDStackExample.Shared;
using TDDStackExample.Shared.Models;

namespace TDDStackExample.Server.Controllers;

[Route("api/[controller]")]
public class IndexController : ControllerBase
{
    public IndexController()
    {
        
    }

    [HttpPost]
    public IActionResult Submit([FromBody]InscriptionModel obj)
    {
        if (!new Validator<InscriptionModel>(obj).Validate())
            return (BadRequest());
        return (Ok());
    }
}

// uwu :3