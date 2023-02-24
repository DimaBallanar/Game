using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using System.Text.Json;

namespace Core.Repositories
{
    public class StatsRepository : BaseRepository<UserStats>
    {

        protected override string Path { get; } = AppDomain.CurrentDomain.BaseDirectory + "UserStats.txt";
        public void AddUserStats(UserStats userStats)
        {
            if (userStats == null) throw new ArgumentNullException(nameof(userStats));
            List<UserStats> stats = GetAll().ToList();
            stats.Add(userStats);
            UpdateFile(stats);
        }
        public List<UserStats> GetUserStats(int id)
        {
            List<UserStats> stats = GetAll().ToList()   ;
            List<UserStats> userstats = new List<UserStats>();
            for (int i = 0; i < stats.Count; i++)
            {
                if (stats[i].User.Id == id)
                {
                    userstats.Add(stats[i]);
                }
            }
            return userstats;
        }
        public List<UserStats> GetAllStats()
        {
            List<UserStats> stats = GetAll().ToList();
            return stats;
        }
    }
}

