using NorthwindEcommerceAPI;
using System.Text.Json.Serialization;

public class Supplier
{
    public int SupplierId { get; set; }
    public string CompanyName { get; set; }
    public string ContactName { get; set; }
    public string ContactTitle { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    
    [JsonIgnore]
    public ICollection<Product> Products { get; set; }
}
