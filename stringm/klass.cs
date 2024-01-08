using System;

public class StringManipulator
{
    // Metod för att vända en sträng baklänges
    public string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // Metod för att slå ihop två strängar
    public string ConcatenateStrings(string str1, string str2)
    {
        return str1 + str2;
    }

    // Metod för att ta bort mellanslag från en sträng
    public string RemoveSpaces(string input)
    {
        return input.Replace(" ", string.Empty);
    }

    // Metod för att konvertera strängen till versaler
    public string ToUpperCase(string input)
    {
        return input.ToLower();
    }

    // Metod för att konvertera strängen till gemener
    public string ToLowerCase(string input)
    {
        return input.ToLower();
    }
}