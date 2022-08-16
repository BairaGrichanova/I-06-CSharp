// Работа с текстом
// Дан текст.
// Пробелы заменить черточками
// маленькие "к" заменить на "К"
// большие "С" заменить на "с"

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
                + "ежели бы вас послали вместо нашего милого Винценгероде,"
                + " вы бы взяли приступом согласие прусского короля. "
                + "Вы так красноречивы. Вы дадите мне чаю?";

//string s= "qwerty"
//           012345
//string[3]="r"

string Replace (string str, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = str.Length;
    for (int i=0; i<length; i++)
    {
        if (str[i]==oldValue) result = result + $"{newValue}";
        else result = result + $"{str[i]}";
    }

    return result;
}

string newText = Replace (text, ' ', '|');
Console.WriteLine (newText);

Console.WriteLine (Replace (newText, 'к', 'К'));