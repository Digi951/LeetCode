using System;
using LeetCode.MergeTwoSortedLists_Easy;

namespace LeetCode.MergeTwoSortedLists_Easy;

public static class Solution
{
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {

        var resultNode = new ListNode(0);
        ListNode currentNode = resultNode;

        // Run throw both lists, set the smaller node to the currentNode and go to the next node of the choosen list
        while (list1 != null && list2 != null)
        {
            if (list1.Value < list2.Value)
            {
                currentNode.Next = list1;
                list1 = list1.Next;
            }
            else
            {
                currentNode.Next = list2;
                list2 = list2.Next;
            }

            currentNode = currentNode.Next;
        }

        // If one list remains, add the last nodes to the currentNode
        if (list1 != null)
        {
            currentNode.Next = list1;
        }

        if (list2 != null)
        {
            currentNode.Next = list2;

        }

        return resultNode.Next;

    }
}

