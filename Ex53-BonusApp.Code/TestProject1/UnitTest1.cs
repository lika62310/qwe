using BonusApp;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetBonusAnonymous_Test()
        {

            //return amount / 10.0;
            Order order = new Order();
            Product apple = new Product();
            apple.Value = 45;

            order.AddProduct(apple);


            //order.Bonus = Bonuses.TenPercent;
            order.Bonus = delegate (double a) { return a / 10.0; };
            Assert.AreEqual(4.5, order.GetBonus());

            order.Bonus = Bonuses.FlatTwoIfAmountMoreThanFive;
            Assert.AreEqual(2.0, order.GetBonus());
        }
        [TestMethod]

        public void GetBonusLambda_Test()

        {
            //return amount / 10.0;
            Order order = new Order();
            Product apple = new Product();
            apple.Value = 45;

            order.AddProduct(apple);

            order.Bonus = a => a / 10.0; // Lav til lambda udtryk

            Assert.AreEqual(4.5, order.GetBonus());

            //return amount > 5.0 ? 2.0 : 0.0;
            order.Bonus = a =>
            {
                return a > 5.0 ? 2.0 : 0.0;
            }; // Lav til lambda udtryk

            Assert.AreEqual(2.0, order.GetBonus());

        }
    }
}