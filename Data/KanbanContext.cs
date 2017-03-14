using csharp_kanban.Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_kanban
{
  public class KanbanContext : DbContext
  {
    public DbSet<Board> Boards { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite("Filename=./Kanban.db");
    }


  }
}