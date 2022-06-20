using System.ComponentModel.DataAnnotations.Schema;

using System.ComponentModel.DataAnnotations;
namespace WebApplication2.Models;

public class WorkerInfo
{
    //one to one with worker 
    [Key]
    [ForeignKey("Worker")]
    public int Id { get; set; }
    public int Age { get; set; }
    public string Sex { get; set; }
    public string Department { get; set; }
    public Worker Worker { get; set; }
}