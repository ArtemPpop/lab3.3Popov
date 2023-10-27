try

{

    Console.Write("Введите x:");

    double x = double.Parse(Console.ReadLine());

    Console.Write("Введите n:");

    double n = double.Parse(Console.ReadLine());

    double s = 1;

    for (int i = 1; i <= n; i++)

    {

        long f = 1;

        for (int j = 1; j <= i; j++) f *= j;

        s += Math.Cos(i * Math.PI / 4) * Math.Pow(x, i) / f;



    }

    Console.Write($"S={s:F2}");



}

catch (Exception ex)

{

    Console.WriteLine(ex.Message);

}