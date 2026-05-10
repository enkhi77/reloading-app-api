using Microsoft.AspNetCore.Mvc;
using ReloadingAppWebApi.Data;
using ReloadingAppWebApi.Models;

namespace ReloadingAppWebApi.Controllers;

[ApiController]
[Route("api/[controller]")]

public class BulletController : ControllerBase
{
    private ReloadDbContext _dbContext;
    
    public BulletController(ReloadDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    [HttpGet]
    public IEnumerable<Bullet> Get()
    {
        return _dbContext.Bullets;
    }

    [HttpGet("{id}")]
    public Bullet Get(Guid id)
    {
        return _dbContext.Bullets.FirstOrDefault(b => b.Id == id);
    }

    [HttpPost]
    public void Post([FromBody] Bullet bullet)
    {
        _dbContext.Bullets.Add(bullet);
        _dbContext.SaveChanges();
    }
    
    [HttpPut("{id}")]
    public void Put(Guid id, [FromBody] Bullet bullet)
    {
        var existingBullet = _dbContext.Bullets.FirstOrDefault(b => b.Id == id);
        if (existingBullet != null)
        {
            existingBullet.Caliber = bullet.Caliber;
            existingBullet.DatePurchased = bullet.DatePurchased;
            existingBullet.Diameter = bullet.Diameter;
            existingBullet.Lot = bullet.Lot;
            existingBullet.Price = bullet.Price;
            existingBullet.Weight = bullet.Weight;
            _dbContext.SaveChanges();
        }
    }
    
    [HttpDelete("{id}")]
    public void Delete(Guid id)
    {
        var existingBullet = _dbContext.Bullets.FirstOrDefault(b => b.Id == id);
        if (existingBullet != null)
        {
            _dbContext.Bullets.Remove(existingBullet);
            _dbContext.SaveChanges();
        }
    }
}