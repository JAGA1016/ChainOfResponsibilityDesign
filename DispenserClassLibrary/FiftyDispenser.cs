using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static DispensersLibrary.BankNoteDispenser;

namespace DispenserClassLibrary
{

    public class FiftyDispenser : BankNoteDispenser
    {
        /// <summary>
        /// "This Function takes integer(amount ) as input and dispenses the maximum possible 50 notes and passes the remaining money to nexthandler"
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>string as output containing  denominations less than are equal to 50  </returns>
        public override string? Dispense(int amount)
        {
            string? temp = null;
            
            if (amount >= 50)
            {
                int numNotes = amount / 50;
                temp = numNotes.ToString() + ":Rs 50 ";
                int remainingAmount = amount % 50;

                if (remainingAmount > 0 && successor != null)
                {
                    temp += successor.Dispense(remainingAmount);
                }
            }
            else if (successor != null)
            {
                temp += successor.Dispense(amount);
            }
            return temp;

        }
    }

}
