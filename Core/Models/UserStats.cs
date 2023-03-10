using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Core.Models
{
    public class UserStats
    {
        //public User User { get; set; }
        public int Id { get; set; }
        public string GameResult { get; set; }
        public string GameName { get; set; }
        public DateTime Time { get;set; }
        
        public UserStats(int id, string gameResult, string gameName)
        {
            Id = id;
            GameResult = gameResult;
            GameName = gameName;
            Time = DateTime.Now;
        }

        public override string ToString()
        {
            return $"User {Id} {GameName} result: {GameResult} {Time}";
        }
    }
}
