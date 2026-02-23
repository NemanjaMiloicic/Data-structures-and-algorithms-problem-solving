def IsAnagram(s : str , t : str) -> bool:
    if len(s) != len(t):
        return False
    sCharacterFreq, tCharacterFreq = {}, {}
    for i in range(len(s)):
        sCharacterFreq[s[i]] = sCharacterFreq.get(s[i], 0) + 1
        tCharacterFreq[t[i]] = tCharacterFreq.get(t[i], 0) + 1
    return sCharacterFreq == tCharacterFreq

print(IsAnagram("racecar" , "carrace"))