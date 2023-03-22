using System;
using System.Collections.Generic;

namespace DependencyInjection
{

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Standard { get; set; }
    }

    interface IStudentDataAccess
    {
        List<Student> GetStudents();
    }


    class StudentDataAccessLayerSQLDB : IStudentDataAccess
    {
        public List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student(){Id = 1,Name ="Tushar", Standard= "12th" },
                new Student(){Id = 2,Name ="Hrithik", Standard= "11th" },
                new Student(){Id = 3,Name ="Sharukh", Standard= "12th" },
            };
        }
    }


    class StudentDataAccessLayerOracle : IStudentDataAccess
    {
        public List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student(){Id = 41,Name ="ABC", Standard= "12th" },
                new Student(){Id = 24,Name ="XYZ", Standard= "11th" },
                new Student(){Id = 34,Name ="MNO", Standard= "12th" },
            };
        }
    }

    /// <summary>
    /// BL
    /// </summary>
    class StudentBuisnessLayer
    {
        // private IStudentDataAccess _studentdataaccess;

        //public IStudentDataAccess StudentData
        //{
        //    get
        //    {
        //        if (_studentdataaccess == null)
        //        {
        //            throw new Exception("Object not passed to property");
        //        }
        //        else
        //        {
        //            return _studentdataaccess;
        //        }
        //    }
        //    set
        //    {
        //        _studentdataaccess = value;
        //    }
        //}


        //public StudentBuisnessLayer(IStudentDataAccess studentDataAccess)
        //{
        //    _studentdataaccess = studentDataAccess;
        //}

        public List<Student> GetStudents(IStudentDataAccess studentDataAccess)
        {
            return studentDataAccess.GetStudents();
        }

        public string GetDayInWeekOrMonthInAYear(int num, bool IsDay)
        {
            if (IsDay)
            {
                switch (num)
                {
                    case 1:
                        return "Monday";
                    case 2:
                        return "Tue";
                    case 3:
                        return "wed";
                    case 4:
                        return "thr";
                    case 5:
                        return "fri";
                    case 6:
                        return "sat";
                    case 7:
                        return "sun";
                    default:
                        throw new Exception("day must be in 1-7");
                }
            }
            else
            {
                switch (num)
                {
                    case 1:
                        return "JAn";
                    case 2:
                        return "Feb";

                    default:
                        throw new Exception("day must be in 1-7");
                }
            }

        }
        public string GetDayInWeek2(int day)
        {

            if (day < 1 || day > 7)
            {
                throw new Exception("day must be 1-7");
            }

            string[] days =
                {
                    "Mon",
                    "Tue",
                    "Wed",
                    "Thr",
                    "Fri",
                    "Sat",
                    "Sun"
                };
            return days[day - 1];
        }

    }



    /// <summary>
    /// Client
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            StudentBuisnessLayer students = new StudentBuisnessLayer();
            // students.StudentData = new StudentDataAccessLayerOracle();

            var result1 = students.GetStudents(new StudentDataAccessLayerSQLDB());

            var result = students.GetDayInWeekOrMonthInAYear(5, false);

            Console.WriteLine("Hello World!");
        }
    }
}
