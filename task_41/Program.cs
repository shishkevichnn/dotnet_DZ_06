/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

string MyNumbers = ReadString("Введите числа через зяпятую: ");
string MyString = string.Empty;

int count = 0;
for (int i = 0; i < MyNumbers.Length; i++)
{
    if (MyNumbers[i] != ',') 
        MyString += MyNumbers[i];
    else
    {
        if (Convert.ToInt32(MyString) > 0) 
            count++;
            MyString = string.Empty;
    }
}
if (Convert.ToInt32(MyString) > 0) 
    count++;

Console.WriteLine($"Чисел больше 0: {count}");

string ReadString(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}