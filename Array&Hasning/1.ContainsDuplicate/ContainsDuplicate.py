from typing import List

def containsDuplicate(nums: List[int]) -> bool:
    seenNums = set()
    for num in nums:
        if num in seenNums:
            return True
        seenNums.add(num)
    return False


#def containsDuplicate(nums: List[int]) -> bool:
# return len(set(nums)) < len(nums)

print(containsDuplicate([1,1,1,3,3,4,3,2,4,2]))