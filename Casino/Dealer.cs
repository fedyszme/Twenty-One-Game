using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());

            string card = string.Format(Deck.Cards.First().ToString() + "\n");//this and to file.write was added to show file i/o video
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\Admin\Desktop\b\Logs\log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);//this is going to write the string card to the log and bc is set as true, it will append instead of overwriting.
            }

                //Console.WriteLine(Deck.Cards.First().ToString() + "\n");
                Deck.Cards.RemoveAt(0); //RemoveAt is a prebuilt method that can be used with lists
        }
    }
}
