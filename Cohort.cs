using System;
using System.Collections.Generic;

namespace studentExercises
{
    public class Cohort
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public List<Student> Students = new List<Student>();
        public List<Instructor> Instructors = new List<Instructor>();
    }
}