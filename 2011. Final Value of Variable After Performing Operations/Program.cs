public class Solution
{
    /*
     * https://leetcode.com/problems/final-value-of-variable-after-performing-operations/submissions/
     * 
     * ----------------------
     * 
     * There is a programming language with only four operations and one variable X:
     *
     * ++X and X++ increments the value of the variable X by 1.
     * --X and X-- decrements the value of the variable X by 1.
     * Initially, the value of X is 0.
     *
     * Given an array of strings operations containing a list of operations, return the final value of X after performing all the operations.
     * 
     * ----------------------
     * 
     * Submission:
     * 
     * Runtime: 76 ms, faster than 99.04% of C# online submissions for Final Value of Variable After Performing Operations.
     * Memory Usage: 40.3 MB, less than 6.90% of C# online submissions for Final Value of Variable After Performing Operations.
     */
    public int FinalValueAfterOperations(string[] operations)
    {
        var increments = operations.Count(x => x.Contains("++"));
        var decrements = operations.Count(x => x.Contains("--"));

        return increments - decrements;
    }
}