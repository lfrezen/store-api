
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.StoreContext.ValueObjects;

namespace Store.Tests.ValueObjects
{
    [TestClass]
    public class NameTests
    {
        private Name validName;
        private Name invalidName;
        public NameTests()
        {
            invalidName = new Name("","Silva");
            validName = new Name("Joao","Silva");
        }

        [TestMethod]
        public void ShouldReturnNotificationWhenNameIsNotValid()
        {
            Assert.AreEqual(false, invalidName.Valid);
            Assert.AreEqual(1, invalidName.Notifications.Count);
        }

        [TestMethod]
        public void ShouldReturnNotificationWhenNameIsValid()
        {
            Assert.AreEqual(true, validName.Valid);
            Assert.AreEqual(0, validName.Notifications.Count);
        }
    }
}