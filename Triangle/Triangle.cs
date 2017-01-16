using System;

namespace Triangle
{
    public class Triangle
    {
        private double a;
        private double b;
        private double c;
        private string type;

        public double A
        {
            get { return this.a; }
            set { this.a = value; }
        }

        public double B
        {
            get { return this.b; }
            set { this.b = value; }
        }

        public double C
        {
            get { return this.c; }
            set { this.c = value; }
        }

        public string Type
        {
            get { return this.type; }
        }

        public Triangle()
        {
        }

        public Triangle(double a, double b, double c)
        {
            Boolean result1 = a > 0 && b > 0 && c > 0;
            Boolean result2 = a + b > c && a + c > b && b + c > a;
            Boolean result3 = Math.Abs(a - b) < c && Math.Abs(a - c) < b &&
                              Math.Abs(b - c) < a;
            if (result1 && result2 && result3)
            {
                this.a = a;
                this.b = b;
                this.c = c;
                if (a == b || a == c || b == c)
                {
                    if (a == b && b == c)
                    {
                        type="equilateral";
                    }
                    else
                    {
                        type="isosceles";
                    }

                }
                else
                {
                    type="scalene";
                }
            }
            else
            {
                //throw new Exception("Wrong data format,or the figure input can't form a triangle!");
                type = "not a triangle";

            }
        }

        public override string ToString()
        {
            string result;
            if (a == 0 | b == 0 | c == 0)
                result = "It's not a triangle";
            else
                result= "The three sides are : " + a.ToString() + " , " + b.ToString() + " , " + c.ToString() + "\n" + "The type is " + type.ToString();
            return result;
        }
    }
}
