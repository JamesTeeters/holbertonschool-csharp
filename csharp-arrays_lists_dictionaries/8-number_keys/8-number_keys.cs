using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int key_count = 0;
        foreach (KeyValuePair<string, string> pair in myDict)
        {
            key_count++;
        }
        return key_count;
    }
}