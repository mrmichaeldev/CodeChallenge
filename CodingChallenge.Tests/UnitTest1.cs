//using System;
//using System.Collections.Generic;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace CodingChallenge.Tests
//{
//    [TestClass]
//    public class UnitTest1
//    {
//        [TestMethod]
//        public void BaseTest()
//        {
//            var visa = new MockSimpleInterestCreditCard(VisaCardType.Instance);
//            var mc = new MockSimpleInterestCreditCard(MCCardType.Instance);
//            var discover = new MockSimpleInterestCreditCard(DiscoverCardType.Instance);

//            Assert.AreEqual(visa.CalculateInterest(), visa.CardType.InterestRate * 100);
//            Assert.AreEqual(mc.CalculateInterest(), mc.CardType.InterestRate * 100);
//            Assert.AreEqual(discover.CalculateInterest(), discover.CardType.InterestRate * 100);
//        }

//        [TestMethod]
//        public void TestCase1()
//        {
//            var visa = new MockSimpleInterestCreditCard(VisaCardType.Instance);
//            var mc = new MockSimpleInterestCreditCard(MCCardType.Instance);
//            var discover = new MockSimpleInterestCreditCard(DiscoverCardType.Instance);

//            var wallet = new Wallet
//            {
//                CreditCards = new List<CreditCard>
//                {
//                    visa,
//                    mc,
//                    discover
//                }
//            };
            
//            Assert.AreEqual(wallet.CalculateInterest(),
//                visa.CalculateInterest() + mc.CalculateInterest() + discover.CalculateInterest());

//            var person = new Person
//            {
//                Wallets = new List<IWallet>
//                {
//                    wallet
//                }
//            };

//            Assert.AreEqual(person.CalculateInterest(), wallet.CalculateInterest());
//        }
//    }
//}
