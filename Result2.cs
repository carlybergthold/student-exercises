using System.Collections.Generic;

namespace studentExercises
{
    public class Result2
    {
        public string name;

        public IEnumerable<Exercise> s;

        public Result2(string name, IEnumerable<Exercise> s)
        {
            this.name = name;
            this.s = s;
        }
    }
}