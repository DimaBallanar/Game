﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Game
    {
        Deck deck;
        public Game()
        {
            deck = new Deck();
        }

        public void Start(int id,out string result)
        {
             result = null;
            Player player = new Player();
            Hand playerHand = player.Deal(deck);

            if (playerHand.IsBusted())
            {
                Console.WriteLine("Game Over!");
                result = "win";
                return;
            }
            else
            {
                Console.WriteLine("Player stays at {0}", playerHand.Total());
            }

            Console.WriteLine();
            Console.WriteLine("Играет Диллер");

            Dealer dealer = new Dealer();
            Hand dealerHand = dealer.Deal(deck);

            Console.WriteLine();
            if (dealerHand.IsBusted())
            {
                Console.Write("Диллер проиграл!");
                Console.WriteLine("Игрок победил!");
                result = "loss";
                return;
            }

            Console.WriteLine();
            if (playerHand.Total() > dealerHand.Total())
            {
                Console.WriteLine("Player's {0} beats Dealer's {1}", playerHand.Total(), dealerHand.Total()); ;
                Console.WriteLine("Player Wins!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Dealer's {1} beats Player's {0}", playerHand.Total(), dealerHand.Total());
                Console.WriteLine("Game Over!");
                Console.ReadKey();
            }
            
        }
    }
}