using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using  DispensersLibrary;

namespace DispenserClassLibrary
{

    public class OneHundredDispenser : BankNoteDispenser
    {
        /// <summary>
        /// "This Function takes integer(amount ) as input and dispenses the maximum possible 100 notes and passes the remaining money to nexthandler"
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>string as output containing  denominations less than are equal to 100  </returns>
        public override string? Dispense(int amount)
        {
            string? temp = null;
         
            if (amount >= 100)
            {
                int numNotes = amount / 100;
                temp = numNotes.ToString() + ":Rs 100 ";
                int remainingAmount = amount % 100;

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
