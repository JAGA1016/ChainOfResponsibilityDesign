using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispenserClassLibrary
{

    public class TwentyDespenser : BankNoteDispenser
    {
        /// <summary>
        /// "This Function takes integer(amount ) as input and dispenses the maximum possible 20 notes and passes the remaining money to nexthandler"
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>string as output containing  denominations less than are equal to 20  </returns>
        public override string? Dispense(int amount)
        {
            string? temp = null;

            if (amount >= 20)
            {
                int numNotes = amount / 20;
                temp = numNotes.ToString() + ":Rs 20 ";
                int remainingAmount = amount % 20;

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
