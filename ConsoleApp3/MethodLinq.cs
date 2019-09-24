using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class MethodLinq
    {
        static void Main88(string[] args)
        {

            IList<string> stringList = new List<string>() {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials" ,
                "Java",
            "Java"};

            var methodResult = stringList.Where(a => a.Contains("Tutorials"));
            foreach (var obj in methodResult)
                Console.WriteLine(obj);

            IList<Student> studentList = new List<Student>() {
                    new Student() { StudentId = 1, StudentName = "John", Age = 13} ,
                    new Student() { StudentId = 2, StudentName = "Moin",  Age = 21 },
                    new Student() { StudentId = 3, StudentName = "Bill",  Age = 18 },
                    new Student() { StudentId = 4, StudentName = "Ram" , Age = 20},
                    new Student() { StudentId = 5, StudentName = "Ron" , Age = 16 },
                    new Student() { StudentId = 6, StudentName = "Ron" , Age = 15 },
                    new Student() { StudentId = 7, StudentName = "Raju" , Age = 15 }
            };

            var result = studentList.Where(a => a.Age > 11 && a.Age <= 20).ToList();

            var result1 = studentList.Where((s, i) => {
                if (i % 2 == 0)
                    return true;

                return false;
             });
            foreach(var s in result1)
                Console.WriteLine(s.StudentName);

            var result2 = studentList.Where(a=>a.Age>15).OrderBy(a => a.StudentName);

            foreach (var s in result2)
                Console.WriteLine(s.StudentName);

            var result3 = studentList.Where(a1 => a1.Age > 15).OrderByDescending(a1 => a1.StudentName);

            foreach (var s in result3)
                Console.WriteLine(s.StudentName);

            var result4 = studentList.OrderBy(a => a.StudentName).ThenBy(a => a.Age).ThenByDescending(a => a.StudentName);
            foreach (var s in result4)
                Console.WriteLine(s.StudentName+" "+s.Age);

            var result5 = studentList.Where(a => a.Age > 12).GroupBy(a => a.Age).Select(a=>a);

            var result6 = studentList.Where(a=>a.Age>12).ToLookup(a => a.Age);

            List<string> strList1 = new List<string>()
            {
                "One","Two","Three","four"
            };
            List<string> strList2 = new List<string>()
            {
                "One","Two","Five","Six"
            };

            var joinResult = strList1.Join(strList2, s => s, s => s, (s3, s2) => s2);

            IList<StudentJoin> studentJoinList = new List<StudentJoin>() {
            new StudentJoin() { StudentID = 1, StudentName = "John", StandardID =1 },
            new StudentJoin() { StudentID = 2, StudentName = "Moin", StandardID =1 },
            new StudentJoin() { StudentID = 3, StudentName = "Bill", StandardID =2 },
            new StudentJoin() { StudentID = 4, StudentName = "Ram" , StandardID =2 },
            new StudentJoin() { StudentID = 5, StudentName = "Ron"  }
};

            IList<Standard> standardList = new List<Standard>() {
            new Standard(){ StandardID = 1, StandardName="Standard 1"},
            new Standard(){ StandardID = 2, StandardName="Standard 2"},
            new Standard(){ StandardID = 3, StandardName="Standard 3"}
};

            var objResultJoin = studentJoinList.Join(standardList, student => student.StandardID, standard => standard.StandardID,
                              (stu, st) => new  
                              {
                                  StudentName = stu.StudentName,
                                  StandardName = st.StandardName
                              }).ToList();

            var resultTemp = studentJoinList.Join(standardList, a => a.StandardID, b => b.StandardID, (s, s1) => s);

            var resultTemp1 = studentJoinList.Join(standardList, a => a.StandardID, b => b.StandardID, (s, s1) => s1);
            var resultTemp2 = studentJoinList.Join(standardList, a => a.StandardID, b => b.StandardID, (s, s1) => new {
                studentName=s.StudentName,
                standardName=s1.StandardName
            });

            var resultGrp = standardList.GroupJoin(studentJoinList,
                            a => a.StandardID, b => b.StandardID, (a, studentGroup) =>new 
                            {
                                studentGroups = studentGroup,
                                standardName = a.StandardID
                            }
                            );

            var selectResult = studentJoinList.Select(a => a.StudentName);

            List<Person> objPersonList = new List<Person>
            {
                new Person(){ Id=1,Name="Geeta",Age=25,
                    Bikes =new List<Bike>{
                                new Bike{ BikeNo=12,BikeName="Scooty",Features=new List<string> { "P"} },
                                new Bike { BikeNo = 123, BikeName = "TVS",Features=new List<string>() { "A","B"} } } },
                new Person(){ Id=2,Name="Soni",Age=24,
                    Bikes =new List<Bike>{
                                new Bike{ BikeNo=123,BikeName="Activa",Features=new List<string> { "P"} },
                                new Bike { BikeNo = 123, BikeName = "TVS",Features=new List<string>() { "A","B"} } } },
                new Person(){ Id=3,Name="Rushabh",Age=23,
                    Bikes =new List<Bike>{
                                new Bike{ BikeNo=1245,BikeName="Pulsar"} } },
                new Person(){ Id=4,Name="Dhani",Age=19,
                    Bikes =new List<Bike>{
                                new Bike{ BikeNo=124589,BikeName="bicycle"} } }
            };

            var selectManyResult = objPersonList.Select(a => a).ToList().Select(b => new {
                id = b.Id,
                name = b.Name,
                Age = b.Age,
                BikeName = b.Bikes.Select(a => a.BikeName),
                BikeId = b.Bikes.Select(a => a.BikeNo)
            }).ToList();

            var resultOp = objPersonList.SelectMany(a => a.Bikes,(prs,bik)=>new { prs, bik })
                .Select(s => new {
                Name = s.prs.Name,
                Age=s.prs.Age,
                BikeName=s.bik.BikeName
            }).ToList();

            var resultOp1 = objPersonList.SelectMany(a => a.Bikes, (prs, bik) => new { prs, bik }).SelectMany(c => c.bik.Features, (frs,frs1) => new { frs, frs1 })
                .Select(s => new {
                    Name = s.frs.prs.Name,
                    Age = s.frs.prs.Age,
                    BikeName = s.frs.bik.BikeName,
                    Fe = s.frs1
                }).ToList();

            //var resultOpFeatures = objPersonList.SelectMany(a => a.Bikes)SelectMany(z=>z.Features, (prs, bik,frs) => new { prs, bik,frs })
            //    .Select(s => new {
            //        Name = s.prs.Name,
            //        Age = s.prs.Age,
            //        BikeName = s.bik.BikeName
            //    }).ToList();

            var resultQu = studentList.All(a => a.Age > 10 && a.Age < 30);
            var resulltAny = studentList.All(a => a.Age > 20);
            IList<Student> studentList1 = new List<Student>() {
        new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
        new Student() { StudentId= 2, StudentName = "Steve",  Age = 15 } ,
        new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
        new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
        new Student() { StudentId = 5, StudentName = "Ron" , Age = 19 }
    };

            Student std = new Student();
            std.StudentId = 3;
            std.StudentName = "Bill1";
            Student std1 = std;
            studentList1.Add(std1);
            bool result11 = studentList1.Contains(std); //returns false

            var commaResult = studentList1.Aggregate<Student, int>(0, (total, s) => total += s.Age);
            var resultName = studentList1.Aggregate<Student, string>("Student Name:", (name, s) => name += s.StudentName + ",");
            var rname = studentList1.Aggregate<Student, string, string>(String.Empty, (name, s) => name += s.StudentName + ",", name => name.Substring(0, name.Length - 1));

            var tempResult = studentList1.Max();

            var distnValue = stringList.Distinct();

            List<int> objNumberLIst = new List<int>() { 1, 3, 4, 65, 3, 2, 4 };
            var distNumber = objNumberLIst.Distinct();
            var distNumber1 = objNumberLIst.Distinct().ToList();

            Expression<Func<Student, bool>> isTeenAgeExp = s => s.Age > 12 && s.Age < 19;
            Expression<Action<Student>> printNameExp = s => Console.WriteLine(s.StudentName);

            Func<Student, bool> isTeenAge = isTeenAgeExp.Compile();
            bool result22 = isTeenAge(new Student() {StudentId=2,StudentName="Hello Name",Age=20 });

            Action<Student> printName = printNameExp.Compile();
            printName(new Student() { StudentId = 2, StudentName = "Hello Name", Age = 14 });

            var sumOfEvenElements = objNumberLIst.Sum(i => {
                        if (i % 2 == 0)
                            return i;

                        return 0;
                    });

            var resultOdd = objNumberLIst.Sum(k =>
            {
                if (k % 2 != 0)
                    return k;

                return 0;
            });
            IList<string> strList = new List<string>() { "one", "Two", "Three", "Four", "Five",null };
            var res1 = strList.FirstOrDefault();
            var res2 = strList.LastOrDefault();

            var re3 = strList.LastOrDefault();
            Console.ReadLine();




        }
    }

    public class StudentJoin
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int StandardID { get; set; }
        public int Age { get; set; }
    }

    public class Standard
    {
        public int StandardID { get; set; }
        public string StandardName { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Bike> Bikes { get; set; }
    }

    public class Bike
    {
        public int BikeNo { get; set; }
        public string BikeName { get; set; }
        public List<string> Features { get; set; }
        public Bike()
        {
            Features = new List<string>();
        }
    }
}
