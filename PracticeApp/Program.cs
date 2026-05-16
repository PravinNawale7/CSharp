namespace PracticeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements of array: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            
           

            int[] arr = new int [input];

            for(int i = 0; i < input; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            //foreach(int array in arr)
            //{
            //    Console.Write (array + " ");
            //}

            //for(int i = 0; i < input; i++)
            //{
            //    sum += arr[i];
              
            //    Console.Write(arr[i] + " ");
            //}
            //int max = arr[0];
            //int min = arr[0];
            //for (int i = 0; i < input; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }

                
            //}
            //Console.WriteLine("MAX IS ===> " + max);
            //Console.WriteLine("Min IS ===> " + min);
            //int avg = sum / input;
            //Console.WriteLine();
            //Console.WriteLine("SUM IS ==> " + sum);
            //Console.WriteLine("AVG IS ==> " + avg);
            //int even = 0;
            //int odd = 0;
            //foreach(int num in arr)
            //{
            //    if(num % 2 == 0)
            //    {
            //        even += 1;
            //    }
            //    else
            //    {
            //        odd += 1;
            //    }
            //}
            //Console.WriteLine("EVEN " + even);
            //Console.WriteLine("ODD ==> " + odd);

            for(int i=input-1;i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("Enter the Element to searfch the number ");
                int element = Convert.ToInt32(Console.ReadLine());
            bool found = false; 

            for(int i=0;i< input; i++)
            {
                    if (arr[i] == element)
                    {
                    Console.WriteLine("Element found at index: " + i);
                    found = true;
                    break;

                    }
                 
            }
            if (!found)
            {
                Console.WriteLine("Element not found");
            }
            
        }
    }
}
