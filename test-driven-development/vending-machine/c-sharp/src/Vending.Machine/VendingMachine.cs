using System;

namespace Vending.Machine
{
    public class VendingMachine
    {
        public string DisplayText { get; private set; }

        public void InsertCoin(string coin)
        {
            DisplayText = "$0.10";
        }
    }
}
