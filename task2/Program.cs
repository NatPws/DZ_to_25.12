// Задайте строку, содержащую латинские буквы в обоих регистрах. 
//Сформируйте строку, в которой все заглавные буквы заменены на строчные.


string text = "Eta sTRoKA soDerZHit latinSKie BuKvi";

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) 
        {
            result = result + $"{newValue}";
        }
        else 
        {
            result = result + $"{text[i]}";
        }
    }
    return result;
}
string newText = Replace(text, "K", "k");
Console.WriteLine(newText);
