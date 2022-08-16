/*
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
*/


int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray (int[] array)
{
    int count = array.Length;

    for (int i=0; i<count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort (int[] array)
{
    for (int i=0; i<array.Length-1; i++)
    {
        int minPosition = i;
        
        for (int j=i+1; j<array.Length; j++)
        {
            if (array[j]<array[minPosition]) minPosition=j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

