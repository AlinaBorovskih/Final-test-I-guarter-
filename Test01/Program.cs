void Print(string[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write(mass[i] + " ");
    }
    Console.WriteLine();
}
Console.Write("Введите размер массива: ");
int N = int.Parse(Console.ReadLine());
string[] mass = new string[N];
Console.WriteLine("Введите строку: ");

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = Console.ReadLine();
}

Console.WriteLine();

int count = 0;
string[] mass2 = new string[N];

for (int i = 0; i < mass.Length; i++)
{
    if (mass[i].Length <= 3)
    {
        mass2[count] = mass[i];
        count++;
    }
}

Print(mass2);