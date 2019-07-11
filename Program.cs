using System;
using System.Collections.Generic;

namespace studentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 4, or more, exercises.
            var CelebrityTribute = new Exercise()
            {
                Name = "Celebrity Tribute",
                Language = "CSS"
            };
            var Nutshell = new Exercise()
            {
                Name = "Nutshell",
                Language = "JavaScript"
            };
            var Databases = new Exercise()
            {
                Name = "Database Basics",
                Language = "C#"
            };
            var AspSprint = new Exercise()
            {
                Name = "ASP .NET Sprint",
                Language = "C#"
            };

            // // Create 3, or more, cohorts.
            var Cohort32 = new Cohort() { Name = "Day Cohort 32" };
            var Cohort33 = new Cohort() { Name = "Day Cohort 33" };
            var Cohort34 = new Cohort() { Name = "Day Cohort 34" };

            // // Create 4, or more, students and assign them to one of the cohorts.
            var Carly = new Student()
            {
                FirstName = "Carly",
                LastName = "Bergthold",
                SlackHandle = "carlybergthold",
                Cohort = 32
            };
            var Jake = new Student()
            {
                FirstName = "Jake",
                LastName = "Preston",
                SlackHandle = "jakepreston",
                Cohort = 32
            };
            var Sydney = new Student()
            {
                FirstName = "Sydney",
                LastName = "Noh",
                SlackHandle = "sydneynoh",
                Cohort = 33
            };
            var Jacquelyn = new Student()
            {
                FirstName = "Jacquelyn",
                LastName = "McCray",
                SlackHandle = "jacquelynmccray",
                Cohort = 34
            };

            // // Create 3, or more, instructors and assign them to one of the cohorts.
            var Adam = new Instructor()
            {
                FirstName = "Adam",
                LastName = "Sheaffer",
                SlackHandle = "adamsheaffer",
                Cohort = 32,
                Speciality = "Dumping on Joel"
            };
            var Bryan = new Instructor()
            {
                FirstName = "Bryan",
                LastName = "Nilsen",
                SlackHandle = "bryannilsen",
                Cohort = 34,
                Speciality = "High fiving"
            };
            var Jisie = new Instructor()
            {
                FirstName = "Jisie",
                LastName = "David",
                SlackHandle = "jisiedavid",
                Cohort = 32,
                Speciality = "Explaining complicated things simply"
            };
            var Steve = new Instructor()
            {
                FirstName = "Steve",
                LastName = "Brownlee",
                SlackHandle = "stevenbrownlee",
                Cohort = 33,
                Speciality = "Complaining about people being quiet on presentation day"
            };

            // // Have each instructor assign 2 exercises to each of the students.
            Adam.AssignEx(Databases, Carly);
            Adam.AssignNewEx("C#", "C#", Carly);
            Jisie.AssignEx(AspSprint, Jake);
            Jisie.AssignNewEx("C#", "C#", Jake);
            Steve.AssignEx(Nutshell, Sydney);
            Steve.AssignNewEx("Grunt", "HTML", Sydney);
            Bryan.AssignEx(CelebrityTribute, Jacquelyn);
            Bryan.AssignNewEx("Flexbox", "CSS", Jacquelyn);

            // Create a list of students. Add all of the student instances to it.
            List<Student> students = new List<Student>();
            students.AddRange(new[] {Carly, Jake, Sydney, Jacquelyn});

            // Create a list of exercises. Add all of the exercise instances to it.
            List<Exercise> exercises = new List<Exercise>();
            exercises.AddRange(new[] {CelebrityTribute, Nutshell, AspSprint, Databases});

            // Generate a report that displays which students are working on which exercises.
            foreach (var student in students)
            {
                var stuExercises = new List<string>();
                foreach (var ex in student.Exercises)
                {
                stuExercises.Add(ex.Name);
                }
                string[] exArray = stuExercises.ToArray();
                var exs = string.Join(" and ", exArray);
                Console.WriteLine($"{student.FirstName} is working on {exs}");
            }
        }
    }
}
