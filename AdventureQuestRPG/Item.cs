using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AdventureQuestRPG
{
    public abstract class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    [Serializable] //Serialization is the process of converting an object into a format that can be stored or transmitted and then reconstructed later.
    public class Weapon : Item
    {
        public int AttackBoost { get; set; }
    }

    [Serializable]
    public class Armor : Item
    {
        public int DefenseBoost { get; set; }
    }

    [Serializable]
    public class Potion : Item
    {
        public int HealthBoost { get; set; }
    }
}