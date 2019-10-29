using System;

namespace GameComponents
{
    class Player
    {
        private int health;

        private int mana;
        private int magicDamage;

        private int rageMeter;
        private int oneHandDamage;

        private int[] position = new int[2];

        public int takeDamage(int damage)
        {
            return health - damage;
        }
    }
    class NPC
    {
        private int id = 0;
        private Player player;
        
    }
    class Enemy : NPC
    {
        private int health;
        public int DoDamage(int damage)
        {
            return health - damage;
        }
    }
    class Ork : Enemy
    {
        private double rageMeter;
        private double oneHandDamage;
    }
    class DarkWizard : Enemy
    {
        private double mana;
        private double magicDamage;
        
    }
    class LightWizard : NPC
    {
        private double mana;
        private double magicDamage;
    }
}