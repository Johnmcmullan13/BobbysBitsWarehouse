namespace BobbysBitsWarehouse.RobotIncrementCommands
{
    public class IncrementRobotDCommand : RobotCommandIncrement
    {
        public IncrementRobotDCommand()
        {
            
        }

        public override RobotStatus IncrementRobot(RobotStatus robotStatus)
        {
            var newInventory = (robotStatus.Inventory - 1);
            var newBucketStatus = (robotStatus.BucketArray[robotStatus.X, robotStatus.Y] + 1);

            if (newInventory < 0)
            {
                robotStatus.LogMessage = "Robot ran out of inventory";
                robotStatus.IsInvalid = true;
                return robotStatus;
            }

            if (newBucketStatus > 5)
            {
                robotStatus.LogMessage = "Bucket status went passed its limit";
                robotStatus.IsInvalid = true;
                return robotStatus;
            }

            robotStatus.BucketArray[robotStatus.X, robotStatus.Y] = newBucketStatus;
            robotStatus.Inventory = newInventory;

            return robotStatus;
        }
    }
}
