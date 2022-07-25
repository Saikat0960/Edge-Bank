using System;
using Business_Layer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestWithdraw_AmountmorethanBalance_ReturnFalse()
        {
            bool expected = false;

            Mock<DBConnection> db = new Mock<DBConnection>();
            db.Setup(x => x.GetAccountBalance(9999)).Returns(5000);
            db.Setup(x => x.BankBalance()).Returns(15000);

            Bank bank = new Bank(db.Object);
            bool actual = bank.Withdraw(999, 9999, 6000);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestWithdraw_AmountlessthanBalance_ReturnTrue()
        {
            bool expected = true;

            Mock<DBConnection> db = new Mock<DBConnection>();
            db.Setup(x => x.GetAccountBalance(9999)).Returns(9000);
            db.Setup(x => x.BankBalance()).Returns(15000);
            db.Setup(x => x.UpdateAccount(999, 9999, 3000)).Verifiable();
            db.Setup(x => x.UpdateBankBalance(9000)).Verifiable();
            db.Setup(x => x.GetAccountType(9999)).Returns("Chequing");
            db.Setup(x => x.InsertAccountActivity(999, 9999, "Chequing", "Withdraw", 6000)).Verifiable();

            Bank bank = new Bank(db.Object);
            bool actual = bank.Withdraw(999, 9999, 6000);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestDeposit_TaxfreeAmountmorethanfivethousand_ReturnFalse()
        {
            bool expected = false;

            Mock<DBConnection> db = new Mock<DBConnection>();
            db.Setup(x => x.GetAccountBalance(9999)).Returns(3000);
            db.Setup(x => x.BankBalance()).Returns(15000);
            db.Setup(x => x.GetAccountType(9999)).Returns("Taxfree");

            Bank bank = new Bank(db.Object);
            bool actual = bank.Deposit(999, 9999, 4000);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestDeposit_TaxfreeAmountlessthanfivethousand_ReturnTrue()
        {
            bool expected = true;

            Mock<DBConnection> db = new Mock<DBConnection>();
            db.Setup(x => x.GetAccountBalance(9999)).Returns(3000);
            db.Setup(x => x.BankBalance()).Returns(15000);
            db.Setup(x => x.GetAccountType(9999)).Returns("Taxfree");
            db.Setup(x => x.UpdateAccount(999, 9999, 4500)).Verifiable();
            db.Setup(x => x.UpdateBankBalance(16500)).Verifiable();
            db.Setup(x => x.InsertAccountActivity(999, 9999, "Taxfree", "Deposit", 1500)).Verifiable();

            Bank bank = new Bank(db.Object);
            bool actual = bank.Deposit(999, 9999, 1500);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestDeposit_ChequingAccount_ReturnTrue()
        {
            bool expected = true;

            Mock<DBConnection> db = new Mock<DBConnection>();
            db.Setup(x => x.GetAccountBalance(9999)).Returns(7000);
            db.Setup(x => x.BankBalance()).Returns(15000);
            db.Setup(x => x.GetAccountType(9999)).Returns("Chequing");
            db.Setup(x => x.UpdateAccount(999, 9999, 11000)).Verifiable();
            db.Setup(x => x.UpdateBankBalance(19000)).Verifiable();
            db.Setup(x => x.InsertAccountActivity(999, 9999, "Chequing", "Deposit", 4000)).Verifiable();

            Bank bank = new Bank(db.Object);
            bool actual = bank.Deposit(999, 9999, 4000);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestRepayLoan_Loanlessthanamount_ReturnFalse()
        {
            bool expected = false;

            Mock<DBConnection> db = new Mock<DBConnection>();
            db.Setup(x => x.GetAccountBalance(9999)).Returns(12000);
            db.Setup(x => x.BankBalance()).Returns(15000);

            Bank bank = new Bank(db.Object);
            bool actual = bank.RepayLoan(999, 9999, 13000);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestRepayLoan_loanmorethanamount_ReturnTrue()
        {
            bool expected = true;

            Mock<DBConnection> db = new Mock<DBConnection>();
            db.Setup(x => x.GetAccountBalance(9999)).Returns(12000);
            db.Setup(x => x.BankBalance()).Returns(15000);
            db.Setup(x => x.UpdateAccount(999, 9999, 4000)).Verifiable();
            db.Setup(x => x.UpdateBankBalance(23000)).Verifiable();

            Bank bank = new Bank(db.Object);
            bool actual = bank.RepayLoan(999, 9999, 8000);
            Assert.AreEqual(expected, actual);
        }
    }
}
