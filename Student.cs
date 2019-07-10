using System;
using System.Collections.Generic;

namespace studentExercises
{
    class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public int Cohort { get; set; }
        public int CohortId { get; set; }
        public List<string> StudentExcercises { get; set; }
    }
}