// Given an array of integers nums and an integer target, 
// return indices of the two numbers such that they add up to target.
// You may assume that each input would have exactly one solution, 
// and you may not use the same element twice.
// You can return the answer in any order.

// Example 1:
// Input: nums = [2,7,11,15], target = 9
// Output: [0,1]
// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

// Example 2:
// Input: nums = [3,2,4], target = 6
// Output: [1,2]

// Example 3:
// Input: nums = [3,3], target = 6
// Output: [0,1]

List<int> TwoSum(int[] nums, int target)
{
    List<int> result = new List<int>(2);
    int len = nums.Length;
    for (int k = 0; k < len; k++)
    {
        for (int i = k + 1; i < len; i++)
        {
            if (nums[k] + nums[i] == target && k != i)
            {
                result.Add(k);
                result.Add(i);
                return result;
            }
        }
    }
    return result;
}

int[] nums = { 2,3,5,2,5,0 };
int target = 7;
List<int> res = TwoSum(nums, target);
System.Console.WriteLine($" [{string.Join("; ", res)}]");