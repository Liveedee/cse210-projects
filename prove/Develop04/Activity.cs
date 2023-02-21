using System;

    public class Activity
    {
        private string _welcomeMessage = "Hello, Welcome to the mindfulness program";
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
