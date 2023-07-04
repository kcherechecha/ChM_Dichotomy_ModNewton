using System;

namespace DichotomyChmLab
{
    public class ModifiedNewtonMethod
    {
        static double Expression(double x)
        {
            return Math.Pow(x, 5) - 5 * x + 2;
        }
        static double ExpressionDerivative(double x)
        {
            return 5 * Math.Pow(x, 4) - 5;
        }
        public void NewtonModified()
        {
            double a = -2;
            double b = -1.25;
            double eps = 1e-6;
            double x = a;
            double denominator = ExpressionDerivative(a);
            int i = 1;
            Console.WriteLine("\n\nModified Newton's Method\nInterval: ["+a+"; "+b+"]\n");
            Console.WriteLine("Iteration 1: x= "+x+" f(x)="+Expression(x));
            while(Math.Abs(Expression(x)) > eps)
            {
                x -= Expression(x) / denominator;
                Console.WriteLine("Iteration " +(i + 1)+": x= "+x+" f(x)= "+Expression(x));
                i++;
            }
            Console.WriteLine("\nThe root on the interval: "+ x+"\n");
        }

        public void NewtonModifiedByIterations()
        {
            double a = -2;
            double b = -1.25;
            double x = a;
            double denominator = ExpressionDerivative(a);
            Console.WriteLine("Iteration 1: x= "+x+" f(x)="+Expression(x));
            for (int i = 2; i <= 19; i++)
            {
                x -= Expression(x) / denominator;
                Console.WriteLine("Iteration " +(i + 1)+": x= "+x+" f(x)= "+Expression(x));
            }
        }
    }
}