using System;
using System.IO;
public class Program
{
    static void Main(string[] args)
    {
    
        for (int i = 0; i < 20; i++)
        {
            Journal journal = new Journal();
            PromptGenerator promptGenerator = new PromptGenerator();
            Console.WriteLine("What would you like to do?");
            string choice = Console.ReadLine();
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();

            if (choice == "1")
            {
                Random random = new Random();  
                Entry entry1 = new Entry();
                int promptList = random.Next(entry1._Entries.Count);
                Console.WriteLine(entry1._Entries[promptList]);
                string userEntry = Console.ReadLine();
                


                string fileName = "myJournal.txt";

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine(dateText);
                    outputFile.WriteLine(entry1._Entries[promptList]);
                    outputFile.WriteLine(userEntry);
                }
            }
            else if (choice == "2")
            {
                string filename = "myJournal.txt";
                string[] lines = System.IO.File.ReadAllLines(filename);
           
                Console.WriteLine("Prompt:");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");
                    string readPrompt = parts[0];

                  
                    {
                        
                        
                        Console.WriteLine($"{readPrompt}");
                    }
        }
            }        
        }
            
                
            }    


            }
        