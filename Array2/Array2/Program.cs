//1

//int[,] array =
//{
//    {20,45,70 },
//    {120,230,55 },
//    {300,250,170 }
//};
//for  (int i = 0;i<array.GetLength(0);i++)
//{
//    for (int j = 0;j<array.GetLength(1);j++)
//    {
//        Console.Write(array[i,j] + " ");
//    }
//    Console.WriteLine();
//}


//2

//int sum = 0;
//int[,] array =
//{
//   {40,120,200},
//   {130,320,40},
//   {220,55,100}
//};

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++) 
//    {
//        sum += array[i, j];
//    }
//}
//Console.WriteLine(sum);


//3


//int sum = 0;
//int[,] array =
//{
//   {70,160,400},
//   {130,80,35},
//   {170,55,100}
//};
//for  (int i = 0; i < array.GetLength(0); i++)
//{
//    int j = 0;
//    sum += array[i,j];
//}
//Console.WriteLine(sum);



//4


//int[,] array =
//{
//    {-20,45,70 },
//    {120,-230,55 },
//    {-300,250,-170 }
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//      if (array[i,j]<0)
//        {
//            Console.WriteLine(array[i,j]);
//        }
//    }
//}


//5


//int[,] array = 
//{
//            { 1, 3, 5 },
//            { 2, 4, 6 },
//            { 8, 0, 9 }
//};

//{
//    int min = array[0, 0];
//    int max = array[0, 0];

//    foreach (int element in array)
//    {
//        if (element < min)
//            min = element;
//        if (element > max)
//            max = element;
//    }
//    Console.WriteLine("Minimum element: " + min);
//    Console.WriteLine("Maximum element: " + max);
//}


//6

int[,] array = {
{ 33, 64, -10 },
            { 22, 45, -87 },
            { 70, -51, 96 }
        };

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        if (array[i, j] > 0)
        {
            if (array[i, j] % 2 == 0)
            {
                array[i, j] = 2;
            }
            else
            {
                array[i, j] = 1;
            }
        }
        else
        {
            if (array[i, j] % 2 == 0)
            {
                array[i, j] = -2;
            }
            else
            {
                array[i, j] = -1;
            }
        }
    }
}


for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}





//7


//int[,] array =
//{
//     { 10, 3, 5 },
//     { 2, 60, 120 },
//     { 7, 200, 90 }
//     { 40,80,180 }
//};
//for (int j = 0; j < array.GetLength(1); j++)
//{
//    array[1, j] = 0;
//}
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}


//8



//int[,] array =
//{
//     { 10, 3, 5 },
//     { 2, 40, 120 },
//     { 7, 100, 90 }
//};
//for (int j = 0; j < array.GetLength(1); j++)
//{
//    array[2, j] = 0;
//}
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(0); j++)
//    {
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}


//9


//int[,] array =
//    {
//            { 1, 2, 3 },
//            { 4, 5, 6 },
//            { 7, 8, 9 }
//    };
//int sum = 0;
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    sum += array[i, i];
//}
//Console.WriteLine("Sol diaqonaldaki ededlerin cemi: " + sum);


//10

//int[,] array =
//    {
//            { 1, 2, 3 },
//            { 4, 5, 6 },
//            { 8, 6, 9 }
//    };
//int sum = 0;
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    sum += array[i, (array.GetLength(1) - 1) - i];
//}
//Console.WriteLine("Sag diaqonaldaki ededlerin cemi: " + sum);


//11



//int[,] array = {
//            { 1, 2, 3, 4, 5 },
//            { 6, 7, 8, 9, 10 },
//            { 11, 12, 13, 14, 15 },
//            { 16, 17, 18, 19, 20 },
//            { 21, 22, 23, 24, 25 }
//        };
//for (int i = 1; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < i; j++)
//    {
//        array[i, j] = 0;
//    }
//}
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}


//12


//int[,] array = {
//            { 1, 2, 3, 4, 5 },
//            { 6, 7, 8, 9, 10 },
//            { 11, 12, 13, 14, 15 },
//            { 16, 17, 18, 19, 20 },
//            { 21, 22, 23, 24, 25 }
//        };
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = i + 1; j < array.GetLength(1); j++)
//    {
//        array[i, j] = 0;
//    }
//}
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}



//13



//int[,] array1 = {
//            {3,2,1},
//            {8,5,4},
//            {8,1,9}
//        };

//int[,] array2 = {
//            {5,3,7},
//            {2,8,4},
//            {4,5,1}
//        };
//int n = array1.GetLength(0);
//int[,] array3 = new int[n,n];

//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        array3[i, j] = array1[i, j] + array2[i, j];
//    }
//}
//Console.WriteLine("cemi:");
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        Console.Write(array3[i, j] + "\t");
//    }
//    Console.WriteLine();
//}




//14




//int[,] array =
//{
//    {8,11,3 },
//    {7,12,6 },
//    {13,4,9 }
//};
//for (int i = 0;i<array.GetLength(0);i++)
//{
//    int sum = 0;
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        sum += array[i, j];
//    }
//    Console.WriteLine(sum);
//}


//15


//int[,] array =
//        {
//            {8, 11, 3 },
//            {7, 12, 6 },
//            {13, 4, 9 }
//        };

//int n = array.GetLength(0);
//int[] sum = new int[n];

//for (int i = 0; i < n; i++)
//{
//    sum[i] = 0;
//    for (int j = 0; j < n; j++)
//    {
//        sum[i] += array[j, i];
//    }
//    Console.WriteLine("Sutun {0} cemi: {1}", i + 1, sum[i]);
//}


////16

//int[,] array =
//{
//    {1,1,5,0,1,1,},
//    {1,1,5,0,1,1,},
//    {1,1,5,0,1,1,},
//    {1,1,5,0,1,1,}
//};
//int shift = 3;
//for (int i = 0; i < array.GetLength(0); i++)
//{
//        for (int j = array.GetLength(1)-1;j>=0; j--)
//    {
//        if (j - shift >= 0)
//        {
//            array[i, j] = array[i, j - shift];
//        }
//        else
//            array[i, j] = 0;
//    }

//}
//for (int i = 0;i < array.GetLength(0); i++)
//{
//    for(int j = 0; j < array.GetLength(1); j++)
//    { Console.Write($"{array[i,j]}"); }
//    Console.WriteLine();
//}



//17



//int[,] array1 = {
//            {1, 2, 3},
//            {4, 5, 6},
//            {7, 8, 9}
//        };

//int[,] array2 = {
//            {9, 8, 7},
//            {6, 5, 4},
//            {3, 2, 1}
//        };

//int n = array1.GetLength(0);
//int[,] array3 = new int[n, n];
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        array3[i, j] = array1[i, j] * array2[i, j];
//    }
//}
//Console.WriteLine("Çarpım Dizisi:");
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        Console.Write(array3[i, j] + "\t");
//    }
//    Console.WriteLine();
//}




//18



//bool iscomplex = false;
//int[,] array =
//{
//    {7,4,1},
//    {8,5,2},
//    {9,4,1}
//};
//for (int i = 0; i<array.GetLength(0);i++)
//{
//    for(int j = 0;j<array.GetLength(1);j++)
//    {
//        if (array[i,j] <= 1)
//        {
//            continue;
//        }
//        else
//        {
//            iscomplex = false;
//            int squareroot = Convert.ToInt32(Math.Sqrt(array[i,j]));
//            for (int k = 2;k<squareroot;k++)
//            {
//                if (array[i,j]%k==0)
//                {
//                    iscomplex |= true;
//                }
//            }
//        }if (!iscomplex)
//        {
//            Console.WriteLine(array[i, j]);
//        }
//    }
//}
