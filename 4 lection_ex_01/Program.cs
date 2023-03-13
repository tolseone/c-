                  //
// string[,] table = new string[2, 5];
// //String.Empty
// // rable[0,0] // rable[0,1] // rable[0,2] // rable[0,3] // rable[0,4]
// // rable[1,0] // rable[1,1] // rable[1,2] // rable[1,3] // rable[2,4]

// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows ++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }
int[,] martix = new int[3, 4];

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < martix.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,10);
        }
    }
}

PrintArray(martix);
FillArray(martix);
Console.WriteLine();
PrintArray(martix);