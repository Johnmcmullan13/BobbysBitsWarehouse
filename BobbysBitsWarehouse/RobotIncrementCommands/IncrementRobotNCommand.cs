namespace BobbysBitsWarehouse.RobotIncrementCommands
{
    public class IncrementRobotNCommand : RobotCommandIncrement
    {
        public IncrementRobotNCommand()
        {
        }

        public override RobotStatus IncrementRobot(RobotStatus robotStatus)
        {
            var newYCoordinate = (robotStatus.Y + 1);

            if (newYCoordinate > 10)
            {
                robotStatus.LogMessage = "Robot went out of bounds North";
                robotStatus.IsInvalid = true;
                return robotStatus;
            }

            robotStatus.Y = newYCoordinate;

            return robotStatus;
        }
    }
}
