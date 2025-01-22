using Microsoft.AspNetCore.Mvc;
using Moq;
using WebApiPostgre.Controllers;
using WebApiPostgre.Data;
using WebApiPostgre.Models;

namespace TestProject
{
    [TestClass]
    public class TestProductController
    {
            [TestMethod]
            public async Task GetAllProducts_ShouldReturnAllProducts()
            {
                var mock = new Mock<IProductRepository>();
                mock.Setup(a => a.GetProducts().Result).Returns(GetTestProducts());
                var controller = new ProductsController(mock.Object);

                var result = await controller.GetProducts();
                Assert.AreEqual(GetTestProducts().Count, result.Value.Count());
            }
        /*
        [TestMethod]
        public void GetProduct_ShouldReturnCorrectProduct()
        {
            var mock = new Mock<IProductRepository>();
            mock.Setup(a => a.GetProductByID().Result).Returns(GetTestProducts());
            var controller = new ProductsController(mock.Object);

            var result = controller.GetProduct(4) as OkNegotiatedContentResult<Product>;
            Assert.IsNotNull(result);
            Assert.AreEqual(testProducts[3].Name, result.Content.Name);
        }
         
            [TestMethod]
            public async Task GetProductAsync_ShouldReturnCorrectProduct()
            {
                var testProducts = GetTestProducts();
                var controller = new SimpleProductController(testProducts);

                var result = await controller.GetProductAsync(4) as OkNegotiatedContentResult<Product>;
                Assert.IsNotNull(result);
                Assert.AreEqual(testProducts[3].Name, result.Content.Name);
            }

            [TestMethod]
            public void GetProduct_ShouldNotFindProduct()
            {
                var controller = new SimpleProductController(GetTestProducts());

                var result = controller.GetProduct(999);
                Assert.IsInstanceOfType(result, typeof(NotFoundResult));
            }
        */
        private List<Product> GetTestProducts()
            {
                var testProducts = new List<Product>();
                testProducts.Add(new Product { Id = 1, Name = "Demo1", Price = 1 });
                testProducts.Add(new Product { Id = 2, Name = "Demo2", Price = 3.75M });
                testProducts.Add(new Product { Id = 3, Name = "Demo3", Price = 16.99M });
                testProducts.Add(new Product { Id = 4, Name = "Demo4", Price = 11.00M });

                return testProducts;
            }    

    }
}
