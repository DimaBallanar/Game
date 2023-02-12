using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class GameJack
    {
        private Deck deck = new();
        private Player[] players;

        public Game()
        {
            players = new[]
            {
             new Player("Дилер", deck),
             new Player("Игрок", deck)
         };

            Start();
        }

    }
}
