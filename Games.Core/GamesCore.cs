﻿using BlackJack;
using Games.Shared;

namespace Games.Core
{
    public class GamesCore:IGameMenu
    {
        

        Game game = new Game();
        //game.Play();
        public int IdUser { get; set; }

        public GamesCore(int idUser)
        {
            IdUser = idUser;

        }
        public void StartGame()
        {
            game.Start();
        }
        public void StopGame()
        {

        }
        public void Settings()
        {

        }
        public void StartWithSave()
        {

        }
      


        //public void MenuGames(out string gameResult)
        //{
        //    game.Start(out gameResult);
        //}


    }
}