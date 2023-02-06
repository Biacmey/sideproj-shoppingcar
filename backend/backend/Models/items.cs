namespace backend.Models;

public class items
{
    public int id { get; set; }
    public string name { get; set; }
    public int price { get; set; }
    public string imgSrc { get; set; }
    public int count { get; set; }
    public string detail { get; set; }

    // public items(int id ,string name, int price, string imgSrc, int count, string detail)
    // {
    //     id = id;
    //     name = name;
    //     price = price;
    //     imgSrc = imgSrc;
    //     count = count;
    //     detail = detail;
    // }
}