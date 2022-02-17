using System.Text;
using System;

string str1 = "cs";
string str2 = " is COOL!";
string str3 = str1+str2; //concats the value of str1 and str2 
Console.WriteLine(str3);

const string str4 = "you cant change me";
Console.WriteLine(str4.Length); // prints the total number of char/whitespace in that string
Console.WriteLine(str4 + " but i can add on to you though");

Console.WriteLine(str4.ToUpper());//converts all chars in string to uppercase
Console.WriteLine(str2.ToLower());//converts all char in string to lowercase

//string interpolation
string fullsentence = $"I like computer sceience because {str1} {str2}";
Console.WriteLine(fullsentence);

//string indexing
//prints the first element of the interpolation
Console.WriteLine(fullsentence[0]);