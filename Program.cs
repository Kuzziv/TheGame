using WorldOfPain.Models.Character;
using WorldOfPain.Models.Environment;
using WorldOfPain.Services;

Console.WriteLine("Welcome to the game");


// make the world
World world = new World(25, 25);


// make the game manager
GameManager gameManager = new GameManager(world);


// make the monster
Creature creature1 = new Creature("Orc nigga", 100, 10, 10, 10, 10, null);
Creature creature2 = new Creature("Orc dude", 100, 10, 10, 10, 10, null);


// add the monster to the worlds
world.AddCreature(creature1);
world.AddCreature(creature2);


// run the game
gameManager.StartGame();
