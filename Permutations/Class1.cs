namespace Permutations;
public class Class1
{

    public IList<IList<int>> Permute(int[] nums)
    {
        IList<IList<int>> permutations = new List<IList<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            Combination(nums, i, permutations, new List<int>());
        }

        return permutations;
    }

    public void Combination(int[] nums, int currentIndex, IList<IList<int>> list, IList<int> contains)
    {
        contains.Add(nums[currentIndex]);

        if (contains.Count == nums.Length) list.Add(contains);
        else
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (i != currentIndex && contains.Contains(nums[i]) == false)
                {
                    Combination(nums, i, list, new List<int>(contains));
                }
            }
        }
    }
}
