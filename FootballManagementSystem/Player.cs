using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FootballManagementSystem
{

    internal class Player : APlayer
    {
        /*
        public string Name;
        public int Age;
        public int attack;
        public int defense;
        public int stamina;
        public int speed;
        public int power;
        */

        public override void GetInfo()
        {
            //Console.WriteLine("Name |   Age |   Attack  |   Defense |   Stamina |   Speed   |   Power");
            Console.WriteLine("{0}  |   {0} |   {0} |   {0} |   {0} |   {0} |   {0} |   {0}", Name, Age, Attack, Defense, Stamina, Speed, Power);
            /*
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Attack: {0}", Attack);
            Console.WriteLine("Defense: {0}", Defense);
            Console.WriteLine("Stamina: {0}", Stamina);
            Console.WriteLine("Speed: {0}", Speed);
            Console.WriteLine("Power: {0}", Power);
            */
        }
    }
}


