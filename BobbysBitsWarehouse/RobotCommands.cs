using BobbysBitsWarehouse.RobotIncrementCommands;

namespace BobbysBitsWarehouse
{
    public class RobotCommands
    {
        private readonly int _bucketWidth;
        private readonly int _bucketHeight;
        private readonly IRobotIncrementFactory _robotIncrementFactory;
        private readonly int[,] _array;

        public RobotCommands(int bucketWidth, int bucketHeight, IRobotIncrementFactory robotIncrementFactory)
        {
            _bucketWidth = bucketWidth;
            _bucketHeight = bucketHeight;
            _robotIncrementFactory = robotIncrementFactory;
            _array = new int[_bucketWidth, _bucketHeight];
        }

        public RobotStatus HandleKeyPress(string userCommand, RobotStatus robotStatus)
        {
            foreach (char command in userCommand)
            {
                var incrementer = _robotIncrementFactory.Create(command);

                robotStatus = incrementer.IncrementRobot(robotStatus);

                if (robotStatus.IsInvalid)
                    return robotStatus;
            }

            return robotStatus;
        }
    }
}

