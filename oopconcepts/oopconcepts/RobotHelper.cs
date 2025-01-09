using System;

namespace oopconcepts
{
    public static class RobotHelper
    {
        public static void CheckRobotStatus(Robot robot)
        {
            if (robot.GetIsActive())
            {
                Console.WriteLine($"{robot.GetName()} is active.");
            }
            else
            {
                Console.WriteLine($"{robot.GetName()} is not active.");
            }
        }
    }
}
