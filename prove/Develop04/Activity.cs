using System;

    public class Activity
    {
        public List<string> _Activities = new List<string>();
        private string _welcomeMessage = "Hello, Welcome to the mindfulness program" +
        "\nMenu Options:" + "\n1.Start Breathing Activity" + "\n2.Start Reflecting Activity" + "\n3.Start Listening Activity" +"\n4.Quit" + "\nPlease select an option from the menu.";
        private string _endMessage = "Thank you for using the mindfulness program, have a great day!";

    
        public string DisplayWelcome()
        {
            return $"{_welcomeMessage}";
        }

        public string DisplayEnd()
        {
            return $"{_endMessage}";
        }
    }
