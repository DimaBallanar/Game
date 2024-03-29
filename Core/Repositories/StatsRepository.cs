﻿using System;
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

        protected override string Path { get; } = AppDomain.CurrentDomain.BaseDirectory + "stats.txt";
        public void AddUserStats(UserStats userStats)
        {
            if (userStats == null) throw new ArgumentNullException(nameof(userStats));
            List<UserStats> users = GetAll().ToList();
            users.Add(userStats);
            UpdateFile(users);
        }
        public List<UserStats> GetUserStats(int id)
        {
            List<UserStats> users = GetAll().ToList();
            List<UserStats> stats = new List<UserStats>();
            //через linq переписать where


            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Id == id)
                {
                    stats.Add(users[i]);
                }
            }
            return stats;
        }
        public List<UserStats> GetAllStats()
        {
            List<UserStats> users = GetAll().ToList();
            return users;
        }
    }
}

