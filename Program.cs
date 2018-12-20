using NBitcoin;
using System;

namespace VanityStrat
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                //TODO: replace prefix with anything you want
                Console.WriteLine(VanityGenerate("PREFIX"));
            }
        }

        private static string VanityGenerate(string prefix)
        {
            Key privateKey;
            while (true)
            {
                privateKey = new Key();
                string address = privateKey.PubKey.GetAddress(Network.StratisMain).ToString();

                if (address.ToUpper().StartsWith(prefix.ToUpper()))
                {
                    string privateKeyForDisplay = privateKey.GetWif(Network.StratisMain).ToWif();
                    return privateKeyForDisplay + " " + address;
                }
            }
        }
    }
}
