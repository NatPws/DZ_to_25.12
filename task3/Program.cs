// Задайте произвольную строку. Выясните, является ли она палиндромом.

string str = "слово";   // кириллица у меня не работает, поэтому буду писать слово латинскими буквами
char[] array = { 's', 'l', 'o', 'l', 's' };

int n = array.Length;
int index = 0;
char[] array1 = new char[array.Length / 2];
bool flag = false;

for (int i = 0; i < array1.Length; i++)
{
    if (array[i] == array[(array.Length - 1) - i])
    {
        flag = true;
    }
}
if (flag)
{
    Console.Write("заданное слово является палиндромом");
}
else
{
    Console.Write("заданное слово не является палиндромом");
}
