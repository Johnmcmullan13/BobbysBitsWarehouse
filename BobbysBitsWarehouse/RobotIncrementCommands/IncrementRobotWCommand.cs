using BobbysBitsWarehouse.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysBitsWarehouse.RobotIncrementCommands
{
    public class IncrementRobotWCommand : RobotCommandIncrement
    {
        public IncrementRobotWCommand()
        {
        }

        public override RobotStatus IncrementRobot(RobotStatus robotStatus)
        {
            var newXCoordinate = (robotStatus.X - 1);

            if (newXCoordinate < 0)
            {
                robotStatus.LogMessage = "Robot went out of bounds West";
                robotStatus.IsInvalid = true;
                return robotStatus;
            }

            robotStatus.X = newXCoordinate;

            return robotStatus;
        }
    }
}
