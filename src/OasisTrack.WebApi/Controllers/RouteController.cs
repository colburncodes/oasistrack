using Microsoft.AspNetCore.Mvc;
using OasisTrack.Core.Interfaces;

namespace OasisTrack.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RouteController : ControllerBase
{
    private readonly IRouteService _routeService;

    public RouteController(IRouteService routeService)
    {
        _routeService = routeService;
    }

}