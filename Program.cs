using System;
using System.Collections.Generic;
using System.Linq;

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
            var Cohort32 = new Cohort() { Name = "Day Cohort 32", Number = 32 };
            var Cohort33 = new Cohort() { Name = "Day Cohort 33", Number = 33 };
            var Cohort34 = new Cohort() { Name = "Day Cohort 34", Number = 34 };

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
            var Dummy = new Student()
            {
                FirstName = "Dummy",
                LastName = "Yummy",
                SlackHandle = "Dummerthendirt",
                Cohort = 33
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
            Adam.AssignEx(AspSprint, Carly);
            Adam.AssignNewEx("C#", "C#", Carly);
            Jisie.AssignEx(AspSprint, Jake);
            Jisie.AssignNewEx("C#", "C#", Jake);
            Steve.AssignEx(Nutshell, Sydney);
            Steve.AssignNewEx("Grunt", "HTML", Sydney);
            Bryan.AssignEx(CelebrityTribute, Jacquelyn);
            Bryan.AssignNewEx("Flexbox", "CSS", Jacquelyn);

            // Create a list of students, intructors, cohorts, and exercises
            List<Student> students = new List<Student>();
            students.AddRange(new[] {Carly, Jake, Sydney, Jacquelyn, Dummy});

            List<Instructor> instructors = new List<Instructor>();
            instructors.AddRange(new[] {Adam, Bryan, Jisie, Steve});

            List<Cohort> cohorts = new List<Cohort>();
            cohorts.AddRange(new[] {Cohort32, Cohort33, Cohort34});

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

            // List exercises for the JavaScript language by using the Where() LINQ method.
            IEnumerable<Exercise> JSExercises = from exs in exercises
                where exs.Language == "JavaScript"
                select exs;

            // List students in a particular cohort by using the Where() LINQ method.
            IEnumerable<Student> Cohort32Students = from stu in students
                where stu.Cohort == 32
                select stu;

            // List instructors in a particular cohort by using the Where() LINQ method.
            IEnumerable<Instructor> Cohort32Instructors = instructors.Where(inst => inst.Cohort == 32);

            // Sort the students by their last name.
            IEnumerable<Student> stusByName = students.OrderBy(stu => stu.LastName);

            // Display any students that aren't working on any exercises (Make sure one of your student instances don't have any exercises. Create a new student if you need to.)
            IEnumerable<Student> noExs = students.Where(stu => stu.Exercises.Count == 0);

            // // How many students in each cohort?
            var group = cohorts.GroupJoin(students,
                m => m.Number,
                s => s.Cohort,
                (m, s) => new Result (m.Number, s));

            foreach (var result in group)
            {
                var stusInCohort = new List<string>();
                foreach (var p in result.s)
                {
                    stusInCohort.Add(p.FirstName);
                }
                Console.WriteLine($"Cohort {result.Cohort} has {stusInCohort.Count} students.");
            }
        }
    }
}
