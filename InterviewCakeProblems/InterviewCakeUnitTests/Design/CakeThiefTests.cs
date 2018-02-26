using System;
using InterviewCakeProblems.Design;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewCakeUnitTests.Design
{
    [TestClass]
    public class CakeThiefTests
    {
        [TestMethod]
        public void CakeThief_MaxDuffelBagValue_ExampleProblem()
        {
            CakeType[] cakeTypes = new[]
            {
                new CakeType(7, 160),
                new CakeType(3, 90),
                new CakeType(2, 15),
            };

            int capacity = 20;

            var cakeThief = new CakeThief();

            // Returns 555 (6 of the middle type of cake and 1 of the last type of cake)
            var result = cakeThief.MaxDuffelBagValue(cakeTypes, capacity);

            Assert.AreEqual(555, result);
        }
    }
}
