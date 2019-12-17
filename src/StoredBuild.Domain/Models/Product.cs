using StoredBuild.Domain.Exceptions;

namespace StoredBuild.Domain.Models
{
  public class Product
  {
    public int Id { get; private set; }
    public string Name { get; private set; }
    public Category Category { get; private set; }
    public decimal Price { get; private set; }
    public int StockQuantity { get; private set; }


    public Product(string name, Category category, decimal price, int stockQuantity)
    {
      ValidateValues(name, category, price, stockQuantity);
      SetProperties(name, category, price, stockQuantity);
    }

    public void Update(string name, Category category, decimal price, int stockQuantity)
    {
      ValidateValues(name, category, price, stockQuantity);
      SetProperties(name, category, price, stockQuantity);
    }

    private void SetProperties(string name, Category category, decimal price, int stockQuantity)
    {
      Name = name;
      Category = category;
      Price = price;
      StockQuantity = stockQuantity;
    }

    private void ValidateValues(string name, Category category, decimal price, int stockQuantity)
    {
      DomainException.when(string.IsNullOrEmpty(name), "Name is required");
      DomainException.when((category == null), "Category is required");
      DomainException.when((price < 0), "Price is required");
      DomainException.when((StockQuantity < 0), "StockQuantity is required");
    }
  }
}