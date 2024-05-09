using System.Reflection.Emit;
using Toy2;

namespace UnitTest1
{
    [TestClass]

    public class UnitTest1

    {

        Connector c1, c2, c3;
        Order order;
        Controller controller = new Controller();
        DataHandler handler = new DataHandler("text.csv");

        [TestInitialize]

        public void Init()

        {

            c1 = new Connector(12, "Anchor", 35.0, 700);
            c2 = new Connector(123, "Anchor", 55.0, 700);
            c3 = new Connector(124, "Basis", 45.0, 800);

            Random rnd = new Random();
            int orderID = rnd.Next(100000, 999999);
            DateTime date = DateTime.Now;
            order = new Order(orderID, date);

            order.UpdateCost();

        }

        [TestMethod]

        public void AddConnectorsToOrder()

        {
            //Controller controller = new Controller();

            controller.AddNewProduct(c1);
            controller.AddNewProduct(c2);
            controller.AddNewProduct(c3);
            controller.AddToOrder(c1, order, 5);
            controller.AddToOrder(c2, order, 30);
            controller.AddToOrder(c3, order, 50);
            order.UpdateCost();

            Assert.AreEqual(135, order.Cost);

        }

        [TestMethod]

        public void RemoveProductFromStock()

        {
            //Controller controller = new Controller();

            controller.AddNewProduct(c1);
            controller.AddNewProduct(c2);
            controller.AddNewProduct(c3);
            controller.AddToOrder(c1, order, 5);
            controller.AddToOrder(c2, order, 30);
            controller.AddToOrder(c3, order, 50);
            order.UpdateCost();

            Assert.AreEqual(695, c1.Amount);
            Assert.AreEqual(670, c2.Amount);
            Assert.AreEqual(750, c3.Amount);

        }


    }
    }