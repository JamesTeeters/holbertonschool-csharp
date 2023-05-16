using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> newDict = new Dictionary<string, int>();

        if (myDict != null)
        {
            foreach (KeyValuePair<string, int> pair in myDict)
            {
                newDict.Add(pair.Key, pair.Value *2);
            }
        }
        return newDict;
    }
}