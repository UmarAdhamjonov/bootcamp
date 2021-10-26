using System;

namespace bootcamp.Solutions
{
    public class Lab8
    {
        public void WriteStars(int a, int b)
        {
            Console.Write($"{a}: ");
            while (b-->0)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }

        public void Problem1()
        {
            int[] sonlar = new int[5];

            int sum = 0;
            float avarage = 0;

            for (int i = 0; i < 5; i++)
            {
                sonlar[i] = int.Parse(Console.ReadLine());  
                sum += sonlar[i];              
            }
    
            avarage = (float)sum / 5;

            for (int i = 0; i < 5; i++)
            {
                if(sonlar[i] > avarage)
                {
                    Console.Write($"{sonlar[i]} ");
                }
            }
            System.Console.WriteLine();
        }

        public void Problem2()
        {
            int[] sonlar = new int[10];

            for (int i = 0; i < 10; i++)
            {
                sonlar[i] = int.Parse(Console.ReadLine());  
            }

            int one = 0, two = 0, three = 0;

            for (int i = 0; i < 10; i++)
            {
                switch(sonlar[i])
                {
                    case 1: one++;break;
                    case 2: two++;break;
                    case 3: three++;break;
                }
            }

            WriteStars(1, one);
            WriteStars(2, two);
            WriteStars(3, three);          
        }

        public void Problem3()
        {
            int[] arr = new int[5];
            int max1 = 0, max2 = 0;

            for (int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            max1 = arr[0] > arr[1] ? arr[0] : arr[1];
        	max2 = arr[0] < arr[1] ? arr[0] : arr[1];

            for (int i = 2; i < 5; i++)
            {
                max2 = arr[i] > max2 ? arr[i] : max2;
                max2 = arr[i] > max1 ? max1 : max2;
                max1 = arr[i] > max1 ? arr[i] : max1;
            }

            Console.WriteLine($"{max1}" + " " + $"{max2}");
        }

        public void Problem4()
        {
            int[] arr = new int[5];

            for (int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 4; i++)
            {
                int temp = arr[i];
                arr[i] = arr[i+1];
                arr[i+1] = temp;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{arr[i]}");
            }
        }
    }
}