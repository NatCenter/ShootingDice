using  System.Collections.Generic;
using System;
namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a  taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer:Player
    {

           public List<string> ListSmackTalk {get;set;}=new List<string>()
         {
             "I am sending you to the shadow realm ",
             "Time to go to heaven my child",
             "Looks like you have to wash the dishes for a week loser!!!"

           };
        public override int Roll()
        {
            int RandomeNumber=new Random().Next(ListSmackTalk.Count);
            Console.WriteLine(ListSmackTalk[RandomeNumber]);
           return base.Roll();

        }
           

            
    }
}