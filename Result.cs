using System.Collections.Generic;

namespace studentExercises
{
    public class Result
    {
        public int Cohort;
        public IEnumerable<Student> s;

        public Result(int num, IEnumerable<Student> s)
        {
            this.Cohort = num;
            this.s = s;
        }
    }
}