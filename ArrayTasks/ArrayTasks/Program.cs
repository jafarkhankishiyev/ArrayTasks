// See https://aka.ms/new-console-template for more information

Task1([1, 0, 2, 4, 0, 5, 7]);
Task2([1, 2, 3, 0, 0, 0], [2, 5, 6], 3, 3);
Task3([3, 1, 4, 3], 3);
Task4([-1, -1, 0, 0, 1, 1, 4, 4, 4, 4, 4, 6, 6, 7, 7]);
Task5([10, 2, 5, 3]);
Task6([1, 2, 3, 4, 2, 1]);
Task7([1, 0, 10, 9, 0, 0, 12, 0]);
Task8([1, 12, 10, 4, 9, 2, 1]);
Console.Read();

static void Task1(int[] array)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("Task 1: Duplicate each occurence of 0\nInput: ");
    foreach (int i in array)
    {
        Console.Write($"{i} ");
    }
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == 0)
        {
            if(i != 0)
            {
                if (array[i-1] != 0)
                {
                    for(int j = 0; j < array.Length - i - 1; j++)
                    {
                        array[array.Length - j - 1] = array[array.Length - j - 2];
                    }
                }
            }
        }
    }
    Console.Write("\nOutput: ");
    foreach(int i in array)
    {
        Console.Write($"{i} ");
    }
} 
static void Task2(int[] nums1, int[] nums2, int m, int n)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write("\n\nTask 2: Merge 2 arrays in non-decreasing order\nFirst array: ");
    foreach(int i in nums1)
    {
        Console.Write(i + " ");
    }
    Console.Write("\nArray 2: ");
    foreach(int i in nums2)
    {
        Console.Write(i + " ");
    }
    int c = 0;
    for (int i = 0; i < m + n; i++)
    {
        if (nums1[i] == 0)
        {
            nums1[i] = nums2[c];
            c++;
        }
    }
    Console.Write("\nOutput: ");
    foreach(int i in nums1)
    {
        Console.Write(i + " ");
    }
}
static void Task3(int[] nums, int val)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    int k = 0;
    Console.Write($"\n\nTask 3: Remove all occurences of val, return number of vals\nInput: val = {val}, initial array: ");
    foreach(int i in nums)
    {
        Console.Write(i + " ");
    }
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == val)
        {
            nums[i] = -1;
            k++;
        }
    }
    for(int i = 0; i < k; i++)
    {
        nums[i] = k;
    }
    Console.Write($"\nOutput: k = {k}, array: ");
    foreach(int i in nums)
    {
        if(i == -1)
        {
            Console.Write("_ ");
        }
        else
        {
            Console.Write(i + " ");
        }
    }
}
static void Task4(int[] nums)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write("\n\nTask 4: Remove all duplicates from an array in non-ascending order\nInput: ");
    foreach(int i in nums)
    {
        Console.Write(i + " ");
    }
    int k = 0;
    for(int i = 0; i < nums.Length; i++)
    {
        for(int j = i + 1; j < nums.Length; j++)
        {
            if (nums[j] == nums[i])
            {
                nums[j] = -101;
            }
        }
    }
    foreach(int i in nums)
    {
        if(i != -101)
        {
            k++;
        }
    }
    for(int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == -101)
        {
            for(int j = nums.Length - 1; j > i; j--)
            {
                if (nums[j] != -101)
                {
                    nums[i] = nums[j];
                    nums[j] = -101;
                    break;
                }
            }
        }
    }
    Console.Write($"\nOutput: k = {k}, ");
    foreach (int i in nums)
    {
        if(i == -101)
        {
            Console.Write("_ ");
        }
        else
        {
            Console.Write(i + " ");
        }
    }
}
static void Task5(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write("\n\nTask 5: check if there are two indices where arr[i] = 2 * arr[j]\nInput: ");
    foreach (int i in arr)
    {
        Console.Write(i + " ");
    }
    bool checkArrCond = false;
    for(int i = 0;i < arr.Length;i++)
    {
        for (int j = 0; j < arr.Length;j++)
        {
            if(i != j && arr[i] == 2 * arr[j])
            {
                checkArrCond = true;
            }
        }
    }
    Console.Write("\nOutput: ");
    Console.Write(checkArrCond);
}
static void Task6(int[] arr)
{
    Console.ForegroundColor= ConsoleColor.Blue;
    Console.Write("\n\nTask 6: determine if the the array is \"mountain\"\nInput: ");
    foreach (int i in arr)
    {
        Console.Write(i + " ");
    }
    bool checkArrCond = false;
    if (arr.Length > 3)
    {
        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
            {
                checkArrCond = true;
                for(int j = i - 1; j >= 1; j--)
                {
                    if (arr[j] <= arr[j - 1])
                    {
                        checkArrCond = false;
                    }
                }
                for(int k = i + 1; k < arr.Length - 1; k++)
                {
                    if (arr[k] <= arr[k + 1])
                    {
                        checkArrCond = false;
                    }
                }
            }
        }
    }
    Console.Write("\nOutput: ");
    Console.Write(checkArrCond);
}
static void Task7(int[] nums)
{
    Console.ForegroundColor= ConsoleColor.Yellow;
    Console.Write("\n\nTask 7: move zeroes to the end\nInput: ");
    foreach (int i in nums)
    {
        Console.Write(i + " ");
    }
    for (int i = 0; i<nums.Length; i++)
    {
        if (nums[i] == 0)
        {
            for(int j = i + 1; j < nums.Length - 1; j++)
            {
                if (nums[j] != 0)
                {
                    //to do
                    nums[i] = nums[j];
                    nums[j] = 0;
                    break;
                }
            }
        }
    }
    Console.Write("\nOutput: ");
    foreach (int i in nums)
    {
        Console.Write($"{i} ");
    }
}

static void Task8(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("\n\nTask 8: replace every element with the highest to the right, -1 at the end\nInput: ");
    foreach (int i in arr)
    {
        Console.Write(i + " ");
    }
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr.Length - i > 1)
        {
            arr[i] = arr[i + 1];
            for(int j = i + 2;j < arr.Length - 1; j++)
            {
                if (arr[j] > arr[i])
                {
                    arr[i] = arr[j];
                }
            }
        }
        else
        {
            arr[i] = -1;
        }
    }
    Console.Write("\nOutput: ");
    foreach (int i in arr)
    {
        Console.Write($"{i} ");
    }
}