using System;

namespace BuyingEnvelopes
{
    class Program
    {
        static void Main(string[] args)
        {
            //How many boxes of envelopes can you buy with \$12 if one box costs 3?

            int envelopesCost = 3;
            int inWallet = 12;
            int howManyBoxes = inWallet / envelopesCost;
            Console.WriteLine("You can buy " + howManyBoxes + " boxes of envelopes.");
        
        }
    }
}
