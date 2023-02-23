using Core.Models;
using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class UserStatService
    {
        private readonly StatsRepository _userStatsRepository = new StatsRepository();

        public List<UserStats> GetAllStats()
        {
            return _userStatsRepository.GetAllStats();
        }
        public List<UserStats> GetStatsUser(int id)
        {
            return _userStatsRepository.GetUserStats(id);
        }
        public void AddUserStats(UserStats userStats)
        {
            _userStatsRepository.AddUserStats(userStats);
        }
    }
}
