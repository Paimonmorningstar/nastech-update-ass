using System;
using efass2.Models;

namespace efass2.Repositories;
public class ProductRepository : BaseRepository<Product>, Interface.IProductRepository
{
    public ProductRepository(ProductStoreContext context) : base(context)
    {
    }
}