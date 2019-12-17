using StoredBuild.Domain.Dto;
using StoredBuild.Domain.Exceptions;
using StoredBuild.Domain.Interfaces;
using StoredBuild.Domain.Models;

namespace StoredBuild.Domain.Service
{
  public class CategoryStorerService
  {
    private readonly IRepository<Category> _categoryRepository;

    public CategoryStorerService(IRepository<Category> categoryRepository)
    {
      _categoryRepository = categoryRepository;
    }

    public void Store(CategoryDto dto)
    {
      var category = _categoryRepository.GetById(dto.Id);
      if (category == null)
      {
        category = new Category(dto.Name);
        _categoryRepository.Save(category);
      }
      else
      {
        category.Update(dto.Name);
      }
    }

  }
}