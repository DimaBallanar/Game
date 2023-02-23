using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Shared
{
    public interface IGameMenu
    {
        public void StartGame(out string result);
        public void StopGame();
        public void Settings();
        public void StartWithSave();
    }
}
