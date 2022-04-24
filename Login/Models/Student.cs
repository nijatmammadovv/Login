using System;
using System.Collections.Generic;
using System.Text;

namespace Login.Models
{
    public class Student
    {
        private static int _id;
        public int Id { get; }
        public Student()
        {
            _id++;
            Id=_id;
        }
        private string _Fullname;
        public string Fullname
        {
            get
            {
                return _Fullname ;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    _Fullname = value;
                else
                {
                    Console.WriteLine("Fullname is wrong!");
                }
            }
        }
        private int _Point;
        public int Point
        {
            get
            {
                return _Point;
            }
            set
            {
                if(value > 0)
                    _Point = value;
                else
                {
                    Console.WriteLine("Point is not negative!");
                }
            }
        }
        public Student(string fullname,int point)
        {
            Fullname = fullname;
            Point = point;
        }
        public void StudentInfo()
        {
            Console.WriteLine($"Id ==> {Id} Full naME ==> {Fullname} Point ==> {Point}");
        }
    }
}
