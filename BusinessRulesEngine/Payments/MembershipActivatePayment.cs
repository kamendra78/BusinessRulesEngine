using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.Payments
{
    public class MembershipActivatePayment : IPayment
    {
        public bool ActivateMembership()
        {
             Console.WriteLine("Membership activated successfully");
             return this.EmailNotificationToOwner();
        }

        private bool EmailNotificationToOwner()
        {
             Console.WriteLine( "e-mail sent to the owner for Membership Activated");
             return true;
        }


        public bool ProcessPayment()
        {
            return ActivateMembership();
            
        }
    }
}
