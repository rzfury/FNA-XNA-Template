namespace RZFNA.Game
{
    class Program
    {
        static void Main(string[] args)
        {
            using(Engine.Game game = new())
            {
                game.Window.Title = "RZFNA";
                game.Run();
            }
        }
    }
}
