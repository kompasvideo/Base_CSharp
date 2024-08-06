int[] nums = { 54, 7, -41, 2, 4, 89, 33, -5, 12 };

// сортировка
for (int i = 0; i < nums.Length; i++)
{
    for (int j = 0; j < nums.Length; j++)
    {
        if (nums[i] > nums[j])
            (nums[i], nums[j]) = (nums[j], nums[i]);
    }
}

// вывод
Console.WriteLine("вывод отсортированного массива");
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}
