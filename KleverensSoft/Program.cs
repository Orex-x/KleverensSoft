using KleverensSoft;

CallTask1();

CallTask2();

CallTask3();

void CallTask3()
{
    Console.WriteLine("--------------Задание 3--------------");
    Task3.Start();
}

void CallTask2()
{
    Console.WriteLine("--------------Задание 2--------------");
    //var mtx = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12} };
    //var mtx = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
    var mtx = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12} };

    int[] result = Task2.SpiralOrder(mtx);

    Console.WriteLine(string.Join(", ", result));

}


void CallTask1()
{
    Console.WriteLine("--------------Задание 1--------------");
    var s = "sccvvvvddsllq";
    Console.WriteLine(s);
    s = Task1.CompressString(s);
    Console.WriteLine(s);
    s = Task1.DecompressString(s);
    Console.WriteLine(s);
}