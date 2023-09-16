using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispenserClassLibrary
{
    public class ATM
    {
        // Create the chain of responsibility
        private readonly ThousandDispenser _thousandDispenser = new();
        private readonly FiveHundredDispenser _fiveHundredDispenser = new();
        private readonly OneHundredDispenser _oneHundredDispenser = new();
        private readonly FiftyDispenser _fiftyDispenser = new ();
        private readonly TwentyDespenser _twentyDispenser = new();
        private readonly TenDispenser _tenDispenser = new();
        public ATM()
        {
            // Prepare the chain of Handlers
            // Here, we need to set the next handler of each handler
            _thousandDispenser.SetSuccessor(_fiveHundredDispenser);
            _fiveHundredDispenser.SetSuccessor(_oneHundredDispenser);
            _oneHundredDispenser.SetSuccessor( _fiftyDispenser );
            _fiftyDispenser.SetSuccessor(_twentyDispenser);
            _twentyDispenser.SetSuccessor(_tenDispenser);
        }
        //The following method handle the request and passes it to the first handler in the chain of responsibility.
        public string? Withdraw(int requestedAmount)
        {
            //First check whether the amount is Divisible by 100 or not
            
            return _thousandDispenser.Dispense(requestedAmount);
            
            
        }
    }
}
