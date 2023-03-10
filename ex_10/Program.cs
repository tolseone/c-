// Метод 1
void Method1()
{
    Console.WriteLine("Автор Семисынов Анатолий");
}

Method1();

// Метод 2
void Method2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {  
    Console.Write(msg);
    i++;
    }
}

Method2(count: 3, msg: "Толя ");

//  Метод 3
int Method3()
{
    return DateTime.Now.Month;
}
int m = Method3();
Console.WriteLine(m);

// Метод 4
string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result += c;
        i++;
    }
    return result;
}

string res = Method4(10, "Z");
Console.WriteLine(res);