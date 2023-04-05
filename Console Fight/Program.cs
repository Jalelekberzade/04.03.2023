using System;

namespace Console_Fight
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
        
    }
    public class Character 
    {
        public string Name;
        public int Health;
        public int AttackPower;

        public void Attack() 
        { 
        }
        public void TakeDamage() 
        { 
        }
    }
     
    public class Player : Character
    {
        Attack();
    }
    public class Enemy : Character { }
}
