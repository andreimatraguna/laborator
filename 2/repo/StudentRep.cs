using System.Collections.Generic;
using _2.Models;

namespace _2.repo
{
    public static class StudentRep
    {
        public static List<Student> Students = new List<Student>()
        {
            new Student() {Id=1,Facultate="aa",Nume="Andrei",An=4},
            new Student() {Id=2,Facultate="AA",Nume="AVVVx",An=3},
            new Student() {Id=3,Facultate="CASA",Nume="AAA",An=2}
        };
    }
}