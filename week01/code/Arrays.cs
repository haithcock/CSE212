public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>

    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // STEPS
        // Step 1: Receive number and length. 
        // Step 2: Build out array from the number of multiples from received numbers. 
        // Step 3: Put number in slot 0, then the next number should be 2x the number
        // and the next number should be 3x the original number and so on for however 
        // many numbers filled the array
        // Step 4: Return array

        double[] multiples = new double[length];

    for (int i = 0; i < length; i++)
    {
        multiples[i] = number * (i + 1);
    }

    return multiples;// replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

 // STEPS (I will be using list slicing with GetRange):
    // 1) Let n = data.Count. Normalize the rotation by k = amount % n.
    //    - If k == 0, the list stays the same → return.
    // 2) Take the last k elements (the "tail"): data.GetRange(n - k, k).
    // 3) Take the first n - k elements (the "head"): data.GetRange(0, n - k).
    // 4) Clear the original list, then add tail first, then head (in-place rotation).

    if (data == null || data.Count == 0) return;

    int n = data.Count;
    int k = amount % n;
    if (k == 0) return; 
  
    List<int> tail = data.GetRange(n - k, k);
    List<int> head = data.GetRange(0, n - k);

    data.Clear();
    data.AddRange(tail);
    data.AddRange(head);
}


    }

