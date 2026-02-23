static bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length)
        return false;
    
    Dictionary<char, int> sCharacterFreq = [];
    Dictionary<char, int> tCharacterFreq = [];
    for(int i = 0; i < s.Length ; i++)
    {
        sCharacterFreq[s[i]] = sCharacterFreq.GetValueOrDefault(s[i], 0) + 1;
        tCharacterFreq[t[i]] = tCharacterFreq.GetValueOrDefault(t[i], 0) + 1;
    }
    return sCharacterFreq.Count == tCharacterFreq.Count && !sCharacterFreq.Except(tCharacterFreq).Any();
}
Console.WriteLine(IsAnagram("racecar" , "carrace"));