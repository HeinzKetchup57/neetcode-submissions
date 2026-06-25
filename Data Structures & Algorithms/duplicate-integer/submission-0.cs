public class Solution {
    public bool hasDuplicate(int[] nums) {
        var myDict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (myDict.ContainsValue(nums[i])) {
                return true;
            }
            myDict.Add(i, nums[i]);
        }
        return false;
    }
}