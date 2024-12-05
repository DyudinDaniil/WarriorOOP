using System;
using System.IO;

namespace WarriorOOP
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            Whizzard warrior1 = new Whizzard("Someone", 6, 2, 100);
            Knight warrior2 = new Knight("Someone1", 2, 2, 200);
            warrior1.Cast();
            warrior2.Ulta();
            warrior1.ShowInfo();
            warrior2.ShowInfo();
        }
    }



    class Warrior
    {
        protected string _name;
        protected int _strength;
        protected int _armor;
        protected int _health;

        public Warrior(string name, int strength, int armor, int health)
        {
            _name = name;
            _strength = strength;
            _armor = armor;
            _health = health;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Имя: {_name}; сила: {_strength}; броня: {_armor}; здоровье: {_health}");
        }
    }

    class Knight : Warrior
    {

        public Knight(string name, int strength, int armor, int health) : base(name, strength, armor, health) { }

        public void Ulta()
        {
            _health += 20;
            _strength += 3;
        }
    }

    class Whizzard : Warrior
    {

        public Whizzard(string name, int strength, int armor, int health) : base(name, strength, armor, health) {}

        public void Cast()
        {
            _armor += 20;
        }
    }
}