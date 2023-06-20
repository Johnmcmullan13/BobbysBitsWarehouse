using BobbysBitsWarehouse.RobotIncrementCommands;

namespace BobbysBitsWarehouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var robotCommands = new RobotCommands(10,10, new RobotIncrementFactory());
            var isContinue = true;
            var robotStatus = new RobotStatus();

            robotStatus.BucketArray = new int[10, 10];

            while (isContinue)
            {
                robotStatus.LogMessage = string.Empty;
                Console.WriteLine("Please enter a command");
                var direction = Console.ReadLine() ?? "";
                Console.WriteLine("");

                if (direction.Contains('Q'))
                    break;

                robotStatus = robotCommands.HandleKeyPress(direction, robotStatus);

                if (!string.IsNullOrEmpty(robotStatus.LogMessage))
                    Console.WriteLine(robotStatus.LogMessage);

                if (robotStatus.IsInvalid)
                {
                    break;
                }

                Console.WriteLine("");
            }
        }
    }
}