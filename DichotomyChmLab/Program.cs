using System;

namespace DichotomyChmLab
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Equasion: x^5 - 5x + 2 = 0\n");
            var dichotomyView = new DichotomyMethod();
            dichotomyView.Dichotomy();
            dichotomyView.DichotomyByIterations();

            var newtonMethodView = new ModifiedNewtonMethod();
            newtonMethodView.NewtonModified();
            newtonMethodView.NewtonModifiedByIterations();
        }
    }
}