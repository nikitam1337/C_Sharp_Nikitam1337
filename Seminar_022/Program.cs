Console.Write("Введите первое число: ");
string userInput1 = Console.ReadLine() ?? "";
int a1 = int.Parse(userInput1);

Console.Write("Введите второе число: ");
string userInput2 = Console.ReadLine() ?? "";
int a2 = int.Parse(userInput2);

int a3 = a1%a2;
if(a3==0)
    Console.WriteLine($"число {a1} кратно числу {a2}");
else
    Console.WriteLine($"число {a1} не кратно числу {a2}, остаток от деления: {a3}");
