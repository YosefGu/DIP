using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Exercise1
{
    internal class MissionController
    {
        public void RinMission()
        {
            string mission1 = "Running mission 1";
            FileLogger logger = new FileLogger();
            logger.Log($"Mission complete: {mission1}");
        }
    }
}
