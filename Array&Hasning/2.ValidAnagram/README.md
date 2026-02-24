# ValidAnagram

Given two strings s and t, return true if the two strings are anagrams of each other, otherwise return false.

An anagram is a string that contains the exact same characters as another string, but the order of the characters can be different.

Example 1:
 ```
Input: s = "racecar", t = "carrace"
Output: true
 ```
Example 2:
 ``` 
Input: s = "jar", t = "jam"
Output: false
 ```
Constraints:
s and t consist of lowercase English letters.

# Hints
A brute force solution would be to sort the given strings and check for their equality. This would be an O(nlogn + mlogm) solution. Though this solution is acceptable, can you think of a better way without sorting the given strings?

By the definition of the anagram, we can rearrange the characters. Does the order of characters matter in both the strings? Then what matters?

We can just consider maintaining the frequency of each character. We can do this by having two separate hash tables for the two strings. Then, we can check whether the frequency of each character in string s is equal to that in string t and vice versa.