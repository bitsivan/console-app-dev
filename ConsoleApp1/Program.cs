using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Student
    {
        public int StudentID{get;set;}
        public String StudentName {get;set;}
        public int Age { get; set; }
        
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //string[] students={"ana","juan","antonio","ximena","carlos"};

            var students = new string[] { "ana", "juan", "antonio", "ximena", "carlos" };
            int[] myNum = { 10, 20, 30, 40, 50 };
            myNum[1] = 100;
            Console.WriteLine(myNum.Length);
            foreach (int a in myNum)
            {
                Console.WriteLine(a);
            }

            List<String> Food = new List<String>();
            Food.Add("chiken");
            Food.Add("chiken");
            Food.Add("chiken");
            Food.Add("chiken");
            Food.Add("chiken");

            foreach (string a in Food)
            {
                Console.WriteLine(a);
            }

            //Linq Query Array
            string[] names={"Bill","Steve","James","Mohan","Ivan","Ana", "Alex"};
            Student[] studentArray = { 
            new Student() { StudentID = 1, StudentName = "John", Age = 18 },
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
            new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
            new Student() { StudentID = 7, StudentName = "Rob",Age = 19  }};

            //Query
            var myLinq=from name in names
                        where name.Contains('i')
                        select name;

            foreach( var name in myLinq)
            {
                Console.WriteLine(name+ " ");
            }

            Console.WriteLine();
            Student[] students2=new Student[10];
            int i=0;
            foreach(Student std in studentArray)
            {
                if(std.Age>12 && std.Age<20)
                {
                    students2[i]=std;
                    i++;
                }
            }

            //Linq Find teen
            Student[] teen=studentArray.Where(s=>s.Age>12 && s.Age<20).ToArray();

            Student bill=studentArray.Where(s=>s.StudentName=="Bill").FirstOrDefault();

            IList<string> listLearn=new List<string>(){
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials",
                "Java"
            };

            //Sintax Query
            var result=from s in listLearn
                    where s.Contains("Tutorials")
                    select s;
            
            //Sintax Method
            var result2=listLearn.Where(s=>s.Contains("Tutorials"));

            Func<Student, bool>IsTeenAger=s=>s.Age>12 && s.Age<20;

            Student std2=new Student(){Age=21};
            bool isTeen=IsTeenAger(std2);
            Console.WriteLine(isTeen);

            //Test Abstract Class
            G obj=new G1();
            obj.Hello();
            obj=new G2();
            obj.Hello();

            ClassA aInterface=new ClassA();
            aInterface.Show();

            string[] colors={"blue", "green","red","pink", "yellow"};

            foreach(string _color in colors){
                Console.WriteLine(_color);
            }
        }
    }
}
