namespace LeetCode75.Helpers;

public class ListNode
{
    public int Val;
    public ListNode Next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.Val = val;
        this.Next = next;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((ListNode) obj);
    }

    protected bool Equals(ListNode other)
    {
        if (Next == null && other.Next == null) return Val == other.Val;
        if (Next == null || other.Next == null) return false;
        return Val == other.Val && Next.Equals((object?) other.Next);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Val, Next);
    }

    public static ListNode ArrayToListNode(int[] list)
    {
        if (list.Length == 0) return null;
        ListNode res = new(list[0]);
        ListNode tempNode = res;

        for (int i = 1; i < list.Length; i++)
        {
            tempNode.Next = new(list[i]);
            tempNode = tempNode.Next;
        }

        return res;
    }
}