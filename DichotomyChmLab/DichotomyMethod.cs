using System;

namespace DichotomyChmLab
{
    public class DichotomyMethod
    {
        static double Expression(double x)
        {
            return Math.Pow(x,5)-5*x+2;
        }
        public void Dichotomy()
        {
            double a = -2;
            double b = -1;
            double eps = 1e-6; 
            int i = 1; 
            double iterationQuantity = Math.Truncate(Math.Log((b-a)/eps, 2)) + 1;
            
            Console.WriteLine("Dichotomy Method\nInterval: ["+a+"; "+b+"]\nMinimum iterations quantity needed to find the root: "+iterationQuantity+"\n");
            
            while (Math.Abs(b - a) > eps) 
            { 
                double c = (a + b) / 2; 
                if (Expression(a) * Expression(c) < 0) 
                { 
                    b = c; 
                }
                else 
                { 
                    a = c; 
                } 
                Console.WriteLine("Iteration "+i+": x= "+c+"  f(x)= "+Expression(c)); 
                i++; 
            } 
            Console.WriteLine("\nThe root on the interval: "+a+"\n");
        }

        public void DichotomyByIterations()
        {
            double a = -2;
            double b = -1;
            Console.WriteLine("\n20 iterations for Dichotomy Method\n");
            for (int i = 1; i <= 20; i++)
            {
                double c = (a + b) / 2; 
                if (Expression(a) * Expression(c) < 0) 
                { 
                    b = c; 
                }
                else 
                { 
                    a = c; 
                } 
                Console.WriteLine("Iteration "+i+": x= "+c+"  f(x)= "+Expression(c));
            }
        }
    }
}