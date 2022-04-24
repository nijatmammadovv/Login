using System;
using System.Collections.Generic;
using System.Text;

namespace Login.Models
{
    public class Group
    {
        public string GroupNo { get; set; }
        private int _StudentLimit;
        public int StudentLimit
        {
            get
            {
                return _StudentLimit;
            }
            set
            {
                if(value >=5 || value <=18)
                    _StudentLimit=value;
                else
                {
                    Console.WriteLine("Students limit is wrong!");
                }
            }
        }
        private Student[] _students = new Student[0];
        public Group(string groupNo,int studentLimit)
        {
            GroupNo=groupNo;
            StudentLimit=studentLimit;
        }

        public bool CheckGroupNo(string groupNo)
        {
            if (!string.IsNullOrEmpty(groupNo) && !string.IsNullOrWhiteSpace(groupNo) && groupNo.Length == 5)
            {
                int hasUpper = 0;
                int hasDigit = 0;

                for (int i = 0; i < groupNo.Length; i++)
                {
                    if (i < 2)
                    {
                        if (char.IsUpper(groupNo[i])) hasUpper++;
                    }
                    else if (hasUpper == 2 && i >= 2)
                    {
                        if (char.IsDigit(groupNo[i])) hasDigit++;
                    }
                    else
                    {
                        return false;
                    }
                    if (hasUpper == 2 && hasDigit == 3)
                        return true;
                }
            }
            return false;
        }
        public void AddStudent(Student student)
        {
            if(_students.Length <= StudentLimit)
            {
                Array.Resize(ref _students, _students.Length + 1);
                    _students[_students.Length-1] = student;
            }
            else
            {
                throw new Exception();
            }
              
           
        }
        public Student Getstudent(int ? id)
        {
            if (id != null)
            {
                Console.WriteLine("Yalnis melumat.");
            }
                foreach (Student student in _students)
                {
                    if (student.Id == id)
                        return student;
                }  
                return null;
            }
        }
        public Student [] GetallStudents()
        {
            return _students;
        }
    }
}
