namespace BobbysBitsWarehouse.RobotIncrementCommands
{
    public class IncrementRobotECommand : RobotCommandIncrement
    {
        public IncrementRobotECommand()
        {
        }

        public override RobotStatus IncrementRobot(RobotStatus robotStatus)
        {
            var newXCoordinate = (robotStatus.X + 1);

            if (newXCoordinate > 10)
            {
                robotStatus.LogMessage = "Robot went out of bounds East";
                robotStatus.IsInvalid = true;
                return robotStatus;
            }

            robotStatus.X = newXCoordinate;

            return robotStatus;
        }
    }
}
