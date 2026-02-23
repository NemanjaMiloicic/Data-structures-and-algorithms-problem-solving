static bool hasDuplicate(int[] nums)
{
        HashSet<int> seenNums = [];
        foreach(int num in nums)
            if (!seenNums.Add(num))
                return true;
        return false;
}
/*static bool hasDuplicate(int[] nums)
    return new HashSet<int>(nums).Count < nums.Length;    
*/

Console.WriteLine(hasDuplicate([1,1,1,3,3,4,3,2,4,2]));

