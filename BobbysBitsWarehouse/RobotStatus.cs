using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysBitsWarehouse
{
    public class RobotStatus
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public int Inventory { get; set; } = 20;
        public int[,] BucketArray { get; set; }
        public string LogMessage { get; set; } = string.Empty;
        public bool IsInvalid { get; set; } = false;
    }
}
