namespace RZEngine.Game
{
    class Program
    {
        static void Main(string[] args)
        {
            using(Core.Game game = new())
            {
                game.Window.Title = "RZEngine";
                game.Run();
            }
        }
    }
}
