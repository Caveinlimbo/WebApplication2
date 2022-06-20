
namespace WebApplication2.Models;

public class Worker
{
    //one to one with workerinfo 
    // dop table 
    public int Id { get; set; }
    public string WorkerName { get; set; }
    public WorkerInfo WorkerInfo { get; set; }
    
    public ICollection<Order> Orders { get; set; }
    public Worker()
    {
        Orders = new List<Order>();
    }
}