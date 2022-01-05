using LeetCode75;
using LeetCode75.Helpers;
using NUnit.Framework;

namespace LeetCodeTest;

[TestFixture]
public class SolutionTests
{
    private Solution _solution;

    [SetUp]
    public void Setup()
    {
        //Arrange 
        _solution = new();
    }

    [Test]
    //return indices of the two numbers such that they add up to target
    public void TwoSum_GivenIntArrayAndTargetSum_ReturnIndicesOfTwoNumbers()
    {
        //Act 
        //[2,7,11,15]
        //9
        //[3,2,4]
        //6
        //[3,3]
        //6

        var result = _solution.TwoSum(new int[] {2, 7, 11, 15}, 9);
        // var result = _solution.TwoSum(new int[] {3, 2, 4}, 6);
        // var result = _solution.TwoSum(new int[] {3, 3}, 6);

        int[] expectedResult = new int[] {0, 1};

        //Assert
        Assert.That(expectedResult, Is.EqualTo(result));
    }

    [Test]
    public void AddTwoNumbers_GivenListNodeTwoNumbers_returnsListNodeSum()
    {
        //Arrange
        ListNode l1 = ListNode.ArrayToListNode(new[] {2, 4, 3});
        ListNode l2 = ListNode.ArrayToListNode(new[] {5, 6, 4});
        ListNode expectedResult = ListNode.ArrayToListNode(new[] {7, 0, 8});

        //Act 
        var result = _solution.AddTwoNumbers(l1, l2);
        //Assert

        Assert.That(expectedResult, Is.EqualTo(result));
    }
}