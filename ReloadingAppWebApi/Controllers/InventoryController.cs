using Microsoft.AspNetCore.Mvc;
using ReloadingAppWebApi.Models;

namespace ReloadingAppWebApi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class InventoryController: ControllerBase
{
    private static List<Bullet> _bullets =
    [
        new Bullet() { Id = 1, Name = "Bullet 1", Diameter = .355, Weight = 115 },
        new Bullet() { Id = 2, Name = "Bullet 2", Diameter = .455, Weight = 230 },
        new Bullet() { Id = 3, Name = "Bullet 3", Diameter = .224, Weight = 55 }
    ];
    
    [HttpGet]
    public IEnumerable<Bullet> GetBullets()
    {
        return Bullets;
    }

    [HttpPost]
    public void Post([FromBody] Bullet bullet)
    {
        Bullets.Add(bullet);
    }
    
    // api/bullets/id
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Bullet bullet)
    {
        var existingBullet = _bullets.FirstOrDefault(b => b.Id == id);
        if (existingBullet != null)
        {
            existingBullet.Name = bullet.Name;
            existingBullet.ManufacturerId = bullet.ManufacturerId;
            existingBullet.Diameter = bullet.Diameter;
            existingBullet.Weight = bullet.Weight;
            existingBullet.Lot = bullet.Lot;
            existingBullet.Price = bullet.Price;
            
        }
    }
    
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        var existingBullet = Bullets.FirstOrDefault(b => b.Id == id);
        if (existingBullet != null)
        {
            Bullets.Remove(existingBullet);
        }
    }
}