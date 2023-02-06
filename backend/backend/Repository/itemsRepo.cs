using backend.Data;
using backend.Interface;
using backend.Models;
namespace backend.Repository;

public class itemsRepo : IItemsRepo
{
    private readonly ShopContext _context;
    
    public itemsRepo(ShopContext shopContext)
    {
        _context = shopContext;
    }
    public List<items> GetShopItems()
    {
        var query = (from items in _context.ShopItem select items).ToList();
        return query;
    }
    public void AddShopItems(items item)
    {
        if (item != null)
        {
            _context.ShopItem.Add(item);
            _context.SaveChanges();
        }
    }

    public string test(int id)
    {
        return _context.ShopItem.FirstOrDefault(x => x.id == id)?.detail;
    }
    
}