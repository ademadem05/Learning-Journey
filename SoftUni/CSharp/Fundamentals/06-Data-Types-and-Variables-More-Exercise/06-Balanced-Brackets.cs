namespace _00.demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int balance = 0;
            bool isUnbalanced = false;

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                // Satırın içindeki her bir karakteri tek tek kontrol et
                foreach (char ch in line)
                {
                    if (ch == '(')
                    {
                        balance++;
                        // Eğer iç içe parantez YASAKSA bu kalsın, SERBESTSE bunu sil:
                        if (balance > 1) isUnbalanced = true;
                    }
                    else if (ch == ')')
                    {
                        balance--;
                        if (balance < 0) isUnbalanced = true;
                    }
                }

                if (isUnbalanced) break;
            }

            // Sonuçta hem denge 0 olmalı hem de süreçte hata olmamalı
            if (!isUnbalanced && balance == 0)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }

        }
    }
}
