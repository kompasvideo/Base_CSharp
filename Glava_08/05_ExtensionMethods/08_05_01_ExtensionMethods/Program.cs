﻿string s = "Hello, World!";
char c = 'o';
int i = s.CharCount(c);
Console.WriteLine(i);

public static class StringExtension
{
    public static int CharCount(this string str, char c)
    {
        int counter = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == c)
                counter++;
        }
        return counter;
    }
}