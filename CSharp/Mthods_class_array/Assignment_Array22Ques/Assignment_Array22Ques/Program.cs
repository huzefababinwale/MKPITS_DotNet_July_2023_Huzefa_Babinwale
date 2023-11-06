using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Array22Ques
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1st Program;
            /*int[] arr=new int[10];
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter "+i+ " element");
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }*/
            /*      ---------------------------------------------------------------------*/
            /*2nd*/
            /*int[] arr = { 2, 5, 7 };

            for(int i=2; i>=0; i--)
            {
                Console.Write(arr[i]+"\t");
            }
*/
            /*            --------------------------------------------------------------------*/
            /*3rd*/
            /*int[] arr = { 2, 5, 8 };
            int sum = 0;

            for (int i = 2; i >= 0; i--)
            {
                sum =  arr[i]+sum;
            }
            Console.WriteLine(sum);*/
            /*
        ----------------------------------------------------------------------------------*/
            /*4th*/
            /*int[] arr = new int[3];
            int[] arr2 = new int[3];
            int i = 0;
            for (i = 0; i <=2; i++)
            {
                Console.WriteLine("Enter Element for "+i); 
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            for ( i = 0; i <= 2; i++)
            {
                arr2[i] = arr[i];
                Console.WriteLine();
                Console.Write(arr2[i]);
            }*/
            /*
                        -------------------------------------------------------------------------*/
            /*5th*/
            /*int[] arr = new int[3];
            int i = 0;
            for (i = 0; i <= 2; i++)
            {
                Console.WriteLine("Enter Element for " + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            for (i = 0; i <= 2; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    Console.WriteLine("Duplicate atom found at " + i + "=" + arr[i]); break;
                }
            }*/
            /*-------------------------------------------------------------------
            6th*/
            /*int[] arr = new int[3];
            int i = 0;
            int j = 0;
            for (i = 0; i <= 2; i++)
            {
                Console.WriteLine("Enter Element for " + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            for (i = 0; i <= 2; i++)
            {
                for(j=i+1;j<=2;j++)

                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine("Duplication found for number=" + i);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(arr[i]+ "is Unique");
                    }
                } 
            }*/
            /*
                        ---------------------------------------------------------------------------
                            7th*/
            /*int[] arr1 = new int[5];
            int[] fr1 = new int[5];
            int n, i, j, ctr;


            Console.Write("\n\nCount the frequency of each element of an array:\n");
            Console.Write("----------------------------------------------------\n");

            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                fr1[i] = -1;
            }
            for (i = 0; i < n; i++)
            {
                ctr = 1;
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        ctr++;
                        fr1[j] = 0;
                    }
                }

                if (fr1[i] != 0)
                {
                    fr1[i] = ctr;
                }
            }
            Console.Write("\nThe frequency of all elements of the array : \n");
            for (i = 0; i < n; i++)
            {
                if (fr1[i] != 0)
                {
                    Console.Write("{0} occurs {1} times\n", arr1[i], fr1[i]);
                }
            }*/
            /*            ---------------------------------------------------------*/
            /*8th*/
            /*int[] arr = new int[3];
            int i;
            for (i = 0; i <= 2; i++)
            {
                Console.WriteLine("Enter Element for " + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            Console.WriteLine("Maximum of Entered Number is " + arr[2]);
            Console.WriteLine("Minimum of Entered Number is " + arr[0]);
*/
            /*--------------------------------------------------------------
            9th*/
            /*int[] arr = new int[3];
            int[] odd = new int[3];
            int[] even = new int[3];
            int i,j=0;
            for (i = 0; i <= 2; i++)
            {
                Console.WriteLine("Enter Element for " + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2 == 0)
                {
                    even[j] = arr[i];
                    j++;
                }
                else
                {
                    odd[j] = arr[i];
                    j++;
                }
            }
            Console.WriteLine("Normal Array ");
            for (i = 0; i <= 2; i++)
            {
                Console.Write(arr[i]+"\t");
            }
            Console.WriteLine("Odd Array");
            for (i = 0; i <= 2; i++)
            {
                Console.Write(odd[i]+"\t");
            }
            Console.WriteLine("Even Array ");
            for (i = 0; i <= 2; i++)
            {
                Console.Write(even[i]+"\t");
            }
*/
            /*            ---------------------------------------------------------------------*/
            /*10th*/
            /*int[] arr = new int[5];
            int i;
            for (i = 0; i <5; i++)
            {
                Console.WriteLine("Enter Element for " + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine(arr[i]);
                
            }*/
            /*            -----------------------------------------------------------*/
            /*11th*/
            /*int[] arr = new int[5];
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Element for " + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            for (i = 4; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);

            }*/
            /* ---------------------------------------------------------*/
            /*12th*/
            /*int[] arr = new int[5];
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Element for " + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            for (i = 0; i <= 4; i++)
            {
                Console.Write(arr[i]+"\t");

            }
            int l = arr.Length-2;
            Console.WriteLine("Second Largest Element in array is " + arr[l]);*/

            /*            -----------------------------------------------------------------------*/
            /*13th*/
            /*int[] arr = new int[5];
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Element for " + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            for (i = 0; i <= 4; i++)
            {
                Console.Write(arr[i] + "\t");

            }
            Console.WriteLine("Second Smallest Element in array is " + arr[1]);*/
            /*-------------------------------------------------------------*/
            /*14th*/

            /*int[,] arr = new int[3,3];
            int i,j;
            for (i = 0; i < 3; i++)
            {
                for(j= 0; j < 3; j++)
                {
                    Console.WriteLine("Enter Element for [{0},{1}]",i,j);
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j]+ "\t");
                }
                Console.WriteLine();
            }*/
            /*-----------------------------------------------------*/
            /*15th*/
            /*int[,] arr = new int[3, 3];
            int[,] arr2 = new int[3, 3];
            int[,] arr3 = new int[3, 3];
            int i, j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine("Enter Element for [{0},{1}]", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine("Enter Element for [{0},{1}]", i, j);
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    arr3[i,j]= arr[i, j] + arr2[i,j];
                }
            }

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(arr3[i, j] + "\t");
                }
                Console.WriteLine();
            }
*/                /*-------------------------------*/
            /*16th*/
            /*int[,] arr = new int[3, 3];
            int[,] arr2 = new int[3, 3];
            int[,] arr3 = new int[3, 3];
            int i, j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine("Enter Element for [{0},{1}]", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine("Enter Element for [{0},{1}]", i, j);
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    arr3[i, j] = arr[i, j] - arr2[i, j];
                }
            }

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(arr3[i, j] + "\t");
                }
                Console.WriteLine();
            }*/
            /* ------------------------------------------------------*/
            /*17th*/
            /*
            int[,] arr = new int[2, 2];
            int[,] arr2 = new int[2, 2];
            int[,] arr3 = new int[2, 2];
            int i, j;
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("Enter Element for [{0},{1}]", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("Enter Element for [{0},{1}]", i, j);
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    arr3[i, j] = arr[i, j] * arr2[i, j];
                }
            }

            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(arr3[i, j] + "\t");
                }
                Console.WriteLine();
            }*/
/*            -----------------------------------------------
*/
            /*18th*/
            int[,] arr = new int[2, 2];
            int[,] arr2 = new int[2, 2];
            int[,] arr3 = new int[2,2];

            int i, j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine("Enter Element for [{0},{1}]", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine("Enter Element for [{0},{1}]", i, j);
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    arr3[i, j] = arr[j, i]  +arr2[i, j];
                }
            }

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(arr3[i, j] + "\t");
                }
                Console.WriteLine();
            }




            Console.ReadKey();
        }
    }
}
