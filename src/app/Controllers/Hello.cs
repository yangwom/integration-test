using Microsoft.AspNetCore.Mvc;

namespace app.Controllers;

[ApiController]
public class HelloController : ControllerBase
{

    private readonly ILogger<HelloController> _logger;

    public HelloController(ILogger<HelloController> logger)
    {
        _logger = logger;
    }

    [Route("[controller]")]
    [HttpGet]    
    public string Get()
    {
        throw new NotImplementedException();
    }

    [Route("[controller]/{}")]
    [HttpGet]
    public string Get(string language)
    {
        throw new NotImplementedException();  
    }
}
