namespace _7._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();


            
            int maxCounter = 1;
            int bestElement = arr[0];
          
            int currentCounter = 1;
           
                
                for (global::System.Int32 j = 1; j < arr.Length; j++)
                {

                    if (arr[j - 1] == arr[j])
                    {
                        currentCounter++;
                    }
                    else
                    {
                        currentCounter = 1;
                    }
                    if (currentCounter > maxCounter)
                    { 
                        maxCounter = currentCounter;
                        bestElement = arr[j];
                   
                    }

                }
                
      
                for (int i = 1; i <= maxCounter; i++)
                {
                    Console.Write($"{bestElement} ");
                }

        }
    }
}
