using System;
using System.Globalization;

namespace Vetores_ExercicioFixacao
{
    internal class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }   
        
        public Student(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}
