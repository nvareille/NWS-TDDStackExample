using Microsoft.AspNetCore.Mvc;
using TDDStackExample.Shared.Models;

namespace TDDStackExample.Server.Controllers;

[Route("api/[controller]")]
public class IndexController : ControllerBase
{
    [HttpPost]
    public IActionResult Submit([FromBody]InscriptionModel obj)
    {
        return (Ok());
    }
}

// uwu :3