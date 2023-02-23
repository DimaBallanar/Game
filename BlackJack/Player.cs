using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
   public class Player
    {
        
        protected Hand hand;

        public Player()
        {
            hand = new Hand();
        }

        public virtual Hand Deal(Deck deck)
        {
            DealCards(2, deck);
            Console.WriteLine();

            bool playing = true;
            while (playing)
            {
                Console.Write("взять еще карту (Д) или хватит (Н)?: ");
                string response = Console.ReadLine();
                switch (response.ToUpper())
                {
                    case "Д":
                        DealCards(1, deck);
                        playing = !hand.IsBusted();
                        break;
                    case "Н":
                        playing = false;
                        break;
                    default:
                        Console.WriteLine("неверный ввод");
                        break;
                }
            }

            return hand;
        }

        public void DealCards(int num, Deck deck)
        {
            string cardString = (num == 1) ? "card" : "cards";
            Console.WriteLine("Dealing new " + cardString);
            for (int i = 0; i < num; i++)
            {
                hand.AddCard(deck.GetCard());
            }
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return hand.ToString();
        }

    }
}
