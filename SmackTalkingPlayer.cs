using System;
using System.Collections.Generic;

namespace ShootingDice
{
   

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer: Player
    {
        public string Taunt { get; set;}

       public override int Roll()
       {
           Console.WriteLine("Winner winner chicken dinner");
           return base.Roll();
           
       }
            
        

        
    }
}