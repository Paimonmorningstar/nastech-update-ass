using efass2.DTOs.Product;

namespace efass2.Services.Interfaces;

public interface IProductService
{
    IEnumerable<GetProductResponse> GetAll();
    GetProductResponse? GetById(int id);
    AddProductResponse? Create(AddProductRequest requestModel);
    UpdateProductResponse? Update(UpdateProductRequest requestModel);
    bool Delete(int id);
}
