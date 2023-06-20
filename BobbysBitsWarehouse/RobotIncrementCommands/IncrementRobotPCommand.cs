using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysBitsWarehouse.RobotIncrementCommands
{
    public class IncrementRobotPCommand :RobotCommandIncrement
    {
        public IncrementRobotPCommand()
        {
            
        }

        public override RobotStatus IncrementRobot(RobotStatus robotStatus)
        {
            var newInventory = (robotStatus.Inventory - 1);
            var newBucketStatus = (robotStatus.BucketArray[robotStatus.X, robotStatus.Y] + 1);

            if (newBucketStatus < 0)
            {
                robotStatus.LogMessage = "Bucket is already empty";
                robotStatus.IsInvalid = true;
                return robotStatus;
            }

            robotStatus.BucketArray[robotStatus.X, robotStatus.Y] = newBucketStatus;
            robotStatus.Inventory = newInventory;

            return robotStatus;
        }
    }
}
