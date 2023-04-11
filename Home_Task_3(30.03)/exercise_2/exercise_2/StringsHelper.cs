using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_2;

public static class StringsHelper
{
    public static int? SecondIndexOf(this string str, string subString)
    {
        var secondIndex = str.IndexOf(subString,str.IndexOf(subString) + subString.Length);

        return secondIndex >= 0 ? secondIndex : null;
    }

    public static int CapitalWordsAmount(this string str)
    {
        var splittedString = str.Split(' ');
        return splittedString.Where(s => char.IsUpper(s[0])).Count();
    }

    public static string ReplaceDoubleLetters(this string str, string replacer)
    {// А якщо кілька пропусків міжсловами?
        var splittedString = str.Split(' ');

        for (int i = 0; i < splittedString.Length; i++)
        {
            for (int j = 0; j < splittedString[i].Length - 1; j++)
            {//Ця умова не обов'язкова
                if (!char.IsLetter(splittedString[i][j])) continue;

                if (splittedString[i][j] == splittedString[i][j+1])
                {
                    splittedString[i] = replacer;
                }
            }
        }

        return string.Join(" ", splittedString);
    }
}
