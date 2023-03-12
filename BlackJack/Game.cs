using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Game
    {
        ConsoleKeyInfo cki;
        readonly Deck deck;
        public string NameGame { get; set; }
        public Game()
        {
            NameGame = "BlackJack";
            deck = new Deck();
        }

        public void Start(out string result)
        {
            result = null;
            Console.CancelKeyPress += new ConsoleCancelEventHandler(myHandler);
            while (true || cki.Key != ConsoleKey.Q)
            {
                Console.WriteLine("Для выхода с игры  в любой момент нажмите Q, чтобы выйти и сохранить S ");
                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.Q) { break; }
                Player player = new Player();
                Hand playerHand = player.Deal(deck);

                if (playerHand.IsBusted())
                {
                    Console.WriteLine("Game Over!");
                    result = "loss";
                    Console.ReadKey();
                    return;
                }
                else
                {
                    Console.WriteLine("Player stays at {0}", playerHand.Total());
                    Console.ReadKey();
                }

                Console.WriteLine();
                Console.WriteLine("Играет Диллер");
                Console.ReadKey();

                Dealer dealer = new Dealer();
                Hand dealerHand = dealer.Deal(deck);

                Console.WriteLine();
                if (dealerHand.IsBusted())
                {
                    Console.Write("Диллер выиграл!");
                    Console.WriteLine("Игрок проиграл!");
                    result = "loss";
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine();
                if (playerHand.Total() > dealerHand.Total())
                {
                    Console.WriteLine("игрок {0} победил дилера {1}", playerHand.Total(), dealerHand.Total()); ;
                    Console.WriteLine("Player Wins!");
                    result = "WIN";
                    Console.ReadKey();
                    return;
                }
                else if (playerHand.Total() < dealerHand.Total())
                {
                    Console.WriteLine("дилер {1} победил игрока {0}", playerHand.Total(), dealerHand.Total());
                    Console.WriteLine("Игрок проиграл!");
                    result = "Loss";
                    Console.ReadKey();
                    return;
                }
                else
                {
                    Console.WriteLine("дилер {1} = игрок {0}", playerHand.Total(), dealerHand.Total());
                    Console.WriteLine("Ничья");
                    result = "Ничья";
                    Console.ReadKey();
                    return;
                }
            }
            static void myHandler(object sender, ConsoleCancelEventArgs args)
            {

            }

        }
    }
}
