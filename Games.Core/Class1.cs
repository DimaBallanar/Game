using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Games;
using GameXO;

namespace Games.Core
{
    public class GamesCore
    {
        // отсюда будем вызывать

        // функцианал коре 

        // принимать поля id для ведения статистики игры 
        // подключаться к репозиторию статистики и писать туда статистику по текущей игре 
        // отдельный фаил для породолжения игры !

        //
        private XO games = new XO();
        public int IdUser { get; set; }

        public GamesCore(int idUser)
        {
            IdUser = idUser;
        }

        public void MenuGames(out string gameResult)
        {
            games.Start(out gameResult);
        }

    }
}