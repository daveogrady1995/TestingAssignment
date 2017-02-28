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
        public PremiumCalculator cp = new PremiumCalculator();

        public string gender;
        public int age;

        public double CalculatePremium()
        {
            return cp.CalcPremium(age, gender);
        }

    }
}
