using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/")]
public class HomeController : ControllerBase
{
    public IActionResult Index() 
    {
        return Ok("Home Page");
    }
}