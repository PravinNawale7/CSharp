using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_MANAGEMENT_SYSTEM
{
    internal class InsufficientBalanceException : ApplicationException
    {
        public override string Message =>
           "Insufficient balance in account.";
    }
}
