using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public abstract class BaseRepository<T>
    {
        protected abstract string path { get; }
        public List<T> GetAll()
        {
            List<T> data = new List<T>();
            var serializeoptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };
            try
            {
                using StreamReader sr1 = new StreamReader($"{path}users.txt");
                string line = sr1.ReadLine();
                while (line != null)
                {
                    var fild = JsonSerializer.Deserialize<T>(line, serializeoptions);
                    data.Add(fild);
                    line = sr1.ReadLine();
                };
                sr1.Close();
                return data;
            }
            catch (FileNotFoundException)
            {
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateFile(List<T> userList)
        {
            try
            {
                var serializeoptions = new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                };
                StreamWriter sw1 = new StreamWriter($"{path}users.txt");
                for (int i = 0; i < userList.Count; i++)
                {
                    if (userList[i] != null)
                    {
                        string json = JsonSerializer.Serialize<User>(userList[i], serializeoptions);
                        sw1.WriteLine(json);
                    }
                }
                sw1.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
