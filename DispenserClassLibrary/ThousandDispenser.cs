using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispenserClassLibrary
{

    public class ThousandDispenser : BankNoteDispenser
    {
        /// <summary>
        /// "This Function takes integer(amount ) as input and dispenses the maximum possible 1000 notes and passes the remaining money to nexthandler"
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>string as output containing  denominations less than are equal to 1000  </returns>
        public override string? Dispense(int amount)
        {
            string? temp = null;
            if (amount <= 0 || amount % 10 != 0)
            {
                return "Enter Valid Amount ";
            }
            else if (amount >= 1000)
            {
                int numNotes = amount / 1000;
                temp = numNotes.ToString() + ":Rs 1000 ";
                int remainingAmount = amount % 1000;

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
