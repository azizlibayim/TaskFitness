using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFitness
{
    public abstract class Activity
    {
        public string ActivityName { get; set; }
        public int Duration { get; set; }
        public int CaloriesBurned { get; set; }


        public Activity (string activityName, int duration)
        {
            ActivityName = activityName;
            Duration = duration;
        }

        public abstract void CalculateCalories();
        public void PrintActivity()
        {
            Console.WriteLine($"{ActivityName} burned {CaloriesBurned} calories in {Duration} minutes.");
        }
    }
    public class Running : Activity
    {
        public Running (string activityName, int duration) : base(activityName, duration) { }
        public override void CalculateCalories()
        {
            CaloriesBurned = Duration * 10;
        }
    }
    public class Cycling : Activity
    {
        public Cycling(string activityName, int duration) : base(activityName, duration) { }
        public override void CalculateCalories() 
        {
            CaloriesBurned = Duration * 8;
        }
    }
}
