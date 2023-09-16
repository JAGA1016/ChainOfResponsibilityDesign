using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispenserClassLibrary
{
    public abstract class BankNoteDispenser
    {
        protected BankNoteDispenser? successor;

        public void SetSuccessor(BankNoteDispenser successor) => this.successor = successor;

        public abstract string? Dispense(int amount);
    }
}
