// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
    
char[,] charArray = new char[,] { { 'x', 'y' }, { 'z', 'a' } };
string result = CreateStringFrom2DArray(charArray);
   

string CreateStringFrom2DArray(char[,] array)
{
    string result = "";
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i, j];
        }
    }
    return result;
}

 Console.WriteLine(result);