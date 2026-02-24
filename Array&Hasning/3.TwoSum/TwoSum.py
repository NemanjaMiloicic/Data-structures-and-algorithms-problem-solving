from typing import List


def TwoSum(nums : List[int], target : int) -> List[int]:
    targetPairs = {}
    for i in range(len(nums)):
        difference = target - nums[i]
        if difference in targetPairs:
            return [targetPairs[difference], i]
        targetPairs[nums[i]] = i
    return []


print(TwoSum([4,5,6],10))