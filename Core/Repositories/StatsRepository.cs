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
            List<UserStats> usersStats = GetAll();
            usersStats.Add(userStats);
            UpdateFile(usersStats);
        }
        public List<UserStats> GetUserStats(int id)
        {
            List<UserStats> users = GetAll();
            List<UserStats> Userstats = new List<UserStats>();
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].User.Id == id)
                {
                    Userstats.Add(users[i]);
                }
            }
            return Userstats;
        }
        public List<UserStats> GetAllStats()
        {
            List<UserStats> Userstats = GetAll();
            return Userstats;
        }
    }
}

