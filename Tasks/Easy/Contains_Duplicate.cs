namespace Tasks.Tasks.Easy;

public class Contains_Duplicate
{
    public bool ContainsDuplicate(int[] nums) {
        return !Enumerable.SequenceEqual(nums, nums.ToHashSet());
    }
}