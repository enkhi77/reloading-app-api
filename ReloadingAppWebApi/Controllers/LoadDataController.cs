using Microsoft.AspNetCore.Mvc;
using ReloadingAppWebApi.Models;

namespace ReloadingAppWebApi.Controllers;

[Route("api/[controller]")]
[ApiController]

public class LoadDataController : Controller
{
    // GET
    private readonly List<LoadData> _loadData =
    [
        new LoadData() { Id = Guid.NewGuid() },
        new LoadData() { Id = Guid.NewGuid() },
        new LoadData() { Id = Guid.NewGuid() }
    ];

    [HttpGet]
    public ActionResult<List<LoadData>> Get()
    {
        return _loadData;
    }
}