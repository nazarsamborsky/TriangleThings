using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleThings
{
    class Triangle
    {
        private double _a;
        private double _b;
        private double _c;
        private double alpha;
        private double beta;
        private double gamma;

        public Triangle(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                _a = a;
                _b = b;
                _c = c;

            }
        }
        public Triangle(double strana)
        {
            if (strana > 0)
            {
                _a = strana;
                _b = strana;
                _c = strana;
            }
        }

        public double A
        {
            set { if(value > 0) _a = value;}
            get { return _a;}
        }

        public double B
        {
            set { if(value > 0) _b = value;}
            get { return _b;}
        }

        public double C
        {
            set { if(value > 0) _c = value;}
            get { return _c;}
        }

        public void SetSides(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                _a = a;
                _b = b;
                _c = c;

            }
        }

        public double GetArea()
        {

            double s = (_a + _b + _c) / 2;
            double result = Math.Sqrt(s * (s - _a) * (s - _b) * s * (s - _c)); //obsah vsech trojuhelniku
            result = Math.Round(result);
            return result;
        }

 
        public double GetOutline()
        {
            double result = _a + _b +_c; //obvod pro vsechny trojuhelniky
            return result;
        }
        public string IsExisting()
        {
            if (_a + _b > _c && _a + _c > _b && _b + _c > _a)
            {
                string result = "může";
                return result;
            }
            else
            {
                string result = "nemůže";
                return result;
            }
        }

        public static string CanExist(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                string result = "může";
                return result;
            }
            else
            {
                string result = "nemůže";
                return result;
            }
        }
        public double GetAlpha()
        {
            double s = (_a + _b + _c) / 2;
            double alpha = Math.Asin(2 * Math.Sqrt(s * (s - _a) * (s - _b) * (s - _c)) / (_b * _c)) * (180 / Math.PI);
            alpha = Math.Round(alpha);
            return alpha;
        }
        public double GetBeta()
        {
            double s = (_a + _b + _c) / 2;
            double beta = Math.Asin(2 * Math.Sqrt(s * (s - _a) * (s - _b) * (s - _c)) / (_a * _c)) * (180 / Math.PI);
            beta = Math.Round(beta);
            return beta;
        }
        public double GetGamma()
        {
            double s = (_a + _b + _c) / 2;
            double gamma = Math.Asin(2 * Math.Sqrt(s * (s - _a) * (s - _b) * (s - _c)) / (_a * _b)) * (180/Math.PI);
            gamma = Math.Round(gamma);
            return gamma;
        }
    }    
}



