using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TaskFitness
{
    public class FitnessTracker
    {
        public string DeviceName { get; private set; }
        public int BatteryLife { get; set; } = 24;
        public int TotalSteps { get; private set; } = 0;
        private List<string> Users { get; set; } = new List<string>();

        public FitnessTracker(string deviceName)
        {
            DeviceName = deviceName;
        }
        public virtual void TrackSteps( int steps)

        {
            if (steps >= 1 && steps <= 50000)
            {
                TotalSteps += steps;
                Console.WriteLine($"Tracked {steps} steps. Total steps: {TotalSteps}.");
            }
            else
            {
                Console.WriteLine("Invalid number of steps. Please enter a value between 1 and 50,000.");
            }

        }



        public virtual void AddUser(string userName)
        {
            if (Users.Count >= 3)
            {
                Console.WriteLine("Cannot add more users. The limit of 3 users has been reached.");
            }
            else 
            {
                Users.Add(userName);
                Console.WriteLine($"User {userName} has been added.");
            }
        }

        public virtual void DeleteUser(string userName)
        {
            if (Users.Remove(userName))
            {
                Console.WriteLine($"User {userName} has been deleted.");
            }
            else
            {
                Console.WriteLine("User not found. No user was deleted.");
            }
        }



        public virtual void PrintInfo ()
        {
            Console.WriteLine($"FitTrack is called {DeviceName}, it has {BatteryLife} hours of battery life, {TotalSteps} total steps, and {Users.Count} users.");
        }

    }

}



