namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Arr = Console.ReadLine().Split().ToList();

            string input;
            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] parts = input.Split(' ').ToArray();
                string command = parts[0];
                int firstNum = int.Parse(parts[1]);
                int secondNum = int.Parse(parts[2]);

                if (command == "merge")
                {
                    if (firstNum >= Arr.Count || secondNum < 0 || firstNum > secondNum)
                    {
                        continue; 
                    }
                    if (firstNum < 0)
                    {
                        firstNum = 0;
                    }
                    if (Arr.Count - 1  < secondNum)
                    {
                        secondNum = Arr.Count - 1;
                    }

                    string mergedArr = "";
                    for (global::System.Int32 i = firstNum; i <= secondNum; i++)
                    {
                        mergedArr += Arr[i];
                    }

                    Arr.RemoveRange(firstNum, secondNum - firstNum + 1);
                    Arr.Insert(firstNum, mergedArr);
                }
                else if (command == "divide")
                {
                    int index = firstNum;
                    int partitions = secondNum;

                    string word = Arr[index];

                    int partLength = word.Length / partitions;

                    List<string> tempHolder = new List<string>();
                    int startIndex = 0;
                    for (global::System.Int32 i = 0; i < partitions; i++)
                    {
                        string currentPart = "";
                        if (i == partitions - 1)
                        {
                            currentPart = word.Substring(startIndex);
                        }
                        else
                        {
                            currentPart = word.Substring(startIndex, partLength);
                            startIndex += partLength;
                        }
                        tempHolder.Add(currentPart);
                    }
                    Arr.RemoveAt(index);
                    Arr.InsertRange(index, tempHolder);

                }
            }
            Console.WriteLine(string.Join(" ", Arr));
        }
    }
}
