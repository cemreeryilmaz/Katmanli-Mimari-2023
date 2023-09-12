using FinalProject.Core.Utilities.Results.Abstract;
using FinalProject.Entities.Concrete;
using FinalProject.Entities.Dtos;


namespace FinalProject.Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int categoryId);
        IDataResult<List<Product>> GetByUnitPrice(decimal min,decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product);
        IResult Update(Product product);
        IResult AddTransactionalTest(Product product);
    }
}