using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Dealer : Player
    {
        public Dealer() : base() { }

        public override Hand Deal(Deck deck)
        {
            while (hand.Total() < 17)
            {
                DealCards(1, deck);
            }
            return hand;
        }
    }
}
