using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Hand
    {
        ArrayList cards;
        public Hand()
        {
            cards = new ArrayList();
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public bool IsBusted()
        {
            return this.Total() > 21;
        }

        public int Total()
        {
            int total = 0;
            foreach (Card card in cards)
            {
                total += card.Value;
            }
            return total;
        }
        public override string ToString()
        {
            string s = "Hand: ";
            foreach (Card card in cards)
            {
                s += card + " ";
            }
            s += "\nTotal: ";
            s += Total();
            return s;
        }
    }
}
