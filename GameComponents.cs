using System;

namespace GameComponents
{
    class Player
    {
        private int health;
        private int mana;
        private int magicDamage = 10;
        private int magicRange = 10;
        private int rageMeter = 0;
        private int oneHandDamage = 15;
        private int[] position = new int[2];
        
        public Player(int startHealth, int startMana, int x, int y)
        {
            health = startHealth;
            mana = startMana;
            position[0] = x;
            position[1] = y;
        }
        // taking damage
        public int TakeDamage(int damage)
        {
            return health - damage;
        }
        public int Burn(int burnDamage)
        {
            // this should make the player burn for a period
            return health;
        }

        // effects from fighting eg less mana or more rage
    }
    class NPC
    {
        private int id = 0;
        private Player player;
        private int health;
        private int[] position;

        //public NPC(int npcHealth, int x, int y)
        //{
        //    health = npcHealth;
        //    position[0] = x;
        //    position[1] = y;
        //}
        public int TakeDamage(int damage)
        {
            return health - damage;
        }
    }
    class Enemy : NPC
    {
        public void DealDamage(int damage)
        {

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
        // should check range if can melee use magic
    }
    class LightWizard : NPC
    {
        private double mana;
        private double magicDamage;
        //should be able to heal the player
    }
}