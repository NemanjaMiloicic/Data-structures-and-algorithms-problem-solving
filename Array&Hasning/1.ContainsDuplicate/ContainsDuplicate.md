# ContainsDuplicate
Given an integer array nums, return true if any value appears more than once in the array, otherwise return false.

Example 1:
 ```
Input: nums = [1, 2, 3, 3]

Output: true
 ```
Example 2:
 ```
Input: nums = [1, 2, 3, 4]

Output: false
 ```
# Hints:
A brute force solution would be to check every element against every other element in the array. This would be an O(n^2) solution. Can you think of a better way?

Is there a way to check if an element is a duplicate without comparing it to every other element? Maybe there's a data structure that is useful here.

We can use a hash data structure like a hash set or hash map to store elements we've already seen. This will allow us to check if an element is a duplicate in constant time.
