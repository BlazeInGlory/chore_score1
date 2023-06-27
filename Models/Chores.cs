using System.ComponentModel.DataAnnotations;

namespace chore_score.Models;

public class Chores
{
  public Chores(string name, int id, int age, string body, string title)
  {
    Name = name;
    Id = id;
    Age = age;
    Body = body;
    Title = Title;
  }

  public string Name { get; set; }
  [Required]
  public int Id { get; set; }
  public int Age { get; set; }
  public string Body { get; set; }
  public string Title { get; set; }
}