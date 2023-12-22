//  Задайте строку, состоящую из слов, разделенных пробелами. 
//Сформировать строку, в которой слова расположены в обратном порядке. 
//В полученной строке слова должны быть также разделены пробелами.


string ReversWords(string sentence)
{
string[] words = sentence.Split(' ');
Array.Reverse(words);
string reverseSentence = string.Join(", ", words);
return reverseSentence;
}

string sentence = "слово1 слово2 слово3";
string reverseSentence = ReversWords(sentence);
System.Console.Write(reverseSentence);


