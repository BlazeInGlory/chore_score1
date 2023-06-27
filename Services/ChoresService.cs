namespace chore_score.Services;

public class ChoresServices
{
  private readonly ChoresRepository _repo;
  public ChoresServices(ChoresRepository repo)
  {
    _repo = repo;
  }
  public List<Chores> GetAllChores()
  {
    List<Chores> chores = _repo.GetAllChores();
    return chores;
  }
  internal Chores CreateChore(Chores choreData)
  {
    Chores chores = _repo.CreateChore(choreData);
    return chores;
  }

  internal string RemoveChore(int choreId)
  {
    Chores chores = _repo.GetById(choreId);
    if (chores == null) throw new Exception($"No chore at id {choreId}");
    _repo.RemoveChore(choreId);
    return $"chore was deleted";
  }

  internal Chores UpdateChore(Chores updateData)
  {
    Chores original = _repo.GetById(updateData.Id);
    if (original == null) throw new Exception($"No chores at id:{updateData.Id}");

    original.Name = updateData.Name != null ? updateData.Name : original.Name;
    original.Title = updateData.Title != null ? updateData.Title : original.Title;
    original.Body = updateData.Body != null ? updateData.Body : original.Body;

    _repo.UpdateChore(updateData);
    return updateData;
  }
}