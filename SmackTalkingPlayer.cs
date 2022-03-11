using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer
    {
        public string Taunt { get; set;}

        public virtual void Play(){

            Console.WriteLine("Daddy needs a new pair of shoes!");
        }

        
    }
}