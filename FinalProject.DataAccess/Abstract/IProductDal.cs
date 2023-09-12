using FinalProject.Core.DataAccess.EntityFramework.Abstract;
using FinalProject.Entities.Concrete;
using FinalProject.Entities.Dtos;

namespace FinalProject.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}
