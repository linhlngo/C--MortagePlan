using NUnit.Framework;
using MortgagePlan;

namespace MortgagePlan.Tests
{
    [TestFixture]
    public class MortgagePlanTests
    {
        [TestCase("Karvinen", 4356, 1.27, 6, 63.87)]
        [TestCase("Claes Månsson", 1300.55, 8.67, 2, 59.22)]
        public void MonthlyPayment_ReturnsCorrectMonthlyPayment(string customerName, double totalLoan, double yearlyInterestRate, int numberOfYears, double expectedResult)
        {
            var mortgagePlan = new MortgagePlan_
            {
                CustomerName = customerName,
                TotalLoan = totalLoan,
                YearlyInterestRate = yearlyInterestRate,
                NumberOfYears = numberOfYears
            };

            double result = mortgagePlan.MonthlyPayment();
            Assert.That(result, Is.EqualTo(expectedResult).Within(0.01));
        }
    }
}
