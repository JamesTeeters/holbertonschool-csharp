using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList == null || myList.Count == 0)
            return ("None");

        KeyValuePair<string, int> bestScore = myList.First();

        foreach (KeyValuePair<string, int> pair in myList)
        {
            if (pair.Value > bestScore.Value)
                bestScore = pair;
        }
        return bestScore.Key;
    }
}