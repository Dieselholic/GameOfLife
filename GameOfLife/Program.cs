using GameOfLife;

class MainClass
{
    static void Main()
    {
        //var g = new Game((9, 9), (1, 2), (2, 2), (3, 2));
        //var g = new Game((9, 9), (1, 1), (1, 2), (2, 1), (2, 2));
        var g = new Game(12, 12, (0, 2), (1, 0), (1, 2), (2, 1), (2, 2));
        g.Run();
    }
}