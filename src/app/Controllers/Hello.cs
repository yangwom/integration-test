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
     return "hello, use /{language} to get a hello in your language!";
    }

    [Route("[controller]/{language}")]
    [HttpGet]
    public string Get(string language)
    {
        if(language == "br") return "[br] : Olá";
        if(language == "en") return "[en] : Hello";
        if(language == "es") return "[es] : Hola";
        if(language == "de") return "[de] : Hallo";
        return "Não conheço essa!";
    }
}
