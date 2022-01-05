using LeetCode75.Helpers;

namespace LeetCode75;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> indexes = new();

        int i = 0;
        while (i < nums.Length)
        {
            int findnum = target - nums[i];
            if (indexes.ContainsKey(findnum))
                return new int[] { indexes[findnum], i };
            if (!indexes.ContainsKey(nums[i]))
                indexes.Add(nums[i], i);
            i++;
        }
        return new int[1];
    }
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode head = null;
        ListNode currNode = head;
        int carry = 0;

        while (l1 != null || l2 != null || carry > 0)
        {
            int val1 = (l1 == null) ? 0 : l1.Val;
            int val2 = (l2 == null) ? 0 : l2.Val;

            ListNode tempNode = new(val1 + val2 + carry);
            carry = 0;
            if (tempNode.Val >= 10)
            {
                carry = tempNode.Val / 10;
                tempNode.Val %= 10;
            }

            if (head == null)
                currNode = head = tempNode;
            else
            {
                currNode.Next = tempNode;
                currNode = currNode.Next;
            }

            if (l1 != null) l1 = l1.Next;
            if (l2 != null) l2 = l2.Next;
        }
        return head;
    }
}