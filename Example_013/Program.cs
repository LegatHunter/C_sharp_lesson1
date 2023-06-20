//Задача
//Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить большими "К", а большие "С" заменить маленькими "с".

// string s = "qwerty"
//             012
// s[3] // r

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";
// string Replase(string text, char oldValue, char newValue)
// {
//     string result = string.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// string newText = Replase(text, ' ', '|');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();
// newText = Replase(newText, 'к', 'К');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();
// newText = Replase(newText, 'С', 'с');
// System.Console.WriteLine(newText);





//Задача на упорядывачивание массива (min - max)
// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
//     System.Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }
//         int temp = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temp;
//     }

// }
// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);

//Задача на упорядывачивание массива (max - min)

// int[] arr = {7, 8, 5, 2, 4, 1, 3, 6, 8, 6, 4, 5, 9};
// void Mass (int[] array){
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
//     System.Console.WriteLine();
// }

// void Mass1(int[] array)
// {
//     for(int i = 0; i < array.Length - 1; i++)
//     {
//         int maxP = i;
//         for(int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] > array[maxP]) maxP = j;
//         }
//         int t = array[i];
//         array[i] = array[maxP];
//         array[maxP] = t;
//     }
// }

// Mass(arr);
// Mass1(arr);
// Mass(arr);