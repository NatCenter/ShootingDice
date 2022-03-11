using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number  for a roll
    
    public class HumanPlayer : Player
    {
        public override void Play(Player other){
         Console.Write("Enter a new number");

        int playerNumber=int.Parse(  Console.ReadLine());
        Console.WriteLine(playerNumber);
        
         

        }
        

    }
       
}