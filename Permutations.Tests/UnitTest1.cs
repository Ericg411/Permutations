namespace Permutations.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;
    public UnitTest1() 
    {
        _test = new Class1();
    }

    [TestMethod]
    public void TestMethod1()
    {
        int[] nums = { 1, 2, 3 };
        IList<IList<int>> result = _test.Permute(nums);
        IList<IList<int>> answer = new List<IList<int>>();
        answer.Add(new List<int>() { 1, 2, 3});
        answer.Add(new List<int>() { 1, 3, 2});
        answer.Add(new List<int>() { 2, 1, 3});
        answer.Add(new List<int>() { 2, 3, 1});
        answer.Add(new List<int>() { 3, 1, 2});
        answer.Add(new List<int>() { 3, 2, 1});

        bool isTrue = true;

        for (int i = 0; i < result.Count; i++)
        {
            for (int j = 0; j < result[i].Count; j++)
            {
                if (answer[i][j] != result[i][j])
                {
                    isTrue= false;
                }
            }
        }

        Assert.IsTrue(isTrue);
    }  
    
    [TestMethod]
    public void TestMethod2()
    {
        int[] nums = { 0, 1 };
        IList<IList<int>> result = _test.Permute(nums);
        IList<IList<int>> answer = new List<IList<int>>();
        answer.Add(new List<int>() { 0, 1});
        answer.Add(new List<int>() { 1, 0});

        bool isTrue = true;

        for (int i = 0; i < result.Count; i++)
        {
            for (int j = 0; j < result[i].Count; j++)
            {
                if (answer[i][j] != result[i][j])
                {
                    isTrue= false;
                }
            }
        }

        Assert.IsTrue(isTrue);
    }  
    
    [TestMethod]
    public void TestMethod3()
    {
        int[] nums = { 1 };
        IList<IList<int>> result = _test.Permute(nums);
        IList<IList<int>> answer = new List<IList<int>>();
        answer.Add(new List<int>() { 1 });

        bool isTrue = true;

        for (int i = 0; i < result.Count; i++)
        {
            for (int j = 0; j < result[i].Count; j++)
            {
                if (answer[i][j] != result[i][j])
                {
                    isTrue= false;
                }
            }
        }

        Assert.IsTrue(isTrue);
    }
}