using System;

namespace ShootingDice
{
    // A Player who brings a large die to the game
    public class LargeDicePlayer : Player
    {
         public int largerDice { get; set; } = 20;
        public virtual void Play(){
            Console.WriteLine($"{largerDice}");


        }
           


        
        
        
       

        
            
        
    }
}