using BobbysBitsWarehouse.Validation;

namespace BobbysBitsWarehouse.RobotIncrementCommands
{
    public class IncrementRobotSCommand : RobotCommandIncrement
    {
        public IncrementRobotSCommand()
        {
        }

        public override RobotStatus IncrementRobot(RobotStatus robotStatus)
        {
            var newYCoordinate = (robotStatus.Y - 1);

            if (newYCoordinate < 0)
            {
                robotStatus.LogMessage = "Robot went out of bounds South";
                robotStatus.IsInvalid = true;
                return robotStatus;
            }

            robotStatus.Y = newYCoordinate;

            return robotStatus;
        }
    }
}
