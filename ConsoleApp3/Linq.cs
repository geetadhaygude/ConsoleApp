using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Linq
    {
        static void Main123(string[] args)
        {

            IList<string> stringList = new List<string>() {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials" ,
                "Java" };

            var linqResult = from obj in stringList
                           where obj.Contains("Tutorials")
                           select obj;

            stringList.Add("SS Tutorials");
            foreach (var obj in linqResult)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Objects");
            List<Student> objStudentList = new List<Student>() {
                new Student(){ StudentId=1,StudentName="GEETA",Age=25},
                new Student(){ StudentId=1,StudentName="SONALI",Age=25},
                new Student(){ StudentId=1,StudentName="RUSHABH",Age=22},
                new Student(){ StudentId=1,StudentName="RUSHABH",Age=12},
                new Student(){ StudentId=1,StudentName="LATA",Age=40},
                new Student(){ StudentId=1,StudentName="SURESH",Age=50}
            };


            //first Example
            //var linqData = from obj in objStudentList
            //               where obj.Age > 20 && obj.Age < 30
            //               select obj;
            //objStudentList.Add(new Student() { StudentId = 1, StudentName = "DHANi", Age = 21 });


            //Second Example
            //var linqData = from s in objStudentList
            //               where isAgeValid(s)
            //               select s;

            //Where Example
            //Func<Student, bool> isValidAgePresent = delegate (Student a)
            //{
            //    return a.Age > 20 && a.Age < 30;
            //};

            //var linqData = from s in objStudentList
            //               where isValidAgePresent(s)
            //               select s;

            //foreach (var ob in linqData)
            //    Console.WriteLine(ob.StudentName+" "+ob.Age);

            //OfType example

            ArrayList objArray = new ArrayList();
            objArray.Add("1");
            objArray.Add(2);
            objArray.Add(3);
            objArray.Add("Four");
            objArray.Add("Five");
            objArray.Add(new Student() { StudentId = 5, StudentName = "Ron", Age = 15 });


            //var result = from s in objArray.OfType<string>()
            //             select s;
            //foreach (var a in result)
            //    Console.WriteLine(a);


            //sorting example
            //var result = from s in objStudentList
            //             orderby s.Age ascending
            //             select s;
            //foreach (var s in result)
            //    Console.WriteLine(s.StudentName);

            //multiple Sorting

            //var result = from s in objStudentList
            //             orderby s.StudentName, s.Age descending
            //             select s;
            //foreach (var r in result)
            //    Console.WriteLine(r.StudentName+ " " +r.Age);

            //group by

            var result = from s in objStudentList
                         where s.Age>20
                         group s by s.Age;

            foreach(var rs in result)
            {
                Console.WriteLine("Age group:{0}", rs.Key);
                foreach(var d in rs)
                {
                    Console.WriteLine(d.StudentName);
                }
            }

            IList<StudentJoin> studentList = new List<StudentJoin>() {
    new StudentJoin() { StudentID = 1, StudentName = "John", Age = 13, StandardID =1 },
    new StudentJoin() { StudentID = 2, StudentName = "Moin",  Age = 21, StandardID =1 },
    new StudentJoin() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID =2 },
    new StudentJoin() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID =2 },
    new StudentJoin() { StudentID = 5, StudentName = "Ron" , Age = 15 }
};

            IList<Standard> standardList = new List<Standard>() {
                new Standard(){ StandardID = 1, StandardName="Standard 1"},
                new Standard(){ StandardID = 2, StandardName="Standard 2"},
                new Standard(){ StandardID = 3, StandardName="Standard 3"}
};

            var joinResult = from student in studentList
                             join standard in standardList
                             on student.StandardID equals standard.StandardID
                             where student.Age > 20
                             select new {
                                 StudentName = student.StudentName,
                                 Age=student.Age,
                                 StandardName=standard.StandardName
                             };


            var groupJoinResult = from std in standardList
                                  join stu in studentList
                                  on std.StandardID equals stu.StandardID
                                  into stdGrp
                                  select new
                                  {
                                      standardName = std.StandardName,
                                      students = stdGrp
                                  };

            var selectResult = from std in studentList
                               select std.StudentName;

            Console.ReadLine();
                
        }

        public static bool isAgeValid(Student s)
        {
            return s.Age > 20 && s.Age < 30;
        }
            
    }

    class Student:IComparable<Student>
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int CompareTo(Student other)
        {
            if (this.StudentName.Length >= other.StudentName.Length)
                return 1;

            return 0;
        }



    }
}
