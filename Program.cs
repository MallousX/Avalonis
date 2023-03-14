class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the console game!");

        int playerHealth = 100;
        int playerXP = 0;
        int playerLevel = 1;
        int playerDamage = 10; // Starting player damage

        // Game loop
        while (playerHealth > 0)
        {
            // Generate a new enemy
            int enemyHealth = new Random().Next(20, 50);
            Console.WriteLine("A new enemy appears! Health: " + enemyHealth);

            // Fight the enemy
            while (enemyHealth > 0 && playerHealth > 0)
            {
                // Display player and enemy health
                Console.WriteLine("Player health: " + playerHealth);
                Console.WriteLine("Enemy health: " + enemyHealth);

                // Players move
                Console.WriteLine("Choose your move (1-3):");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Heal");
                Console.WriteLine("3. Run away");
                Console.WriteLine("4. Cheat");

                int playerMove = int.Parse(Console.ReadLine());

                if (playerMove == 1)
                {
                    // attack enemy
                    int damage = new Random().Next(playerDamage, playerDamage + 10); // Player deals random damage between their base damage and base damage + 10
                    enemyHealth -= damage;
                    Console.WriteLine("You deal " + damage + " damage to the enemy.");
                }
                else if (playerMove == 2)
                {
                    //heals
                    int healAmount = new Random().Next(10, 20);
                    playerHealth += healAmount;
                    Console.WriteLine("You heal " + healAmount + " health.");
                }
                else if (playerMove == 3)
                {
                    // run away
                    Console.WriteLine("You run away from the enemy.");
                    break;
                }

                // Check if the enemy is defeated
                if (enemyHealth <= 0)
                {
                    // Add XP 
                    Console.WriteLine("Congratulations! You have defeated the enemy.");
                    playerXP += 10;

                    // Check if player has leveled up
                    if (playerXP >= 50 * playerLevel)
                    {
                        playerLevel++;
                        Console.WriteLine("You have leveled up to level " + playerLevel + "!");

                        // Increase damage and health
                        playerDamage += 5;
                        playerHealth += 20;
                    }

                    // Generate new enemy
                    enemyHealth = new Random().Next(20, 50);
                    Console.WriteLine("A new enemy appears! Health: " + enemyHealth);
                }
                else
                {
                    // Enemy attack
                    int enemyDamage = new Random().Next(5, 15);
                    playerHealth -= enemyDamage;
                    Console.WriteLine("The enemy deals " + enemyDamage + " damage to you.");
                }
            }

            // Check if the player is still alive
            if (playerHealth <= 0)
            {
                Console.WriteLine("Game over! You have been defeated.");
                break;
            }
        }

        // Display player stats
        Console.WriteLine("Player stats:");
        Console.WriteLine("Level: " + playerLevel);
        Console.WriteLine("XP: " + playerXP);
    }
}