using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Card
    {
        public string Name { get; set; }
        public int Value { get; set; }
        //public CardTypes Type { get; set; }
        public CardTypes CardEnum { get; set; }
        public Card()
        {

        }
        public Card(string name, int value,/* CardTypes type,*/CardTypes card)
        {
            Name = name;
            Value = value;
            //Type = type;
            CardEnum = card;
        }
    }
}
