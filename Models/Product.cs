using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.DataAnnotations;
namespace WebApplication2.Models;

public class Product
{
    // sdelat'  mnogo productov v ordere 
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public decimal Price { get; set; }
    
    public int OrderId { get; set; }
    
    public ICollection<Order> Orders { get; set; }
    public Product()
    {
        Orders = new List<Order>();
    }
}