
using System.Runtime.CompilerServices;

Console.WriteLine("Vad heter du?");
String name = Console.ReadLine().ToUpper();

if(name == "ZION")
{
Console.WriteLine("ew...game over...");
}
else if(name == "ASTOLFO")
{
    Console.WriteLine("YOU WIN!!! WINNER WINNER CHICKEN DINNER!!!!! (give me one chance pleaseeeee)");
}
else if(name != "ZION")
{
    Console.WriteLine($"Welcome {name}! You are an adventure in a dire situation!");
    Console.WriteLine("You are currently facing against a wolf in a forest");
    Console.WriteLine("Behind you is a helpless girl which you need to protect.");
    Console.WriteLine("You wield a nearly blunt sword and your aspirations to become a Hero!");
    Console.WriteLine("Which do you want to use? Sword or aspirations?");

    string choice1 = Console.ReadLine().ToUpper();    

if (choice1 == "SWORD")
{
    Console.WriteLine("You take on a ready posture with your sword. Your firmly place your feet on the ground and stare at the two wolves.");
    Console.WriteLine("The wolf in front of you seems shacken for a bit but stays firm and seems ready to attack");
    Console.WriteLine("Do you attempt to attack the wolf or parry the wolf's attack?");

    string sword1 = Console.ReadLine().ToUpper();
if (sword1 == "ATTACK")
{
    Console.WriteLine("You swing your sword in a diagonal slash at the wolf");
    Console.WriteLine("The attack connects!");
    Console.WriteLine("Seeing blood fill your view fills you with glee for a moment.");
    Console.WriteLine("However the sword was too blunt to inflict any noticable damage to the wolf");
    Console.WriteLine("the wolf jumps behind you and kills the girl");
    Console.WriteLine("Do you want to cry or cry?");

    string cry = Console.ReadLine().ToLower();
if (cry == "cry")
{
    Console.WriteLine("You cry at your own failure.");
    Console.WriteLine("Wow, didn't i say the sword was blunt? fucking idiot. That innocent girl is now dead");
    Console.WriteLine("All because of you. Fucking despicable");
    Console.WriteLine("Game over. What a fucking joke. Enter to leave.");
    Console.WriteLine("Fuck off.");
}
}
else if (sword1 == "PARRY")
{
    Console.WriteLine("The wolf charges at you, baring it's fangs");
    Console.WriteLine("But you were prepared and parried it away");
    Console.WriteLine("The wolf gets pushed back and you see an oppurtunity to attack or run away with the girl");
    Console.WriteLine("Do you [Attack] the wolf in a moment of weakness or attempt to [run away] and save the helpless girl?");

string sword2 = Console.ReadLine().ToUpper();
if (sword2 == "ATTACK")
{
    Console.WriteLine("You swing your sword in a diagonal slash at the wolf");
    Console.WriteLine("The attack connects!");
    Console.WriteLine("Seeing blood fill your view fills you with glee for a moment.");
    Console.WriteLine("However the sword was too blunt to inflict any noticable damage to the wolf");
    Console.WriteLine("the wolf jumps behind you and kills the girl");
    Console.WriteLine("Do you want to cry or cry?");

    string cry = Console.ReadLine().ToUpper();
if (cry == "CRY")
{
    Console.WriteLine("You cry at your own failure.");
    Console.WriteLine("Wow, didn't i say the sword was blunt? fucking idiot. That innocent girl is now dead");
    Console.WriteLine("All because of you. Fucking despicable");
    Console.WriteLine("Game over. What a fucking joke. Enter to leave.");
    Console.WriteLine("Fuck off.");
}
}
else if (sword2 == "run away")
{
    Console.WriteLine("You tunr around to grab the girl and run");
    Console.WriteLine("You pick her up and make a dash out of the forest");
    Console.WriteLine("The wolf tries to chase you, however it was staggered from the parry");
    Console.WriteLine("You managed to save the girl. And that's what matters.");
    Console.WriteLine("You got the best ending.");
    Console.WriteLine("Press [Enter] to leave.");

}
}
}
else if (choice1 == "ASPIRATIONS")
{
    Console.WriteLine("Pffft, seriously?");
    Console.WriteLine("Sure, you like idk? tell the wolf that you want to be a hero");
    Console.WriteLine("wow shocker the wolf like, kills you.");
    Console.WriteLine("it doesn't understand english. What do you think we are? Disney?");
    Console.WriteLine("like there arent talking animals here. and look. now the girl is going to die too.");
    Console.WriteLine("here you got the [Worst ending] dumbass");
    Console.WriteLine("Enter to leave.");
    Console.WriteLine("Idiot");
}
}
Console.ReadLine();