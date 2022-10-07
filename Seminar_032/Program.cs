
int a1, a2, b1, b2;

a1 = Koords("Введите координату х первого числа: ");
a2 = Koords("Введите координату y первого числа: ");
b1 = Koords("Введите координату х второго числа: ");
b2 = Koords("Введите координату y второго числа: ");
//Console.WriteLine(a1);

double distance = Distance(a1, a2, b1, b2);
Console.WriteLine(distance);

static int Koords(string message)
{
    Console.Write(message);
    int res = int.Parse(Console.ReadLine()); //ввод с консоли и присваивание этого числа res
    return res;
}

static double Distance(int a1, int a2, int b1, int b2)
{
    double res = Math.Sqrt(Math.Pow(b1 - a1, 2) + Math.Pow(b2 - a2, 2));
    return res;
}