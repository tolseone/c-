// Метод 4 через цикл for
string Method4(int count, string c)
{
    string result = String.Empty;

    for ( int i = 0; i < count; i++)
    {
        result += c;
    }
    return result;
}

string res = Method4(10, "Z");
Console.WriteLine(res);