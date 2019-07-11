using System;

namespace studentExercises
{
    public class Exercise
    {
        public string Name { get; set; }
        public string Language { get; set; }
        public Exercise()
        {

        }
        public Exercise(string name, string language)
        {
            Name = name;
            Language = language;
        }
    }
}