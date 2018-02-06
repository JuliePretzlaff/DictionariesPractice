using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesPractice
{
    public class StandardMembership : Membership
    {
        //fields
        //invisible


        //properties
        public int Cost { get; set; }


        //constructors
        public StandardMembership()
        {
            //default
        }

        public StandardMembership(int cost)
        {
            Cost = cost;
        }


        //methods
        public override void Activate()
        {
           // base.Activate();    // this would do everything that's in the virtual method: 
           //but instead, we copied and pasted from the base class:
            if (IsActive == false)
            {
                IsActive = true;
                Console.WriteLine("Standard membership has been activated.");
            }
            else
            {
                Console.WriteLine("Standard membership is already active.");
            }
        }
    }
}
