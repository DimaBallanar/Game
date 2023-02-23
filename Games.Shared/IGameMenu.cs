using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Shared
{
    public interface IGameMenu
    {
        public void StartGame();
        public void StopGame();
        public void Settings();
        public void StartWithSave();
    }
}
