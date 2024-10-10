using BonusApp;

namespace BonusAppUnitTest
{

    [TestClass]
    public class UnitTest1
    {
        Order order;

        [TestInitialize]
        public void InitializeTest()
        {
            order = new Order();
            order.AddProduct(new Product
            {
                Name = "M�lk",

                Value = 10.0,

                AvailableFrom = new DateTime(2024, 3, 1),

                AvailableTo = new DateTime(2024, 3, 5)

            });

            order.AddProduct(new Product
            {
                Name = "Sm�r",

                Value = 15.0,

                AvailableFrom = new DateTime(2024, 3, 3),

                AvailableTo = new DateTime(2024, 3, 4)

            });

            order.AddProduct(new Product
            {
                Name = "P�l�g",

                Value = 20.0,

                AvailableFrom = new DateTime(2024, 3, 4),

                AvailableTo = new DateTime(2024, 3, 7)

            });


        }
        [TestMethod]
        public void TenPercent_Test()
        {
            Assert.AreEqual(4.5, Bonuses.TenPercent(45.0));
            Assert.AreEqual(40.0, Bonuses.TenPercent(400.0));
        }
        [TestMethod]
        public void FlatTwoIfAMountMoreThanFive_Test()
        {
            Assert.AreEqual(2.0, Bonuses.FlatTwoIfAmountMoreThanFive(10.0));
            Assert.AreEqual(0.0, Bonuses.FlatTwoIfAmountMoreThanFive(4.0));
        }
        [TestMethod]
        public void GetValueOfProducts_Test()
        {
            Assert.AreEqual(45.0, order.GetValueOfProducts());
        }
        [TestMethod]
        public void GetBonus_Test()
        {
            order.Bonus = Bonuses.TenPercent;
            Assert.AreEqual(4.5, order.GetBonus());

            order.Bonus = Bonuses.FlatTwoIfAmountMoreThanFive;
            Assert.AreEqual(2.0, order.GetBonus());
        }
        [TestMethod]
        public void GetTotalPrice_Test()
        {
            order.Bonus = Bonuses.TenPercent;
            Assert.AreEqual(40.5, order.GetTotalPrice());

            order.Bonus = Bonuses.FlatTwoIfAmountMoreThanFive;
            Assert.AreEqual(43.0, order.GetTotalPrice());
        }

    [TestMethod]

    public void GetValueOfProductsByDate_Test()

    {

        Assert.AreEqual(0.0, order.GetValueOfProducts(new DateTime(2024, 2, 28)));

        Assert.AreEqual(10.0, order.GetValueOfProducts(new DateTime(2024, 3, 2)));

        Assert.AreEqual(25.0, order.GetValueOfProducts(new DateTime(2024, 3, 3)));

        Assert.AreEqual(45.0, order.GetValueOfProducts(new DateTime(2024, 3, 4)));

    }

        [TestMethod]

        public void SortByAvailableToTest()

        {

            List<Product> result = order.SortProductOrderByAvailableTo();



            Assert.AreEqual(3, result.Count);

            Assert.AreEqual("Sm�r", result[0].Name);

            Assert.AreEqual("M�lk", result[1].Name);

            Assert.AreEqual("P�l�g", result[2].Name);

        }
        [TestMethod]

        public void GetTotalPriceByDate_Test()

        {

            Assert.AreEqual(0.0, order.GetTotalPrice(new DateTime(2024, 2, 28), x => x * 0.2));

            Assert.AreEqual(8.0, order.GetTotalPrice(new DateTime(2024, 3, 2),  x => x * 0.2));

            Assert.AreEqual(20.0, order.GetTotalPrice(new DateTime(2024, 3, 3), x => x * 0.2));

            Assert.AreEqual(36.0, order.GetTotalPrice(new DateTime(2024, 3, 4), x => x * 0.2));

        }

        [TestMethod]

        public void SortByAvailableToTestKeySelector()

        {

          

            List<Product> result1 = order.SortProductOrderBy(x => x.Name);

            List<Product> result2 = order.SortProductOrderBy(x => x.Value);

            List<Product> result3 = order.SortProductOrderBy(x => x.AvailableFrom);

            List<Product> result4 = order.SortProductOrderBy(x => x.AvailableTo);


            Assert.AreEqual(3, result1.Count);

            Assert.AreEqual("M�lk", result1[0].Name);

            Assert.AreEqual("Sm�r", result2[1].Name);

            Assert.AreEqual("M�lk", result3[0].Name);

            Assert.AreEqual("M�lk", result4[1].Name);
        }
    }
}