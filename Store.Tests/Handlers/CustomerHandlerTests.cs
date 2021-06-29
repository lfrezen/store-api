
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.StoreContext.CustomerCommands.Inputs;
using Store.Domain.StoreContext.Handlers;
using Store.Tests.Fakes;

namespace Store.Tests.Handlers
{
    [TestClass]
    public class CustomeHandlerTests
    {

        [TestMethod]
        public void ShouldRegisterCustomerWhenCommandIsValid()
        {
            var command  = new CreateCustomerCommand();
            command.FirstName = "Joao";
            command.LastName = "Silva";
            command.Document = "25198233056";
            command.Email = "joao@email.com";
            command.Phone = "11999992222";
            
            Assert.AreEqual(true, command.IsValid());

            var handler = new CustomerHandler(new FakeCustomerRepository(), new FakeEmailService());
            var result = handler.Handle(command);

            Assert.AreNotEqual(null, result);
            Assert.AreEqual(true, handler.Valid);
        }
    }
}