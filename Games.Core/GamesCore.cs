using BlackJack;
using Games.Shared;

namespace Games.Core
{
    public class GamesCore : IGameMenu
    {


        Game game = new Game();
    
        public int IdUser { get; set; }

        public GamesCore(int idUser)
        {
            IdUser = idUser;
        }
        public void StartMenu(out string result)
        {
            result = null;
            Console.WriteLine("хотите начать заново?д/н");
            if (Console.ReadLine() == "д")
            {
                StartGame(out  result);
                Console.WriteLine("сыграем еще?д/н");
                if (Console.ReadLine() == "д")
                {
                    StartGame(out  result);
                }
            }
            else
            {
                StartWithSave();
            }
        }
        public void StartGame(out string result)
        {
            game.Start(IdUser,out  result);
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
        
       

    }
}