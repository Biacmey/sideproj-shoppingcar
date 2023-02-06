using backend.Models;

namespace backend.Interface;

public interface IItemsRepo
{
    public List<items> GetShopItems();
    public void AddShopItems(items item);
    public string test(int id);
}