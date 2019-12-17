using StoredBuild.Domain.Dto;
using StoredBuild.Domain.Exceptions;
using StoredBuild.Domain.Interfaces;
using StoredBuild.Domain.Models;

namespace StoredBuild.Domain.Service
{
  public class ProductStorerService
  {

    private readonly IRepository<Product> _productRepository;
    private readonly IRepository<Category> _categoryRepository;

    public ProductStorerService(IRepository<Product> productRepository, IRepository<Category> categoryRepository)
    {
      _productRepository = productRepository;
      _categoryRepository = categoryRepository;
    }

    public void Store(ProductDto dto)
    {
      var category = _categoryRepository.GetById(dto.CategoryId);
      DomainException.when(category == null, "Category invlaid");

      var product = _productRepository.GetById(dto.Id);
      if (product == null)
      {
        product = new Product(dto.Name, category, dto.Price, dto.StockQuantity);
        _productRepository.Save(product);
      }
      else
      {
        product.Update(dto.Name, category, dto.Price, dto.StockQuantity);
      }

      //      

    }
  }
}