using System.Collections.Generic;
using cats.DataBase;
using cats.Models;
using Microsoft.AspNetCore.Mvc;




namespace cats.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CatController : ControllerBase
  {
    //dont do this
    List<Cat> Inventory = Data.Inventory;

    //get all api/beanie
    [HttpGet]
    public ActionResult<List<Cat>> Get()
    {
      return Inventory;
    }

    //get by Id
    [HttpGet("{id}")]
    public ActionResult<Cat> GetById(int id)
    {
      Cat found = Inventory.Find(b => b.Id == id);
      if (found != null)
      {
        return found;
      }
      return BadRequest("{\"error\": \"not found\"}");
    }
    [HttpPost]
    public ActionResult<List<Cat>> Post([FromBody] Cat value)
    {
      Inventory.Add(value);
      return Inventory;
    }

    // api/cat/:id
    [HttpPut("{id}")]
    public ActionResult<Cat> Put(int id, [FromBody] Cat newData)
    {
      //add newData inplace of old
      Cat oldData = Inventory.Find(b => b.Id == id);
      if (oldData == null) { return BadRequest(); }
      Inventory.Remove(oldData);
      Inventory.Add(newData);
      return newData;
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
      Cat oldData = Inventory.Find(b => b.Id == id);
      if (oldData == null) { return BadRequest(); }
      Inventory.Remove(oldData);
      return Ok();
    }

  }

}