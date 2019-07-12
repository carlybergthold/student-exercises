using System;
using System.Collections.Generic;

namespace studentExercises
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public int Cohort { get; set; }
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