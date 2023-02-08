using System.Text;

namespace Lab13;

public static class Extensions
{
    public static int Reverse(this int num)
    {
        string numString = num.ToString();
        var reversedEnumerable = numString.Reverse();

        StringBuilder result = new();

        foreach (var item in reversedEnumerable)
        {
            result.Append(item);
        }

        return int.Parse(result.ToString());
    }

    public static int NumberOfDigits(this int num)
    {
        //return num.ToString().Length;

        int counter = 0;

        string numString = num.ToString();

        foreach (var item in numString)
        {
            counter++;
        }

        return counter;
    }

    public static string RemoveSpecialCharacters(this string text)
    {
        StringBuilder result = new();

        foreach (char c in text)
        {
            switch (c)
            {
                case '-':
                case '+':
                case '/':
                case '_':
                case '*':
                    break;
                default: 
                    result.Append(c); 
                    break;
            }
        }

        return result.ToString();
    }

    public static int GetMaxInCollection(this IEnumerable<int> intCollection)
    {
        //return intCollection.Max();

        int currentMax = int.MinValue;

        foreach (int i in intCollection)
        {
            if (i > currentMax) 
                currentMax = i;
        }

        return currentMax;
    }

    public static T GetMaxInCollection<T>(this IEnumerable<T> collection)
    {
        return collection.Max();

        //var currentMax = ;

        //foreach (var i in collection)
        //{
        //    if (i > currentMax)
        //        currentMax = i;
        //}

        //return currentMax;
    }
}
