using BlackJack;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Game
    {
        private CardDeck deck = new();
        private Player[] players;
        public int NumPlayers { get; set; }

        public Game(int numPlayers)
        {

            players = new Player[numPlayers];
            for (int i = 0; i < players.Length; i++)
            {
                players[i] = new Player($"игрок{i}", deck);
            }
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

        private void Turn()
        {
            foreach (var player in players)
            {
                var status = player.Take() ? "Еще в игре" : "Проиграл";
                Console.WriteLine($"У {player.Name} {player.Score}, он {status}");
            }
        }

        private bool Replay()
        {
            bool result = false;

            while (true)
            {
                Console.Clear();
                Console.Write("Повторить? (y/n): ");
                var value = Console.ReadLine();

                if (value is "y" or "n")
                {
                    result = value is "y";
                    break;
                }
            }

            if (result)
            {
                Reset();
            }

            return result;
        }

        private void Reset()
        {
            deck = new();
            foreach (var player in players)
            {
                player.Reset();
            }
        }
    }

}
