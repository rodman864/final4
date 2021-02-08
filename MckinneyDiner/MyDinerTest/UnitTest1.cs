using Diner;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Diner.MckinneyDiner;

namespace MyDinerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShowCustomer_isWaiting_ReturnTrue()
        {
            //Arrange
            MckinneyDiner inQue = new MckinneyDiner();

            InWaiting newCustomer = new InWaiting();
            newCustomer.IsAdded = true;
            newCustomer.IsDishClean = false;
            newCustomer.CustomerName = "Tracy";


            inQue.CurrentlyWaiting = newCustomer;



            //Act
            InWaiting newPerson = new InWaiting();
            newPerson.IsAdded = true;
            newPerson.IsDishDirty = true;
            newPerson.CustomerName = "Amos";

            inQue.CurrentlyWaiting = newPerson;

            bool showCustomer = inQue.showCustomer(newPerson);


            //Assert
            Assert.IsTrue(showCustomer);

        }
    }
}
