using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StriverDSA.Patterns
{
    //https://takeuforward.org/strivers-a2z-dsa-course/must-do-pattern-problems-before-starting-dsa/
    public class Patterns
    {
        //*****
        //*****
        //*****
        //*****
        //*****
        public static void Pattern1(int n)
        {
            for (int i = 0; i < n; i++)
            {                
                for (int x = 0; x < n; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        //*
        //**
        //***
        //****
        //*****
        public static void Pattern2(int n)
        {            
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


        //1
        //12
        //123
        //1234
        //12345
        public static void Pattern3(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        //1
        //22
        //333
        //4444
        //55555
        public static void Pattern4(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        //*****
        //****
        //***
        //**
        //*
        public static void Pattern5(int n)
        {
            for (int i = n; i >= 1; i--)
            {                
                for (int x = 0; x < i; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        //55555
        //4444
        //333
        //22
        //1
        public static void Pattern5b(int n)
        {
            for (int i = n; i >= 1; i--)
            {
                for (int x = 0; x < i; x++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        //12345
        //1234
        //123
        //12
        //1
        public static void Pattern6(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        //    *
        //   ***
        //  *****
        // *******
        //*********
        public static void Pattern7(int n)
        {
            for (int x = 1; x <= n; x++)
            {
                for (int y = n; y > x; y--)
                {
                    Console.Write(" ");
                }
                for (int z = 1; z < (x * 2); z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        //*********
        // *******
        //  *****
        //   ***
        //    *
        public static void Pattern8(int n)
        {
            int x, y, z;
            for (x = n; x >= 1; x--)
            {
                for (y = n; y > x; y--)
                {
                    Console.Write(" ");
                }
                for (z = 1; z < (x * 2); z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        //    *
        //   ***
        //  *****
        // *******
        //*********
        //*********
        // *******
        //  *****
        //   ***
        //    *
        public static void Pattern9(int n)
        {
            for (int x = 1; x <= n; x++)
            {
                for (int y = n; y > x; y--)
                {
                    Console.Write(" ");
                }
                for (int z = 1; z < (x * 2); z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int x = n; x >= 1; x--)
            {
                for (int y = n; y > x; y--)
                {
                    Console.Write(" ");
                }
                for (int z = 1; z < (x * 2); z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


        //*
        //**
        //***
        //****
        //*****
        //****
        //***
        //**
        //*
        public static void Pattern10(int n)
        {
            for (int x = 1; x <= n; x++)
            {
                for (int i = 0; i < x; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int x = 1; x <= n; x++)
            {
                for (int i = n; i > x; i--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

        //1
        //10
        //101
        //1010
        //10101
        public static void Pattern11(int n)
        {
            for (int x = 1; x <= n; x++)
            {
                for (int i = 0; i < x; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }
                Console.WriteLine();
            }
        }


        //1             1
        //1 2         2 1
        //1 2 3     3 2 1
        //1 2 3 4 4 3 2 1
        public static void Pattern12(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                var z = 2 * (n - i);

                for (int j = 1; j <= z; j++)
                {  //imp line
                    Console.Write("  ");      //NO. of chr. should be same.
                }

                for (int j = i; j >= 1; j--)
                {         //Backward loop
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }

        //1
        //2 3
        //4 5 6
        //7 8 9 10
        //11 12 13 14 15
        public static void Pattern13(int n)
        {
            int count = 1;            
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count + " ");
                    count++;
                }
                Console.WriteLine();
            }
        }

        //A
        //AB
        //ABC
        //ABCD
        //ABCDE
        public static void Pattern14()
        {
            var abc = "ABCDE";
            for (int i = 0; i < abc.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(abc[j]);
                }
                Console.WriteLine();
            }
        }


        //ABCDE
        //ABCD
        //ABC
        //AB
        //A
        public static void Pattern15()
        {
            var abc = "ABCDE";
            for (int i = abc.Length; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(abc[j]);
                }
                Console.WriteLine();
            }
        }

        //A
        //BB
        //CCC
        //DDDD
        //EEEEE
        public static void Pattern16()
        {
            var abc = "ABCDE";
            for (int i = 0; i < abc.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(abc[i]);
                }
                Console.WriteLine();
            }
        }



        public static void Pattern17()
        {
            var abc = "ABCDE";
            for (int i = abc.Length; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(abc[j]);
                }
                Console.WriteLine();
            }
        }



        //    A
        //   ABA
        //  ABCBA
        // ABCDCBA
        //ABCDEDCBA
        public static void Pattern18()
        {
            var abc = "ABCDE";
            for (int i = 0; i <= abc.Length - 1; i++)
            {
                for (int j = abc.Length; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write(abc[j]);
                }
                for (int j = i; j >= 0; j--)
                {
                    Console.Write(abc[j]);
                }

                Console.WriteLine();
            }
        }


        //E
        //DE
        //CDE
        //BCDE
        //ABCDE
        public static void Pattern19()
        {
            var abc = "ABCDE";
            for (int i = 1; i <= abc.Length; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(abc[abc.Length - j]);
                }
                Console.WriteLine();
            }
        }



        //**********
        //****  ****
        //***    ***
        //**      **
        //*        *
        //*        *
        //**      **
        //***    ***
        //****  ****
        //**********
        public static void Pattern20(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write("*");
                }
                for (int k = 1; k <= (2 * i); k++)
                {
                    Console.Write(" ");
                }
                for (int j = n - i; j >= 1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write("*");
                }
                for (int k = 1; k <= (2 * i); k++)
                {
                    Console.Write(" ");
                }
                for (int j = n - i; j >= 1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


        //*        *
        //**      **
        //***    ***
        //****  ****
        //**********
        //****  ****
        //***    ***
        //**      **
        //*        *
        public static void Pattern21(int n)
        {

            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write("*");
                }
                for (int k = 1; k <= (2 * i); k++)
                {
                    Console.Write(" ");
                }
                for (int j = n - i; j >= 1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write("*");
                }
                for (int k = 1; k <= (2 * i); k++)
                {
                    Console.Write(" ");
                }
                for (int j = n - i; j >= 1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        //****
        //*  *
        //*  *
        //****
        public static void Pattern22(int n)
        {

            int i, j, k;
            for (i = 1; i <= n; i++)
            {
                if (i == 1 || i == n)
                {
                    for (j = 1; j <= n; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                else if (i != 1 || i != n)
                {
                    for (j = 1; j <= n; j++)
                    {
                        if (j == 1 || j == n)
                            Console.Write("*"); 
                        else
                        {
                        Console.Write(" ");
                        }
                    }
                Console.WriteLine();

                }
            }
        }

        //4 4 4 4 4 4 4
        //4 3 3 3 3 3 4
        //4 3 2 2 2 3 4
        //4 3 2 1 2 3 4
        //4 3 2 2 2 3 4
        //4 3 3 3 3 3 4
        //4 4 4 4 4 4 4
        public static void Pattern23(int n)
        {
            for (int i = n; i > 0; i--)
            {                
                for (int j = n; j >= i; j--)
                {
                    Console.Write(j + " ");
                }
                for (int k = i; k > 1; k--)
                {
                    Console.Write(i + " ");
                }
                for (int k = i; k > 1; k--)
                {
                    Console.Write(i + " ");
                }
                for (int j = i + 1; j <= n; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            for (int i = 2; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write(j + " ");
                }
                for (int k = i; k > 1; k--)
                {
                    Console.Write(i + " ");
                }
                for (int k = i; k > 1; k--)
                {
                    Console.Write(i + " ");
                }
                for (int j = i + 1; j <= n; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
