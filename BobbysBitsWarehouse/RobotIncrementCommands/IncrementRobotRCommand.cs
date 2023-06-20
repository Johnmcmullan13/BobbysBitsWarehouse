using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysBitsWarehouse.RobotIncrementCommands
{
    public class IncrementRobotRCommand : RobotCommandIncrement
    {
        public IncrementRobotRCommand()
        {
            
        }

        public override RobotStatus IncrementRobot(RobotStatus robotStatus)
        {
            robotStatus.LogMessage += "New coordinates: X = " + robotStatus.X + ", Y = " + robotStatus.Y
                   + ", Robot Inventory: " + robotStatus.Inventory + ", Bucket Inventory: " + robotStatus.BucketArray[robotStatus.X, robotStatus.Y];

            return robotStatus;
        }
    }
}
