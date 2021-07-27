using System;
using System.Collections.Generic;
using System.Linq;
namespace Homework_08_1
{
  class Developer
    {
        public string guid { get; set; }
        public string rank { get; set; }
        public string name { get; set; }
        public int experience { get; set; }
        public string responsibilities { get; set; }
        public string technologies { get; set; }
        public string gitHub { get; set; }
        public int salary { get; set; }


        enum Responsibilities
        {
            English,
            NET,
        }
        

        class Program
        {
            static void Main(string[] args)
            {

                Developer developer = new Developer();
                var developers = new List<string>();
                DevInput();
                void DevInput()
                {
                    Console.WriteLine("Enter developer's guid:");
                    developer.guid = Console.ReadLine();
                    Console.WriteLine("Enter developer's rank:");
                    developer.rank = Console.ReadLine();
                    Console.WriteLine("Enter developer's name:");
                    developer.name = Console.ReadLine();
                    Console.WriteLine("Enter developer's experience (in years):");
                    developer.experience = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter developer's GitHub link:");
                    developer.gitHub = Console.ReadLine();


                    developer.salary = 500;
                    developers.Add("Name: " + developer.name + ", Salary: " + developer.experience);
                    _ = developers.ToArray();

                }
                Finish();
                void Finish()
                {
                    Console.WriteLine("Are you finished? Yes/No: ");
                    string finish = Console.ReadLine();
                    if (finish == "Yes")
                    {
                        DevShow();
                    }
                    else if (finish != "Yes" && finish != "No")
                    {
                        Console.WriteLine("Invalid input!");
                        Finish();
                        return;
                    }
                    while (finish != "Yes")

                    {
                        DevInput();
                        Finish();
                        break;
                    }
                    void DevShow()
                    {
                        foreach (var item in developers)
                        {
                            Console.WriteLine(item);
                        }

                    }
                }
            }
        }
    }
}


