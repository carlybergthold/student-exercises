using System;
using System.Collections.Generic;

namespace studentExercises
{
    class Cohort
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Students { get; set; }
        public List<string> Instructors { get; set; }
    }
}