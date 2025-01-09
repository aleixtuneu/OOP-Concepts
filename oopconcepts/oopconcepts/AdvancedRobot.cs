using System;

namespace oopconcepts
{
    public class AdvancedRobot : Robot
    {
        // attibutes
        private string specialFeature;

        // getters
        public string GetSpecialFeature() { return this.specialFeature; }

        // setters
        public void SetSpecialFeature(string specialFeature) { this.specialFeature = specialFeature; }

        // constructor
        public AdvancedRobot(string name, int batteryLevel, string specialFeature) : base(name, batteryLevel)
        {
            this.SetName(name);
            this.SetBatteryLevel(batteryLevel);
            this.SetSpecialFeature(specialFeature);
            this.isActive = false;
        }

        // methods
        public override void PowerOn()
        {
            if (this.batteryLevel > 0)
            {
                this.isActive = true;
                Console.WriteLine($"{this.name} powered on with special feature: {this.specialFeature}");
            }
            else
            {
                Console.WriteLine("Battery is too low to power on.");
            }
        }
    }
}
