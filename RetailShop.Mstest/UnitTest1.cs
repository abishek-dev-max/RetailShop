using RetailShopApi.Model.Implementation;

namespace RetailShop.Mstest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetByName()
        {
            var expected = "apple";
            SampleProduct product = new SampleProduct();
            ProductViewModel content=product.GetProductByName(expected);
            Assert.IsNotNull(content);
            Assert.AreEqual(expected, content.Name);
        }
    }
}