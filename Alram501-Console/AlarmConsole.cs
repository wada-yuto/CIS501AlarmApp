using System;
using Alarm501;


namespace Alram501_Console
{
    public class AlarmConsole
    {
        static void Main(string[] args)
        {
            string option;
            bool setting = true;
            while (setting)
            {
                Console.WriteLine("Add (a), Edit(e), Stop(s), Snooze(s), Quit(q)");
                option = Console.ReadLine().ToLower();
                //List out all the alarm in the text file.
                //Ask user what they want to do with the alarm.
                //Options are Add, Edit, Stop, and Snooze.
                //If (add)
                //If (edit)
                if(option == "a")
                {
                    Console.WriteLine("Add");
                }
                if(option == "e")
                {
                    Console.WriteLine("Edit");
                }
                if (option == "s")
                {
                    Console.WriteLine("Snoose");
                }
                if(option == "q")
                {
                    Console.WriteLine("Quit");
                    setting = false;
                }

            }

            
        }
    }
}
