using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Miscellanies
{
    class Battle
    {
        private Hero myhero;
        private List<Character> Monster;

        public Battle(Hero myhero, List<Character> Monster)
        {
            // TODO: Complete member initialization
            this.myhero = myhero;
            this.Monster = Monster;
        }
    }
}
