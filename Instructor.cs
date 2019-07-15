using System;

namespace studentExercises
{
    public class Instructor : NSSPerson
    {
        public string Speciality { get; set; }
        public void AssignEx(Exercise ex, Student stu) {
            stu.AddEx(ex);
        }
        public void AssignNewEx(string name, string language, Student stu) {
            stu.AddNewEx(name, language);
        }
    }
}