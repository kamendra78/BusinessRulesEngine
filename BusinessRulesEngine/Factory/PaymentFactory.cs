using BusinessRulesEngine.Payments;

namespace BusinessRulesEngine.Factory
{
    /// <summary>
    /// Payment object Factory
    /// More object can be added later
    /// </summary>
    public  class PaymentFactory
    {
        // Factory Method
        public static IPayment GetPaymentObject(int objType)
        {
            IPayment _IPayment;
  
            if (objType == Constant.PaymentType.PhysicalProduct.GetHashCode())
            {
                _IPayment = new PhysicalProductPayment();
            }
            else if (objType == Constant.PaymentType.Book.GetHashCode())
            {
                _IPayment = new BookPayment();
            }
            else if (objType == Constant.PaymentType.MembershipActivate.GetHashCode())
            {
                _IPayment = new MembershipActivatePayment();
            }
            else if (objType == Constant.PaymentType.MembershipUpgrade.GetHashCode())
            {
                _IPayment = new MembershipUpgradePayment();
            }
            else if (objType == Constant.PaymentType.Video.GetHashCode())
            {
                _IPayment = new VideoPayment();
            }
            else
            {
                _IPayment = null;
            }
            return _IPayment;
        }

    }
}
