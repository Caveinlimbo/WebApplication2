using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models;

public class Order
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public DateTime CreatedDataTime { get; set; } = DateTime.UtcNow;
    
    public ICollection<Product> Product { get; set; }
    public Order()
    {
        Product = new List<Product>();

    }
}

