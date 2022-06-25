using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroandV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string HeroName = "All Might";
            int HeroAge = 50;
            string heroSuperPower = " One For All";
            int heroHeight = 220;
            int heightplus = heroHeight + 5;

            string villainName = "All For One";
            int villainAge = 100;
            string villainSuperPower = "All For One";
            int vililanHeight = 195;
            string villainSuperPower2 = "none";

            int ageDifference = HeroAge - villainAge;

            Console.WriteLine("I am " + HeroName + " my power is " + heroSuperPower + " and my age is " + HeroAge +"and my height is "+ heroHeight);
            Console.WriteLine("I am " + villainName + " my power is " + villainSuperPower + " and my age is " + villainAge);
            Console.WriteLine(ageDifference);
            Console.WriteLine("I am " + HeroName + " my power is " + heroSuperPower + " and my age is " + HeroAge + "and my height is " +heightplus);
            Console.WriteLine("I am " + villainName + " my power is " + villainSuperPower2 + " and my age is " + villainAge+ "and my height is "+ vililanHeight);


        }
    }
}
