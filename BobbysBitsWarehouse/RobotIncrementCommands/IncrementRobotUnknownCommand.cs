namespace BobbysBitsWarehouse.RobotIncrementCommands
{
    public class IncrementRobotUnknownCommand : RobotCommandIncrement
    {
        public IncrementRobotUnknownCommand()
        {
        }

        public override RobotStatus IncrementRobot(RobotStatus robotStatus)
        {
            robotStatus.LogMessage = "Invalid key entered";
            robotStatus.IsInvalid = true;

            return robotStatus;
        }
    }
}
