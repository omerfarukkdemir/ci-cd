using Microsoft.AspNetCore.Mvc;

namespace ci_cd.Controllers;

[ApiController]
[Route("/test")]
public class TestController : ControllerBase
{
    [HttpGet] 
    public string Get()
    {
        return "fenerbahce";
    }
}