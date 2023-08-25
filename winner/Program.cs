namespace winner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many game won");
            int gamewon = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many game drawn");
            int gamedrawn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many game lost");
            int gamelost = Convert.ToInt32(Console.ReadLine());

            int totalgame = gamewon + gamedrawn + gamelost;
            int totalpoints = (gamewon * 3) + (gamedrawn * 1) +(gamelost * 0);

            Console.WriteLine("total number of game" + totalgame);
            Console.WriteLine("total points gate" + totalpoints);
        }
    }
}