using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRemote.Entities
{
    internal class Student
    {

        public int IdStudent { get; set; }

        public Student(int idStudent)
        {
            IdStudent = idStudent;
        }


        public override int GetHashCode()
        {
            return IdStudent.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is Student))
            {
                return false;
            }

            Student other = obj as Student;

            return IdStudent.Equals(other.IdStudent);

        }



    }
}
