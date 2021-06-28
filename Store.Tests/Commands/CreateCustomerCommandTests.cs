
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.StoreContext.CustomerCommands.Inputs;

namespace Store.Tests.ValueObjects
{
    [TestClass]
    public class CreateCustomerCommandTests
    {

        [TestMethod]
        public void ShouldValidateWhenCommandIsValid()
        {
            var command  = new CreateCustomerCommand();
            command.FirstName = "Joao";
            command.LastName = "Silva";
            command.Document = "25198233056";
            command.Email = "joao@email.com";
            command.Phone = "11999992222";
            
            Assert.AreEqual(true, command.IsValid());
        }
    }
}