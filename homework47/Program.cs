int m = Convert.ToInt32(Console.ReadLine()),
    n = Convert.ToInt32(Console.ReadLine());
double[,] arr = new double[m, n];
Random rnd = new Random();

for(int i = 0; i < m; i++)
{
    for(int k = 0; k < n; k++)
    {
        arr[i, k] = Convert.ToDouble(rnd.Next(100) / 10.0);
        Console.WriteLine(arr[i, k]);
    }
}

for (int a = 0; a < m; a++)
{
    Console.WriteLine();
    for (int b = 0; b < n; b++)
    {
        Console.Write(arr[a, b]);
        Console.Write(' ');
    }
}