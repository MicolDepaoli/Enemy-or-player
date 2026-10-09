using blaisePascal.EnemyOrPlayer.Domain;
using BlaisePascal.LessonsExamples3E.Domain;

public class Program
{
    public static void Main()
    {
        try
        {
            Enemy enemy = new Enemy("Goblin", 100, 25);

            Console.WriteLine(enemy);

            Console.WriteLine($"is the enemy alive? {enemy.IsAlive()}");

            enemy.TakeDamage(30);

            Console.WriteLine(enemy);

            Console.WriteLine($"is the enemy alive? {enemy.IsAlive()}");

            Player player = new Player("Mario");

            player.AddExperience(156);
            int experience=player.Experience;

            Console.WriteLine($"experience after the game: {experience}");

            player.AddGold(50);
            Console.WriteLine($"player's gold: {player.Gold}");

            player.TakeDamage(30);

            player.Heal(20);

            player.TakeDamage(100);

            Console.WriteLine($"is the player alive? {player.IsAlive}");

            player.ResetHealth();

            player.ResetExperience();
            Console.WriteLine($"player's experience after reset: {player.Experience}");
            Console.WriteLine($"player's health after reset: {player.Health}");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");

        }
    }
}
