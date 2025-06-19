using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Exercise1
{
    internal class MissionController
    {
        public readonly ILogger _logger;
        public MissionController(ILogger logger) 
        {
            _logger = logger;   
        }
        public void RunMission()
        {
            string mission = "Running mission";
            _logger.Log($"Mission complete: {mission}");
        }
    }
}
