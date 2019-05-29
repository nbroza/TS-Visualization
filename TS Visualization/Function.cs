using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
x^2
e^x
sin(x)
cos(x)
ln(1+x)
*/

namespace TS_Visualization
{
    public abstract class Function
    {
        public abstract float eval(float x);
        public abstract float teval(float x, int terms);

        public virtual double factorial(int n)
        {
            if (n == 1 || n == 0)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }
    }

    public class Polynomial : Function
    {
        public override float eval(float x)
        {
            float y = x * x;
            return y;
        }

        public override float teval(float x, int terms)
        {
            float y = 0;

            if (terms == 0)
            {
                y = 1;
            }
            else if (terms == 1)
            {
                y = 1 + 2 * (x - 1);
            }
            else if (terms > 1)
            {
                y = x * x;
            }
            return y;
        }
    }

    public class Exponential : Function
    {
        public override float eval(float x)
        {
            float y = (float) Math.Pow(Math.E, x);
            return y;
        }

        public override float teval(float x, int terms)
        {
            float y = 0;
            for (int i = 0; i <= terms; i++)
            {
                y += (float)(Math.Pow(x, i) / factorial(i));
            }
            return y;
        }
    }

    public class Sin : Function
    {
        public override float eval(float x)
        {
            float y = (float) Math.Sin(x);
            return y;
        }

        public override float teval(float x, int terms)
        {
            terms -= 1;
            float y = 0;
            for (int i = 0; i <= terms; i++)
            {
                y += (float) ( (-1) * ((Math.Pow(-1, i + 1) * Math.Pow(x, 2 * i + 1))/factorial(2 * i + 1)));
            }
            return y;
        }
    }

    public class Cos : Function
    {
        public override float eval(float x)
        {
            float y = (float)Math.Cos(x);
            return y;
        }

        public override float teval(float x, int terms)
        {
            float y = 0;
            for (int i = 0; i <= terms; i++)
            {
                y += (float)((-1) * ((Math.Pow(-1, i + 1) * Math.Pow(x, 2 * i)) / factorial(2 * i)));
            }
            return y;
        }
    }

    public class Ln : Function
    {
        public override float eval(float x)
        {
            float y = (float)Math.Log(1 + x);
            return y;
        }

        public override float teval(float x, int terms)
        {
            terms -= 1;
            float y = 0;
            for (int i = 0; i <= terms; i++)
            {
                y += (float) ((-1) * (Math.Pow(-1, i + 1) * Math.Pow(x, i + 1)) / (i + 1));
            }
            return y;
        }
    }
}
