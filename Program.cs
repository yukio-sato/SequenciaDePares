Console.Clear();
Console.WriteLine("Sequência de Pares.");
Console.Write("Escolha um número de 0 à [?]: ");
int max = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (i <= max)
{
Console.Write($"{i} ");
i = i + 2;
}
Console.WriteLine();