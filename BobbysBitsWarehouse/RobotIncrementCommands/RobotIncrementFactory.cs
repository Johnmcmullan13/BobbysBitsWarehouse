
namespace BobbysBitsWarehouse.RobotIncrementCommands
{
    public interface IRobotIncrementFactory
    {
        RobotCommandIncrement? Create(char userInput);
    }

    public class RobotIncrementFactory : IRobotIncrementFactory
    {
        public RobotCommandIncrement? Create(char userInput)
        {
            try
            {
                return (RobotCommandIncrement)Activator.CreateInstance(
                                    Type.GetType($"BobbysBitsWarehouse.RobotIncrementCommands.IncrementRobot{userInput}Command"));
            }
            catch (Exception ex)
            {
                return (RobotCommandIncrement)Activator.CreateInstance(
                                    Type.GetType($"BobbysBitsWarehouse.RobotIncrementCommands.IncrementRobotUnknownCommand"));
            }
        }
    }
}
