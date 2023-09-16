using DispenserClassLibrary;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDispenserHandlers()
        {
            // Simulate ATM withdrawals
            int[] withdrawalAmounts = { 1680, -10, 10, 104 };
            string? result = null;
            ATM aTM = new();
            foreach (int amount in withdrawalAmounts)
            {

                result += aTM.Withdraw(amount);

            }
            // Now, you can make assertions on the captured output
            Assert.AreEqual("1:Rs 1000 1:Rs 500 1:Rs 100 1:Rs 50 1:Rs 20 1:Rs 10 Enter Valid Amount 1:Rs 10 Enter Valid Amount ", result);
        }

    }
}