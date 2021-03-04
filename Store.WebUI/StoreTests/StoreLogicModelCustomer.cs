using System;
using Xunit;

namespace StoreTests
{
    public class StoreLogicModelCustomer
    {
        [Fact]
        public void ValidateNameNumericName()
        {
            // Arrange
            string fname = "Cr00s";
            string lname = "F13lds";
            Store.Logic.Models.Customer tester = new Store.Logic.Models.Customer();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => tester.ValidateName(fname, lname));

        }
    }
}
