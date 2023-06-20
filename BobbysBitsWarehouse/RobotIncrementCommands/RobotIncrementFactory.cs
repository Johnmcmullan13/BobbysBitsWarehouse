using BobbysBitsWarehouse.Validation;

namespace BobbysBitsWarehouse.RobotIncrementCommands
{
    public interface IRobotIncrementFactory
    {
        RobotCommandIncrement? Create(char userInput);
    }

    public class RobotIncrementFactory : IRobotIncrementFactory
    {
        private readonly IBoundaryValidation _boundaryValidation;

        public RobotIncrementFactory(IBoundaryValidation boundaryValidation)
        {
            _boundaryValidation = boundaryValidation;
        }

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
