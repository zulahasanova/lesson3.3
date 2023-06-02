//таблица умножения

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}

/* маленькие буквы "k" заменить большими "K",
большие "С" заменить маленькими "c". */

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string s = "qwerty"
//            012345
//s[3] // r

string Replace(string text, char OldValue, char NewValue)
{
    string result = string.Empty;

    int length = text.Length; //показывает кол-во букв в строке
    for (int i = 0; i < length; i++)
    {
        if(text[i] == OldValue)
        {
            result = result + $"{NewValue}";
        }
        else{
            result = result + $"{text[i]}";
        }
    }
    return result;
}
string newText = Replace(text, 'с', 'С');
Console.Write(newText);
newText = Replace(newText, 'к', 'К');
Console.Write(newText);

//упорядочить с мин до макс    ????????
  
int[] array = { 1, 4, 7, 5, 9, 3};
PrintArray(array);
Selection(array);

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void Selection(int[] array) //упорядочить
{
    for (int i = 0; i < array.Length; i++)
    {
        int min = i;
        for (int j = i + 1; j < array.Length - 1; j++)
        {
            if(array[j] < array[min])
            {
                min = j;
            }
        }
        int temporary = array[i];
        array[i] = array[min];
        array[min] = temporary;
    }
    
}