using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessRulesEngine;
using BusinessRulesEngine.Constant;
using BusinessRulesEngine.Factory;
using BusinessRulesEngine.Payments;

namespace UnitTestBusinessRulesEngine
{
    [TestClass]
    public class UnitTestPaymentProcess
    {

        [TestMethod]
        public void PaymentFactory_Should_Generate_PackagingSlip_ForPhysicalProduct()
        {
            //Arrange
            int physicalProduct = PaymentType.PhysicalProduct.GetHashCode();
            IPayment paymentObject = PaymentFactory.GetPaymentObject(physicalProduct);
            //Act
            bool result = paymentObject.ProcessPayment();
            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void PaymentFactory_Create_DuplicatePackagingSlip_RoyaltyDep_ForBook()
        {
            //Arrange
            int book = PaymentType.Book.GetHashCode();
            IPayment paymentObject = PaymentFactory.GetPaymentObject(book);
            //Act
            bool result = paymentObject.ProcessPayment();
            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void PaymentFactory_Should_ActiavteMembership()
        {
            //Arrange
            int activate = PaymentType.MembershipActivate.GetHashCode();
            IPayment paymentObject = PaymentFactory.GetPaymentObject(activate);
            //Act
            bool result = paymentObject.ProcessPayment();
            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void PaymentFactory_Should_UpgradeMembership()
        {
            //Arrange
            int upgrade = PaymentType.MembershipUpgrade.GetHashCode();
            IPayment paymentObject = PaymentFactory.GetPaymentObject(upgrade);
            //Act
            bool result = paymentObject.ProcessPayment();
            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void PaymentFactory_Should_Generate_FreeVideoSlip()
        {
            //Arrange
            int video = PaymentType.Video.GetHashCode();
            IPayment paymentObject = PaymentFactory.GetPaymentObject(video);
            //Act
            bool result = paymentObject.ProcessPayment();
            //Assert
            Assert.AreEqual(result, true);
        }


    }
}
