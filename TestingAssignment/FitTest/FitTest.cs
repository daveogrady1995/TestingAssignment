using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingAssignment;

namespace FitTest
{
    public class FitTest : fit.ColumnFixture
    {
        public CalculatePremium cp = new CalculatePremium();

        public string gender;
        public int age;

        public double CalculatePremium()
        {
            return cp.CalcPremium(age, gender);
        }

    }
}
