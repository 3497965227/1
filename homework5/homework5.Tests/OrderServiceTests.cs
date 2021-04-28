namespace homework5.Tests
{
    using homework5;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class OrderServiceTests
    {
        private OrderService _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new OrderService();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new OrderService();
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CanCallAddOrder()
        {
            var order = new Order(1728423141, new Customer(1608690974, "TestValue261108185"));
            _testClass.AddOrder(order);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CannotCallAddOrderWithNullOrder()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.AddOrder(default(Order)));
        }

        [Test]
        public void CanCallRemoveOrder()
        {
            var orderId = 332359102;
            _testClass.RemoveOrder(orderId);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanCallGetById()
        {
            var orderId = 335625524;
            var result = _testClass.GetById(orderId);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void GetByIdPerformsMapping()
        {
            var orderId = 1062587583;
            var result = _testClass.GetById(orderId);
            Assert.That(result.OrderId, Is.EqualTo(orderId));
        }

        [Test]
        public void CanCallQueryAll()
        {
            var result = _testClass.QueryAll();
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanCallQuery()
        {
            var condition = default(Predicate<Order>);
            var result = _testClass.Query(condition);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CannotCallQueryWithNullCondition()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.Query(default(Predicate<Order>)));
        }

        [Test]
        public void CanCallChangeOrder()
        {
            var order = new Order(1876592528, new Customer(453671089, "TestValue2022138050"));
            _testClass.ChangeOrder(order);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CannotCallChangeOrderWithNullOrder()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.ChangeOrder(default(Order)));
        }

        [Test]
        public void CanCallSort()
        {
            var result = _testClass.Sort();
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanCallQueryByOrderId()
        {
            var orderId = 1060442891;
            var result = _testClass.QueryByOrderId(orderId);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanCallQueryByGoodsName()
        {
            var goodsName = "TestValue2052924403";
            var result = _testClass.QueryByGoodsName(goodsName);
            Assert.Fail("Create or modify test");
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public void CannotCallQueryByGoodsNameWithInvalidGoodsName(string value)
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.QueryByGoodsName(value));
        }

        [Test]
        public void CanCallQueryByCustomerName()
        {
            var customerName = "TestValue292360314";
            var result = _testClass.QueryByCustomerName(customerName);
            Assert.Fail("Create or modify test");
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public void CannotCallQueryByCustomerNameWithInvalidCustomerName(string value)
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.QueryByCustomerName(value));
        }

        [Test]
        public void CanCallQueryByTotalPrice()
        {
            var price = 1553549905;
            var result = _testClass.QueryByTotalPrice(price);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanCallExport()
        {
            var fileName = "TestValue1667713215";
            _testClass.Export(fileName);
            Assert.Fail("Create or modify test");
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public void CannotCallExportWithInvalidFileName(string value)
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.Export(value));
        }

        [Test]
        public void CanCallImport()
        {
            var path = "TestValue895323054";
            _testClass.Import(path);
            Assert.Fail("Create or modify test");
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public void CannotCallImportWithInvalidPath(string value)
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.Import(value));
        }
    }
}