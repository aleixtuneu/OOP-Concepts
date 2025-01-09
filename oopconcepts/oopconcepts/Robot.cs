using System;
namespace oopconcepts
{
    public class Robot
    {
        // attributes
        protected string name;
        protected bool isActive;
        protected double batteryLevel;

        // getters
        public string GetName() { return this.name; }
        public bool GetIsActive() { return this.isActive; }
        public double GetBatteryLevel() { return this.batteryLevel; }

        // setters
        public void SetName(string name) { this.name = name; }
        public void SetIsActive(bool isActive) { this.isActive = isActive; }
        public void SetBatteryLevel(double batteryLevel) { this.batteryLevel = batteryLevel; }

        // constructor
        public Robot(string name, double batteryLevel)
        {
            this.SetName(name);
            this.SetBatteryLevel(batteryLevel);
            this.isActive = false;
        }

        // methods
        public virtual void PowerOn()
        {
            if (batteryLevel > 0)
            {
                isActive = true;
                Console.WriteLine($"{name} is now activated.");
            }
            else
            {
                Console.WriteLine("Battery is too low to power on.");
            }
        }

        public virtual void PerformTask(string task)
        {
            if (this.isActive && this.batteryLevel > 0)
            {
                Console.WriteLine($"{this.name} is performing task: {task}");
            }
            else
            {
                Console.WriteLine($"{this.name} cannot perform the task.");
            }
        }
    }
}
