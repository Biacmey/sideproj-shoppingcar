using backend.Data;
using backend.Interface;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using backend.Models;
using backend.Repository;

namespace backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestApiController : ControllerBase
{
    private readonly IItemsRepo _itemsRepo;
    public TestApiController(IItemsRepo itemsRepo)
    {
        _itemsRepo = itemsRepo;
    }
    
    [HttpGet("~/GetConnection/")]
    public string GetConnection()
    {
        return "you are connection success";
    }
    
    [HttpGet("~/GetItems/")]
    public List<items> GetItemData()
    {
        // var items = new List<items>();
        // var k = _itemsRepo.GetShopItems();
        // var d = _itemsRepo.test(1);
        // items.Add(new items(1,"iphone14",5400,"https://m-cdn.phonearena.com/images/phones/82526-350/Apple-iPhone-14.webp",10,"okok"));
        // items.Add(new items(2,"iphone13",5200,"https://m-cdn.phonearena.com/images/phones/82892-350/Apple-iPhone-13.webp",10,"okokdd"));
        return _itemsRepo.GetShopItems();
    }

    [HttpPost("~/AddItem/")]
    public void AddItems(items item)
    {
        _itemsRepo.AddShopItems(item);
    }
    
    [HttpPost("~/CheckOutItem/")]
    public void CheckOutItems(List<items>? items)
    {
        if (items != null)
        {
            foreach (var item in items)
            {
                
            }
        }
    }
    
}