using efass2.DTOs.Category;

namespace efass2.Services.Interfaces;

public interface ICategoryService
{
    IEnumerable<GetCategoryResponse> GetAll();
    GetCategoryResponse GetById(int id);
    AddCategoryResponse Create(AddCategoryRequest requestModel);
    UpdateCategoryResponse Update(UpdateCategoryRequest requestModel);
    bool Delete(int id);
}
