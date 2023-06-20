using System;
namespace BobbysBitsWarehouse.RobotIncrementCommands
{
    public abstract class RobotCommandIncrement
    {
        public RobotCommandIncrement()
        {
            
        }

        public abstract RobotStatus? IncrementRobot(RobotStatus robotStatus);
    }
}
