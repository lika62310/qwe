using System.Reflection.Emit;
using Toy2;

namespace UnitTest1
{
    [TestClass]

    public class UnitTest1

    {

        Connector c1, c2, c3;


        [TestInitialize]

        public void Init()

        {

            c1 = new Connector(12, "Anchor", 35.0);

        }

        [TestMethod]

        public void BookConstructorWithOneParameter()

        {

            Assert.AreEqual("ItemId: 1, Title: , Price: 0", b1.ToString());

        }

        }
    }