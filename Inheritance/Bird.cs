using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public bool HasBeak { get; set; }

        public bool HasHollowBones { get; set; }

        public string HowMuchFoodRegurgitated { get; set; }

        public int HowManyToes { get; set; }


    }
}
