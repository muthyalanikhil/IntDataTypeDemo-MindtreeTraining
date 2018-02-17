using System;

namespace IntDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Enter the first number");
            string number1 = Console.ReadLine();
            Console.WriteLine("Enter the second number");
            string number2 = Console.ReadLine();
            if (number1.Length > number2.Length)
                n = number1.Length;
            else
                n = number2.Length;
            int[] array3 = new int[n];
            int[] array2 = new int[n];
            int[] array1 = new int[n];
            for (int t = 0; t < number1.Length; t++)
                array1[t] = number1[t] - 48;

            for (int t = 0; t < number2.Length; t++)
                array2[t] = number2[t] - 48;

            Array.Reverse(array1);

            Array.Reverse(array2);

            if (n > number1.Length)                                                                    //To make empty memory locations of the array to 0 and avoid garbage values
                for (int k = number1.Length+1 ; k < n; k++)
                    array1[k] = 0;

            Console.WriteLine("Your first number is a {0} digit number", number1.Length);


            if (n > number2.Length)
                for (int k = number2.Length+1; k < n; k++)
                    array2[k] = 0;
            Console.WriteLine("Your second number is a {0} digit number", number2.Length);

           
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array1[i]);
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array2[i]);
            }
           

            Console.WriteLine("Enter the operator you want to use");
            int choice = Convert.ToChar(Console.ReadLine());
            switch (choice)
            {
                case '+':
                    {
                        for (int t = 0; t < n; t++)
                        {
                            if ((array1[t] + array2[t] <= 9))
                            {
                                array3[t] = array1[t] + array2[t];                  //To handle carry
                                continue;
                            }
                            else
                            {
                                int a = array1[t] + array2[t];
                                array3[t] = a % 10;
                                array2[t + 1] = array2[t + 1] + 1;
                            }
                        }
                        Array.Reverse(array3);
                        for (int k = 0; k < n; k++)
                        {
                            Console.Write(array3[k]);
                        }
                        Console.ReadLine();
                    }
                    break;
                case '-':
                    {
                        for (int t = 0; t < n; t++)
                        {
                            if (number1.Length > number2.Length)
                            {
                                array3[t] = array1[t] - array2[t];
                                if (array1[t] < array2[t])
                                {
                                    array3[t] = (array1[t] + 10) - array2[t];
                                    array1[t + 1] = array1[t + 1] - 1;
                                }
                            }
                            else if (number1.Length < number2.Length)
                            {
                                array3[t] = array2[t] - array1[t];
                                if (array2[t] < array1[t])
                                {
                                    array3[t] = (array2[t] + 10) - array1[t];
                                    array2[t + 1] = array2[t + 1] - 1;
                                }
                            }
                            else
                            {
                                if (array1[0] > array2[0])
                                {
                                    array3[t] = array1[t] - array2[t];
                                    if (array1[t] < array2[t])
                                    {
                                        array3[t] = (array1[t] + 10) - array2[t];
                                        array1[t + 1] = array1[t + 1] - 1;
                                    }
                                }
                                else
                                {
                                    array3[t] = array2[t] - array1[t];
                                    if (array2[t] < array1[t])
                                    {
                                        array3[t] = (array2[t] + 10) - array1[t];
                                        array2[t + 1] = array2[t + 1] - 1;
                                    }
                                }

                            }
                        }
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}












