// See https://aka.ms/new-console-template for more information
//int[,] array2D = new int[3, 3];

//int[,,] array3D = new int[3, 3, 3];

//int[,,] array3DInit =
//{
//   {
//        {"000","000"},
//        {"000","000"}
//    },
//   {
//        {"000","000"},
//        {"000","000"}
//    },
//   {
//        {"000","000"},
//        {"000","000"}
//    },
//};

//int[,] array2DInit = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };


////Console.WriteLine(array2DInit[2,0]);

//string[,] tictac = new string[3, 3];

//string[,] tictacinit = { 

//    { "X", "O", "X" }, 
//    { "O", "X", "O" }, 
//    { "X", "O", "X" } 
//};

//string tic0 = tictacinit[0, 0];
//string tic1 = tictacinit[0, 1];
//string tic2 = tictacinit[0, 2];
//string tic3 = tictacinit[1, 0];
//string tic4 = tictacinit[1, 1];
//string tic5 = tictacinit[1, 2];
//string tic6 = tictacinit[2, 0];
//string tic7 = tictacinit[2, 1];
//string tic8 = tictacinit[2, 2];
//string pipe = "|";


//Console.WriteLine($"{pipe}{tic0}{pipe}{tic1}{pipe}{tic2}{pipe}\n{pipe}{tic3}{pipe}{tic4}{pipe}{tic5}{pipe}\n{pipe}{tic6}{pipe}{tic7}{pipe}{tic8}{pipe}");

int[,] array2D = new int[3, 3];

int[,] array2DInit = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

int sum1 = array2DInit[0, 0] + array2DInit[0, 1] +array2DInit [0, 2];
int sum2 = array2DInit[1, 0] + array2DInit[1, 1] + array2DInit[1, 2];
int sum3 = array2DInit[2, 0] + array2DInit[2, 1] + array2DInit[2, 2];

Console.WriteLine(sum1);
Console.WriteLine(sum2);
Console.WriteLine(sum3);