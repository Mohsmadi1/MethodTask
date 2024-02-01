namespace MethodTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new array
            int[] array = new int[12] { 8, 2, 3, 4, 5, 1, 6, 7, 8, 1, 9, 10 };
            //Call function ArrayCheck and we will print the numbers without the duplicate 
            //number and put them in a new array
            ArrayCheck(array);
            Console.WriteLine(" ");
            //Call function ArraySort and  We arrange the array in ascending order
            ArraySort(array);
            Console.WriteLine(" ");
            //Call function EvenNumber and we print the even number only
            EvenNumber(array);
            Console.WriteLine(" ");
            //Call function OddNumber and we print the Odd number only
            OddNumber(array);
        }
        static void ArrayCheck(int[] array)
        {


            int[] array2 = new int[array.Length];

            bool Checkk = true;

            for (int i = 0; i < array.Length; i++)
            {

                for (int j = 0; j < array2.Length; j++)
                {
                    if (array2[j] == array[i])
                    {
                        Checkk = false;
                    }
                }

                if (Checkk == true)
                {
                    array2[i] = array[i];
                    Console.WriteLine(array2[i]);
                }
                Checkk = true;
            }
        }
        static void ArraySort(int[] array)
        {
            int swap;
            for (int i = 0; i < array.Length - 1; i++)
            {

                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        swap = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = swap;
                    }
                }
            }
            foreach (int arrayy in array)
            {
                Console.WriteLine(arrayy + " ");
            }
        }
        static void EvenNumber(int[] array)
        {
            bool Check = true;
            for (int i = 0; i < array.Length; i++)
            {
                int numberCheck = array[i] / 2;
                int numberCheck2 = numberCheck * 2;
                if (numberCheck2 != array[i])
                {
                    Check = false;
                }
                else if (Check = true)
                {
                    Console.WriteLine(array[i] + " ");
                }
            }
        }
        static void OddNumber(int[] array)
        {
            bool Check = true;
            for (int i = 0; i < array.Length; i++)
            {
                int numberCheck = array[i] / 2;
                int numberCheck2 = numberCheck * 2;
                if (numberCheck2 == array[i])
                {
                    Check = false;
                }
                else if (Check = true)
                {
                    Console.WriteLine(array[i] + " ");
                }
            }
        }
    }
}