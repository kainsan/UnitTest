using Bank;
using NUnit.Framework;
using System;

namespace BankNUnitTests
{
    public class BankAccountTests
    {
        private BankAccount account;

        [SetUp]
        public void Setup()
        {
            // ARRANGE
            account = new BankAccount(1000);
        }

        [Test]
        public void Adding_Money_Update_Balance()
        {
            // ACT
            account.Add(500);

            // ASSERT
            Assert.AreEqual(1500, account.Balance);
        }

        [Test]
        public void Withdraw_Money_Update_Balance()
        {
            // ACT
            account.Withdraw(500);

            // ASSERT
            Assert.AreEqual(500, account.Balance);
        }

        [Test]
        public void Transfering_Funds_Updates_Both_Accounts()
        {
            // ARRANGE
            var otherAccount = new BankAccount();

            // ACT
            account.TransferFundsTo(otherAccount, 500);

            // ASSERT
            Assert.AreEqual(500, account.Balance);
            Assert.AreEqual(500, otherAccount.Balance);
        }

        
    }
}