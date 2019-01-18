using Xunit;
using ATM;

namespace ATM_tests
{
    public class UnitTest1
    {
        
        [Fact]
        public void TestViewBalanceMethod()
        {
            Assert.Equal(0, Program._ViewBalance(0));
            Assert.Equal(10, Program._ViewBalance(10));
        }
        [Fact]
        public void TestWithdrawMethod()
        {
            Assert.Equal(100, Program._Withdraw(100, 200));
            Assert.Equal(100, Program._Withdraw(200, 100));
        }
        [Fact]
        public void TestDepositMethod()
        {
            Assert.Equal(200, Program._Deposit(100, 100));
            Assert.NotEqual(200, Program._Deposit(100,0));
        }
    }
}
