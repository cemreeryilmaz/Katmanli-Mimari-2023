// See https://aka.ms/new-console-template for more information


using FinalProject.Business.Concrete;
using FinalProject.DataAccess.Concrete.EntityFramework;

ProductTest();
//CategoryTest();

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll().Data)
    {
        Console.WriteLine(category.CategoryName);
    }
}
static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));

    var result = productManager.GetProductDetails();
    if (result.Success)
    {
        foreach (var item in productManager.GetProductDetails().Data)
        {
            Console.WriteLine(item.ProductName + " / " + item.CategoryName);

        }
    }
    Console.WriteLine(result.Message);


}

