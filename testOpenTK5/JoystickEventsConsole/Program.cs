using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoystickEvents.OpenTk;
using JoystickEvents.OpenTk.Events;

namespace JoystickEventsConsole
{
    class Program
    {
        static bool exit = false;
        private static ControllerEngine controller;
        
        static void Main(string[] args)
        {
            controller = new ControllerEngine();
            controller.Gamepad.Start.Pressed += Start_Pressed;

            

        }




        private static void Start_Pressed(object sender, ActionEventArgs e) {
            Console.WriteLine("You Pressed Start!\n\n\n");
            exit = true;
            Console.ReadLine();
        }
    }
}
