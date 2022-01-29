using System;
using System.Linq;

namespace _1672._Richest_Customer_Wealth
{
    /*
     * https://leetcode.com/problems/richest-customer-wealth/
     * You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank.
     * Return the wealth that the richest customer has.
     * A customer's wealth is the amount of money they have in all their bank accounts. The richest customer is the customer that has the maximum wealth.
     */
    public static class Solution
    {
        public static int MaximumWealth(int[][] accounts)
        {
            return accounts.Max(x => x.Sum(y => y));
        }
    }
}
