using System;
using System.Collections.Generic;

public class RomanDecode
{
	public static int Solution(string roman)
	{
		int sum = 0;
    string str = roman;
    Dictionary<string, int> significants = new Dictionary<string, int>()
    {  {"CM", 900}, {"CD", 400}, {"XC", 90}, {"XL", 40},
       {"IX", 9}, {"IV", 4}, {"M", 1000}, {"D", 500},
       {"C", 100},  {"L", 50},  {"X", 10}, {"V", 5}, {"I",1}     
    };
    foreach (KeyValuePair<string, int> combo in significants)
    {
       int coeff = str.Length;
       str = str.Replace(combo.Key, "");
       coeff -= str.Length;
       coeff /= combo.Key.Length;
       sum += coeff * combo.Value;  
    }
    return sum;
	}
}
