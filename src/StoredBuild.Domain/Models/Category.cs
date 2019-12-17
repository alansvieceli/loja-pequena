using StoredBuild.Domain.Exceptions;

namespace StoredBuild.Domain.Models
{
  public class Category
  {

    public int Id { get; private set; }
    public string Name { get; private set; }


    public Category(string name)
    {
      ValidadeAndSetProperties(name);
    }

    public void Update(string name)
    {
      ValidadeAndSetProperties(name);
    }

    private void ValidadeAndSetProperties(string name)
    {
      DomainException.when(string.IsNullOrEmpty(name), "Name is required");
      Name = name;
    }


  }
}