using System.Collections;
using System.Linq;
using csharp_kanban.Models;
using Microsoft.AspNetCore.Mvc;

namespace csharp_kanban.Controllers
{
  [Route("api/boards")]
  public class BoardController : Controller
  {
    private KanbanContext _db;
    public BoardController(KanbanContext kanbanContext)
      {
          _db = kanbanContext;
      }

    [HttpGet]
    public IEnumerable Get(){
      return _db.Boards.ToList();
    }

    [HttpPost]
    public string Post([FromBody] Board board){
      if(ModelState.IsValid){
        _db.Boards.Add(board);
        _db.SaveChanges();
        return "Successfully Added Board";
      }
      return ModelState.ValidationState.ToString();
    }

    [HttpDelete("{id}")]
    public string Delete(int id){
      var boardToRemove = _db.Boards.Where(b => b.Id == id).First();
      _db.Boards.Remove(boardToRemove);
      _db.SaveChanges();
      return "Successfully Removed Board";
    }
    [HttpPut("{id}")]
    public string Put(int id, [FromBody] Board board){
      var boardToModify = _db.Boards.Where(b => b.Id == id).First(); 
      boardToModify.Name = board.Name;
      boardToModify.Num = board.Num;
      boardToModify.Description = board.Description;
      _db.Boards.Update(boardToModify);
      _db.SaveChanges();
      return "Successfully Edited Board";
    }





  }
}