using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Deck
    {
        Random random;
        public Deck()
        {
            random = new Random();
        }

        public Card GetCard()
        {
            int rank = random.Next(1, 11);
            Card c = new Card(rank);
            return c;
        }
    }
}
