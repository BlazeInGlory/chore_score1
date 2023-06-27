namespace chore_score.Repositories;

public class ChoresRepository
{
  private List<Chores> dbChores = new List<Chores> { };
  public ChoresRepository()
  {
    this.dbChores = new List<Chores> { };
    dbChores.Add(new Chores("Laundry", 1, 1, "fold and fluff", "Do Laundry"));
    dbChores.Add(new Chores("Mowing", 2, 1, "mow the lawn", "Mow Lawn"));
    dbChores.Add(new Chores("Kitchen", 3, 1, "clean the kitchen", "Clean Kitchen"));
  }
  internal List<Chores> GetAllChores()
  {
    return dbChores;
  }
  internal Chores GetById(int choreId)
  {
    Chores chores = dbChores.Find(c => c.Id == choreId);
    return chores;
  }
  internal Chores CreateChore(Chores choreData)
  {
    int lastId = dbChores[dbChores.Count - 1].Id;
    choreData.Id = lastId + 1;
    dbChores.Add(choreData);
    return choreData;
  }

  internal void RemoveChore(int choreId)
  {
    Chores chores = dbChores.Find(c => c.Id == choreId);
    dbChores.Remove(chores);
  }

  internal void UpdateChore(Chores updateData)
  {
    Chores chores = GetById(updateData.Id);
    chores = updateData;
  }
}

// Name = name;
// Id = id;
// Age = age;
// Body = body;
// Title = Title;