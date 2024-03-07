int[] arr = { 4, 8, 5, 9, 10, 12, 14, 3, 7, 11, 13 };
int[] arr2 = { 4, 8 };
bool checker = false;
for (int i = 0; i < arr2.Length; i++)
{
    checker = false;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j] == arr2[i])
        {
            checker = true;
            break;
        }

    }
    if (checker == false)
    {
        checker = false;
        break;
    }
}
Console.WriteLine(checker);
