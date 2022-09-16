using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumericallyThenAlphabetically
{
    public class RandomGenerator
    {
        private Random generator = new Random();

        public List<CallNumbers> lstRandomCallNumbers = new List<CallNumbers>();
        public List<CallNumbers> lstSortedCallNumbers = new List<CallNumbers>();

        // ----------- CODE ATTRIBUTION ----------
        // url:     https://www.softwaretestinghelp.com/csharp-random-number/#How_To_Generate_Random_Alphabets
        // date accessed: 21 August 2022
        // Generating Random Numbers and Letters

        // Methods to generate a single random call number
        public double generateRandomNumbers()
        {
            // Creating an instance of the RandomGenerator class

            // Generating the three numbers before the decimal point
            int firstThree = generator.Next(0, 1000);
            double secondTwo = generator.Next(1, 100);

            return firstThree + (secondTwo / 100);
        }

        public string generateRandomLetters()
        {
            // Generating the three letters of the call number
            string threeLetters = "";
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            for (int x = 0; x < 3; x++)
            {
                int random = generator.Next(26);
                threeLetters += alphabet.ElementAt(random);
            }

            return threeLetters.ToUpper();
        }

        // ---------- END OF CODE ATTRIBUTION ----------

        // Method to generate a list of random call numbers
        public List<CallNumbers> generateListOfCallNumbers()
        {
            lstRandomCallNumbers.Clear();
            for (int x = 0; x < 10; x++)
            {
                double numbers = generateRandomNumbers();
                string letters = generateRandomLetters();

                CallNumbers callNumber = new CallNumbers(numbers, letters);

                lstRandomCallNumbers.Add(callNumber);
            }

            return lstRandomCallNumbers;
        }

        // Method to sort the randomly generated list
        public List<CallNumbers> sortRandomList()
        {
            double[] arrNumbers = new double[10];
            string[] arrLetters = new string[10];

            arrNumbers.DefaultIfEmpty();
            arrLetters.DefaultIfEmpty();
            int counter = 0;

            foreach (CallNumbers read in lstRandomCallNumbers)
            {
                arrNumbers[counter] = read.CallNumber;
                arrLetters[counter] = read.CallLetter;
                counter++;
            }

            int i, j;
            int arrLength = arrNumbers.Length;

            // Sorting the arrays from lowest to highest
            // ****** CODE ATTRIBUTION *****
            // Website: x3resource
            // Last Updated: 19 August 2022
            // Title: Sort elements of arrat in ascending order
            // URL: https://www.w3resource.com/csharp-exercises/array/csharp-array-exercise-11.php
            for (i = 0; i < 10; i++)
            {
                for (j = i + 1; j < 10; j++)
                {
                    if (arrNumbers[j] < arrNumbers[i])
                    {
                        // Rearraning the call numbers
                        double dTemp = arrNumbers[i];
                        arrNumbers[i] = arrNumbers[j];
                        arrNumbers[j] = dTemp;

                        // Rearranging the call letters
                        string sTemp = arrLetters[i];
                        arrLetters[i] = arrLetters[j];
                        arrLetters[j] = sTemp;
                    }
                }
            }
            // ****** END OF CODE ATTRIBUTION *****


            for(i = 0; i < 10;i++)
            {
                for (j = 1; j < 10; j++)
                {
                    if (arrNumbers[i] == arrNumbers[j])
                    {
                        char[] char1 = arrLetters[i].ToCharArray();
                        char[] char2 = arrLetters[j].ToCharArray();
                        for (int x = 0; x < 3; x++)
                        {
                            if (char2[x] > char1[x])
                            {
                                // Rearraning the call numbers
                                double dTemp = arrNumbers[i];
                                arrNumbers[i] = arrNumbers[j];
                                arrNumbers[j] = dTemp;

                                // Rearranging the call letters
                                string sTemp = arrLetters[i];
                                arrLetters[i] = arrLetters[j];
                                arrLetters[j] = sTemp;
                                break;
                            }
                        }
                    }
                    
                }
            }

            // Writing the sorted array to a new list
            for (int x = 0; x < 10; x++)
            {
                CallNumbers call = new CallNumbers(arrNumbers[x], arrLetters[x]);
                lstSortedCallNumbers.Add(call);
            }

            return lstSortedCallNumbers;
        }


        public List<CallNumbers> testMethod()
        {
            CallNumbers c5 = new CallNumbers(21.74, "PQN");
            CallNumbers c1 = new CallNumbers(62.58, "HDQ");
            CallNumbers c6 = new CallNumbers(100.37, "OUU");
            CallNumbers c2 = new CallNumbers(195.68, "SSQ");
            CallNumbers c9 = new CallNumbers(211.36, "BQF");
            CallNumbers c3 = new CallNumbers(211.36, "BCF");
            CallNumbers c7 = new CallNumbers(283.96, "HBB");
            CallNumbers c4 = new CallNumbers(396.41, "OLQ");
            CallNumbers c10 = new CallNumbers(440.12, "YXP");
            CallNumbers c8 = new CallNumbers(440.12, "YTO");

            lstRandomCallNumbers.Clear();

            lstRandomCallNumbers.Add(c1);
            lstRandomCallNumbers.Add(c2);
            lstRandomCallNumbers.Add(c3);
            lstRandomCallNumbers.Add(c4);
            lstRandomCallNumbers.Add(c5);
            lstRandomCallNumbers.Add(c6);
            lstRandomCallNumbers.Add(c7);
            lstRandomCallNumbers.Add(c8);
            lstRandomCallNumbers.Add(c9);
            lstRandomCallNumbers.Add(c10);

            return lstRandomCallNumbers;
        }
    }
}
