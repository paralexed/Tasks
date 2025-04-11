namespace Tasks.Tasks.Easy;

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0; i < nums.Length; ++i){
            for(int k = i + 1; k < nums.Length; ++k){
                if((nums[i] + nums[k]) == target){
                    return [i,k];
                }
            }
        }
        return default;
    }
}