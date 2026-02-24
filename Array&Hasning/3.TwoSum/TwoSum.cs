static int[] TwoSum(int[] nums, int target)
{
    Dictionary<int,int> targetPairs = [];
    for(int i = 0; i < nums.Length; i++)
    {
        int difference = target-nums[i]; 
        if(targetPairs.ContainsKey(difference))
            return [targetPairs[difference], i];
        targetPairs.Add(nums[i], i);
    }
    return null;
}

int[] result = TwoSum([4,5,6],10);
Console.WriteLine($"[{result[0]},{result[1]}]");
