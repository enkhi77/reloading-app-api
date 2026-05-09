using Microsoft.AspNetCore.Mvc;
using ReloadingAppWebApi.Models;

namespace ReloadingAppWebApi.Controllers;

[Route("api/[controller]")]
[ApiController]

public class RecipesController : Controller
{
    // GET
    // ReSharper disable once FieldCanBeMadeReadOnly.Local
    private static List<Recipe> _recipes =
    [
        new Recipe() { Id = 1, Name = "Recipe 1", Description = "Recipe 1 Description", Oal = .754 },
        new Recipe() { Id = 2, Name = "Recipe 2", Description = "Recipe 2 Description", Oal = .754 },
        new Recipe() { Id = 3, Name = "Recipe 3", Description = "Recipe 3 Description", Oal = .754 }
    ];
    
    [HttpGet]
    public ActionResult<List<Recipe>> Get()
    {
        return _recipes;
    }
}