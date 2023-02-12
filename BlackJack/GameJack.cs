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
        public bool IsEnded { get; private set; }

        public void Start()
        {
            bool replay = true;
            while (replay)
            {
                Console.Clear();
                Turn();
                IsEnded = players.Any(x => x.IsLost);

                Console.ReadLine();

                if (IsEnded)
                    replay = Replay();
            }
        }
    }
}
