using System;

namespace studentExercises
{
    class Instructor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public int Cohort { get; set; }
        public int CohortId { get; set; }
        public string Speciality { get; set; }
        public void AssignExercise(int student, int exercise) {
            // A method to assign an exercise to a student
            Console.WriteLine($"Assign to {student}");
        }
    }
}