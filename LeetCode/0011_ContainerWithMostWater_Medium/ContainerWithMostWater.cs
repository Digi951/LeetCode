using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode.ContainerWithMostWater_Medium;

public static class ContainerWithMostWater
{
    public static Int32 MaxArea(Int32[] height)
    {
        Int32 left = 0;
        Int32 right = height.Length - 1;   
        Int32 area = 0;     

        while (left < right)
        {           
            Int32 hLeft = height[left];
            Int32 hRight = height[right]; 
            Int32 distance = right - left;                 
            Int32 side = hLeft < hRight ? hLeft : hRight;        
            Int32 currentArea = side * distance;

            area = currentArea > area ? currentArea : area;

            if(hLeft < hRight)
            {
                left++;
            }
            else
            {
                right--;
            }
        }        

        return area;
    }
}