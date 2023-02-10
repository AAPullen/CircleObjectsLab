using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjectsLab
{
    public class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public static double CalculateCircumference(Circle userCircle)
        {

            double userCircumference = 2 * Math.PI * userCircle.radius;
            userCircumference = Math.Round(userCircumference, 2);
            return userCircumference;
        }

        public static double CalculateArea(Circle userCircle)
        {
            double userArea = Math.PI * (Math.Pow(userCircle.radius, 2));
            userArea = Math.Round(userArea, 2);
            return userArea;
        }

        public static string CalculateFormattedCircumference(double userCircumference)
        {
            string circumferenceString = userCircumference.ToString();
            return circumferenceString;
        }

        public static string CalculateFormattedArea(double userArea)
        {
            string areaString = userArea.ToString();
            return areaString;
        }

        // The following methods demonstrate ways to access or manipulate private methods and variables

        private static string FormatNumber(double x)
        {
            string xString = x.ToString();
            return xString;
        }

        public static string PublicFormatNunmber(double x)
        {
            string xString = FormatNumber(x);
            return xString;
        }

        public static Circle ChangeRadius(Circle userCircle, double newRadius)
        {
            userCircle.radius = newRadius;
            return userCircle;
        }

        public static string PrintRadius(Circle userCircle)
        {

            return userCircle.radius.ToString();
        }

    }
}
