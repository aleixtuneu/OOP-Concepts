using System;
namespace oopconcepts
{
    public class Program
    {
        public static void Main()
        {
            // constants
            const string MsgIntroduceRobotName = "Introduce your robot's name: ";
            const string MsgIntroduceAdvancedRobotName = "Introduce your advanced robot's name: ";
            const string MsgIntroduceRobotBatteryLevel = "Introduce your robot's battery level: ";
            const string MsgIntroduceAdvancedRobotBatteryLevel = "Introduce your advanced robot's battery level: ";
            const string MsgRobotInfo = "Here's your robot's info:\nName: {0}\nBatteryLevel: {1}";
            const string MsgIntroduceTask = "Write a task to do: ";
            const string MsgBatteryLevelError = "Error. The battery must be an integer between 0 and 100.";
            const string MsgAdvancedRobotSpecialFeature = "Introduce your advanced robot's special feature: ";

            // variables
            string robotName = "";
            string advancedRobotName = "";
            string robotTask = "";
            string advancedRobotTask = "";
            string advancedRobotSpecialFeature = "";
            int robotBatteryLevel = 0;
            int advancedRobotBatteryLevel = 0;

            // ask for attributtes
            Console.WriteLine(MsgIntroduceRobotName);
            robotName = Console.ReadLine().ToString();
            Console.WriteLine();

            Console.WriteLine(MsgIntroduceRobotBatteryLevel);
            while (!int.TryParse(Console.ReadLine(), out robotBatteryLevel) || (robotBatteryLevel < 0 || robotBatteryLevel > 100))
            {
                Console.WriteLine();
                Console.WriteLine(MsgBatteryLevelError);
                Console.WriteLine();
                Console.WriteLine(MsgIntroduceRobotBatteryLevel);
            }
            Console.WriteLine();

            // make the instance
            Robot robotOne = new Robot(robotName, robotBatteryLevel);

            // show info
            Console.WriteLine(MsgRobotInfo, robotOne.GetName(), robotOne.GetBatteryLevel());
            Console.WriteLine();

            // power on?
            robotOne.PowerOn();
            Console.WriteLine();

            // perform task
            Console.WriteLine(MsgIntroduceTask);
            robotTask = Console.ReadLine().ToString();
            Console.WriteLine();

            robotOne.PerformTask(robotTask);
            Console.WriteLine();



            // ask for attributtes
            Console.WriteLine(MsgIntroduceAdvancedRobotName);
            advancedRobotName = Console.ReadLine().ToString();
            Console.WriteLine();

            Console.WriteLine(MsgIntroduceAdvancedRobotBatteryLevel);
            while (!int.TryParse(Console.ReadLine(), out advancedRobotBatteryLevel) || (advancedRobotBatteryLevel < 0 || advancedRobotBatteryLevel > 100))
            {
                Console.WriteLine();
                Console.WriteLine(MsgBatteryLevelError);
                Console.WriteLine();
                Console.WriteLine(MsgIntroduceAdvancedRobotBatteryLevel);
            }
            Console.WriteLine();

            Console.WriteLine(MsgAdvancedRobotSpecialFeature);
            advancedRobotSpecialFeature = Console.ReadLine().ToString();
            Console.WriteLine();

            // make the instance
            AdvancedRobot advancedRobotOne = new AdvancedRobot(advancedRobotName, advancedRobotBatteryLevel, advancedRobotSpecialFeature);

            // show info
            Console.WriteLine(MsgRobotInfo, robotOne.GetName(), robotOne.GetBatteryLevel());
            Console.WriteLine();

            // power on?
            advancedRobotOne.PowerOn();
            Console.WriteLine();
        }
    }
}