int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;

}




int num_1 = 1;
int num_2 = 344;
int num_3 = 24523;
int num_4 = 3465;
int num_5 = 23455;
int num_6 = 2345134;
int num_7 = 12;
int num_8 = 3555;
int num_9 = 2;

// int max1 = Max(num_1, num_2, num_3);
// int max2 = Max(num_4, num_5, num_6);
// int max3 = Max(num_7, num_8, num_9);
// int max = Max(max1, max2, max3);

int max = Max(
    Max(num_1, num_2, num_3),
    Max(num_4, num_5, num_6),
    Max(num_7, num_8, num_9));

Console.WriteLine(max);