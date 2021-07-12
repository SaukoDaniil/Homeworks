using System;

namespace HomeWork_07_1
{

    class Person
    {
        public string name;
        public int age;
        public string question;
        public int rightAnswer = 2;
        public int studentAnswer;
    }

    class Student : Person
    {
    public Student(string studentName, int studentAge)
        {
            name = studentName;
            age = studentAge;
        }
        public string GetName()
        {
            return name;
        }
        public int GetAge()
        {
            return age;
        }
       
    }
    class Teacher : Person
    {
        public Teacher(string teacherName, int teacherAge)
        {
            name = teacherName;
            age = teacherAge;
        }
        public string GetName()
        {
            return name;
        }
        public int GetAge()
        {
            return age;
        }
        

    }
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            Student student1 = new Student("Fernando", 21);
            Teacher teacher1 = new Teacher("Mr. Harris", 30);
            teacher1.question = "What is 1+1?";
            student1.studentAnswer = randomGenerator.Next(1, 11);
            Console.WriteLine("My name is" + " " + student1.GetName() + ", I'm "+ student1.GetAge()+" years old and I'm going to class");
            Console.WriteLine(student1.GetName()+" says: Hello, "+teacher1.GetName()+"!");
            Console.WriteLine("Good morning, " + student1.GetName()+"! Are you ready for a test? "+teacher1.question);
            Console.WriteLine("My answer is " + student1.studentAnswer);
            if (student1.studentAnswer == teacher1.rightAnswer)
            {
                Console.WriteLine("Well done, " + student1.GetName());
            }
            else
            {
                Console.WriteLine("Wrong, " + student1.GetName());
            }
          }
    }
}




