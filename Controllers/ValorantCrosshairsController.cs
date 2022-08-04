using Microsoft.AspNetCore.Mvc;

namespace symphony_server.Controllers;

[ApiController]
[Route("valorant/crosshairs")]
public class ValorantCrosshairsController : ControllerBase
{
    private readonly ILogger<ValorantCrosshairsController> _logger;

    public ValorantCrosshairsController(ILogger<ValorantCrosshairsController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetValorantCrosshairs")]
    public string GetValorantCrosshairs()
    {
        return "Success";
    }
}
