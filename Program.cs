using System;
using System.Collections.Generic;

namespace Lab5._1RPG
{
    class GameCharacter
    {
        public GameCharacter(string aName, int aStrength, int aIntelligence)
        {
            Name = aName;
            Strength = aStrength;
            Intelligence = aIntelligence;

        }
        private string name;
        private int strength;
        private int intelligence;

        public string Name { get { return name; } set{ name = value; } }
        public int Strength { get { return strength; } set { strength = value; } }
        public int Intelligence { get { return intelligence; } set { intelligence = value; } }

        public virtual void Play()
        {
            Console.WriteLine($"{name} has a strength of {strength} and intelligence of {intelligence}.");
        }
    }

    class Warrior : GameCharacter
    {
        public Warrior(string aName, int aStrength, int aIntelligence, string aWeaponType) : base (aName, aStrength, aIntelligence)
        {
            Name = aName;
            Strength = aStrength;
            Intelligence = aIntelligence;
            WeaponType = aWeaponType;
        }

        private string weaponType;

        public string WeaponType { get { return weaponType; } set { weaponType = value; } }


        public override void Play()
        {
            Console.WriteLine($"{Name} has a strength of {Strength}, intelligence of {Intelligence}, and a {WeaponType} for a weapon.");
        }
    }

    class MagicUsingCharacter : GameCharacter
    {
        public MagicUsingCharacter(string aName, int aStrength, int aIntelligence, int aMagicalEnergy) : base (aName, aStrength, aIntelligence)
        {
            Name = aName;
            Strength = aStrength;
            Intelligence = aIntelligence;
            MagicalEnergy = aMagicalEnergy;
        }

        private int magicalEnergy;
        public int MagicalEnergy { get { return magicalEnergy; } set { magicalEnergy = value; } }
        public override void Play()
        {
            Console.WriteLine($"{Name} has a strength of {Strength}, intelligence of {Intelligence}, and magical energy of {MagicalEnergy}.");
        }
    }

    class Wizard : MagicUsingCharacter
    {
        public Wizard(string aName, int aStrength, int aIntelligence, int aMagicalEnergy, int aSpellNumber) : base (aName, aStrength, aIntelligence, aMagicalEnergy)
        {
            Name = aName;
            Strength = aStrength;
            Intelligence = aIntelligence;
            MagicalEnergy = aMagicalEnergy;
            SpellNumber = aSpellNumber;
        }

        private int spellNumber;
        public int SpellNumber { get { return spellNumber; } set { spellNumber = value; } }
        public override void Play()
        {
            Console.WriteLine($"{Name} has a strength of {Strength}, intelligence of {Intelligence}, magical energy of {MagicalEnergy}, and uses {SpellNumber} different spells.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to World of Dev.Buildcraft!");

            List<GameCharacter> characters= new List<GameCharacter>();

            characters.Add(new Wizard("Harry Potter", 10, 8, 4, 6));
            characters.Add(new Warrior("Thor", 11, 2, "Hammer"));
            characters.Add(new Warrior("Superman", 6, 7, "Sword"));
            characters.Add(new Warrior("Kyle", 18, 25, "Rubber Chicken"));
            characters.Add(new Wizard("Drako Malfoy", 9, 3, 7, 2));


            foreach (var item in characters)
            {
                item.Play();
            }
        }
    }
}
