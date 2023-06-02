// 1 вид(ничего не принимают, не возвращают)
void Method1()
{
    Console.Write("автор...");
}
//вызвать 
Method1();


//2 вид(ничего не возвращают, но принимают аргументы)
void Method2(string msg)
{
    Console.Write(msg);
}
Method2("текст");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.Write(msg);
        i++;
    }
}
//вызвать 
Method21(msg: "новый текст", count: 4);

//3 вид(что-то возвращает, но ничего не принимают) 
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.Write(year);

//4 вид(что-то принимают, что-то возвращают)
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
       result = result + text; 
       i++;
    }
    return result;
}
string res = Method4(10, "a");
Console.Write(res);

//с for (4вид)
    for (int i = 0; i < count; i++)
    {
        result = result + text; 
    }
    return result;
}
