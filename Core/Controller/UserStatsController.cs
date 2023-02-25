using Core.Models;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Controller
{
    public class UserStatsController
    {
        private UserStatService _service = new UserStatService();

        public bool GetAllStats()
        {
            List<UserStats> stats = _service.GetAllStats();
            if (stats == null || stats.Count == 0)
            {
                Console.WriteLine($"Статистики нет");
                return false;
            }
            for (int i = 0; i < stats.Count; i++)
            {
                Console.WriteLine(stats[i]);
            }
            return true;
        }
        public bool GetUserStat(User user)
        {
            List<UserStats> stats = _service.GetStatsUser(user.Id);
            if (stats == null  )
            {
                Console.WriteLine($"Статистики по {user.Name} нет");
                return false;
            }
            for (int i = 0; i < stats.Count; i++)
            {
                Console.WriteLine(stats[i]);
            }
            return true;
        }
        public bool AddUserStat(User user, string gameResult,string gameName)
        {
            if (user != null && gameResult != null)
            {
                UserStats stats = new UserStats(user, gameResult,gameName);
                _service.AddUserStats(stats);
                return true;
            }
            return false;

        }
    }
}
