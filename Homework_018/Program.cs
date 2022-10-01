Console.Write("Введите число: ");
string userInput = Console.ReadLine() ?? "";
int a = int.Parse(userInput);
int x = 1;

Console.Write(a + " -> ");

while (x <= a)
    if (x%2==0)
    {
        Console.Write(x);
        if(a%2==0)
        {
            if(x < a)
            {
                Console.Write(", ");
            }
        }
        else
        {
            if(x < a -1)
            {
                Console.Write(", ");
            }
        }
        x += 1;
    }
    else
    {
        x +=1;
    }
