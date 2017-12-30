using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewCakeUnitTests
{
    [TestClass]
    public class GroupOneTrading
    {
        [TestMethod]
        public void TestMethod2()
        {
            int[] A = { 1, 4, -1, 3, 2 };
            int count = -1;
            int index = 0;

            while (index != -1)
            {
                count++;
                index = A[index];
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == i)
                    count++;
            }
            //return count;
        }

        [TestMethod]
        public void TestMethod3()
        {
            int output = 0;

            int A = 4;
            int B = 17;


            if (B <= 0)
                output = 0;//return 0;

            int posA = Math.Abs(A);
            int index = 2;
            double squaredValue = 0;

            while (squaredValue < B)
            {
                squaredValue = Math.Pow(index, 2);
                if (squaredValue >= A && squaredValue <= B )
                {
                    output++;
                }

                if (squaredValue >= Math.Sqrt(int.MaxValue) - 1)
                {
                    break;
                }

                index++;
            }

            Console.WriteLine(output);

        }


        [TestMethod]
        public void Test4()
        {
            int a = 11;
            int b = 3;
            Console.WriteLine(a % b);


            string S = "00-44  48 5555 8361";

            string formattedS = S.Replace("-", "");
            formattedS = formattedS.Replace(" ", "");
            Console.WriteLine(formattedS);

            int remainder = formattedS.Length % 3;
            int twoGroups = 0;

            if (remainder == 1)
            {
                twoGroups = 2;
            }
            else if (remainder == 2)
            {
                twoGroups = 1;
            }
            Console.WriteLine(twoGroups);
            string outputS = "";
            int count = 0;
            int threeDigitLength = formattedS.Length - (twoGroups * 2);


            for (int i = 0; i < threeDigitLength; i++)
            {
                if (count == 3)
                {
                    outputS += "-";
                    count = 0;
                    i--;
                    continue;
                }
                else
                {
                    outputS += formattedS[i];
                    count++;
                }
            }

            count = 0;
            if (threeDigitLength != formattedS.Length)
                outputS += "-";

            for (int i = threeDigitLength; i < formattedS.Length; i++)
            {
                if (count == 2 && twoGroups == 2)
                {
                    outputS += "-";
                    count = 0;
                    continue;
                }
                else
                {
                    outputS += formattedS[i];
                    count++;
                }
            }

            Console.WriteLine(outputS);


        }





   }
}
