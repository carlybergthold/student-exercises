using System;
using System.Collections.Generic;

namespace studentExercises
{
    public class Student : NSSPerson
    {
        public List<Exercise> Exercises = new List<Exercise>();
        public void AddEx(Exercise ex) {
            Exercises.Add(ex);
        }
        public void AddNewEx(string name, string language) {
            var ex = new Exercise(name, language);
            Exercises.Add(ex);
        }
    }
}