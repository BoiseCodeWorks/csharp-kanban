using System.ComponentModel.DataAnnotations;

namespace csharp_kanban.Models
{
  public class Board
  {
    public int Id {get; set;}
   
    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
    public int Num { get; set; }
  }
}