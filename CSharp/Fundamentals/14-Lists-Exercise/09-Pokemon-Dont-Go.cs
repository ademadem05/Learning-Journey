namespace _09._Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            long totalSum = 0;

            while (list.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int removedElement;
                if (index < 0)
                {
                    // İndeks negatifse: İlk elemanı sil, yerine son elemanı kopyala
                    removedElement = list[0];
                    list[0] = list[list.Count - 1];
                }
                else if (index >= list.Count)
                {
                    // İndeks büyükse: Son elemanı sil, yerine ilk elemanı kopyala
                    removedElement = list[list.Count - 1];
                    list[list.Count - 1] = list[0];
                }
                else
                {
                    // İndeks normal aralıktaysa: Elemanı sil
                    removedElement = list[index];
                    list.RemoveAt(index);
                }
                totalSum += removedElement;

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] <= removedElement)
                    {
                        list[i] += removedElement;
                    }
                    else
                    {
                        list[i] -= removedElement;
                    }
                }
            }
            Console.WriteLine(totalSum);
        }
    }
}
