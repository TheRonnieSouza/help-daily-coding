namespace Help.LeetCode.Arrays
{
    public class ContainsDuplicate
    {

        public bool Solution(int[] nums)
        {
            var dic = new HashSet<int>();

            foreach (var num in nums)
            {
                if (dic.Contains(num))
                    return true;

                dic.Add(num);
            }
            return false;
        }
    }
}
