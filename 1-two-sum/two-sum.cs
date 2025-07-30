public class Solution 
{
    public int[] TwoSum(int[] nums, int target) {
        int[] result = new int[2];
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j) 
                { 
                    continue; 
                }
                if (nums[i] + nums[j] == target)
                {
                    result[0] = i;
                    result[1] = j;
                    return result;
                }
            }
        }
        return result;
    }   
}