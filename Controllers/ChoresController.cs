namespace chore_score.Controllers;

[ApiController]
[Route("api/chores")]
public class ChoresController : ControllerBase
{
  private readonly ChoresServices _choresService;
  public ChoresController(ChoresServices choresService)
  {
    this._choresService = choresService;
  }
  // [HttpGet]
  // public ActionResult<string> Test()
  // {
  //   try
  //   {
  //     return Ok("Hey");
  //   }
  //   catch (System.Exception error)
  //   {
  //     return BadRequest("I cant do that." + error.Message);
  //   }
  // }

  [HttpGet]
  public ActionResult<List<Chores>> GetAllChores()
  {
    try
    {
      List<Chores> chores = _choresService.GetAllChores();
      return Ok(chores);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPost]
  public ActionResult<Chores> CreateChore([FromBody] Chores choreData)
  {
    try
    {
      Chores chores = _choresService.CreateChore(choreData);
      return Ok(chores);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("{choresId}")]
  public ActionResult<string> RemoveChore(int choreId)
  {
    try
    {
      string message = _choresService.RemoveChore(choreId);
      return Ok(message);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPut("{choreId}")]
  public ActionResult<Chores> UpdateChore(int choreId, [FromBody] Chores updateData)
  {
    try
    {
      updateData.Id = choreId;
      Chores chores = _choresService.UpdateChore(updateData);
      return Ok(chores);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
}