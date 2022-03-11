using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // Override the Play method to make a Player who always roles one higher than the other player
    public class OneHigherPlayer : Player
    {
         public override void Play(Player other)
         {
            // Call roll for "this" object and for the "other" object
            int otherRoll = other.Roll();
            int myRoll = otherRoll+1;
             SmackTalkingPlayer smack=new SmackTalkingPlayer();
            Console.WriteLine($"{Name} rolls a {myRoll}");
            smack.Play();
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
              smack.Play();
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
             
         }
    }
}
