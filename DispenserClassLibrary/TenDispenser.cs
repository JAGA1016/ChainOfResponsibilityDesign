using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispenserClassLibrary
{

    public class TenDispenser : BankNoteDispenser
    {
        /// <summary>
        /// "This Function takes integer(amount ) as input and dispenses the maximum possible 10 notes and passes the remaining money to nexthandler"
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>string as output containing  denominations less than are equal to 10  </returns>
        public override string? Dispense(int amount)
        {
            string? temp = null;

            if (amount >= 10)
            {
                int numNotes = amount / 10;
                temp = numNotes.ToString() + ":Rs 10 ";
                int remainingAmount = amount % 10;

                if (remainingAmount > 0 && successor != null)
                {
                    temp += successor.Dispense(remainingAmount);
                }
            }
            return temp;
        }
    }

}
