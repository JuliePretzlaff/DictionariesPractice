using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesPractice
{
    public class VIPMembership : Membership
    {

        //fields
        //invisible

        //proeprties
        public bool IsSwanky { get; set; }


        //constructors
        public VIPMembership() //default constructors have no parameters (but can have something in the body)
        {
            //default
        }

        public VIPMembership(bool isSwanky)
        {
            this.IsSwanky = isSwanky;
        }


        //methods
        public override void Activate()
        {
            base.Activate();
            {
                Console.WriteLine("Your membership level is VIP.");
            }
        }
    }
}
