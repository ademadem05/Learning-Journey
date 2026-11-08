var n = int.Parse(Console.ReadLine());
var sum = 0;

for (var i = 1; i <= n; i++)
{
    Console.WriteLine(2 * i - 1);
    sum += 2 * i - 1;
}

Console.WriteLine($"Sum: {sum}");