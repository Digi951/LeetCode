using System;
namespace LeetCode.MergeTwoSortedLists_Easy;

public class ListNode
{
    public Int32 Value { get; set; }

    public ListNode? Next { get; set; }

    public ListNode(Int32 value = 0, ListNode? next = null)
    {
        Value = value;
        Next = next;
    }
}
