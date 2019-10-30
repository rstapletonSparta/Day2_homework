using System;

namespace GameComponents
{
    class Map
    {
        private int mapWidth;
        private int mapHeight;
        public Map(int mapWidth, int mapHeight)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
        }
    }
    class Player
    {
        private int health;
        private int mana;
        private int magicDamage = 10;
        private int magicRange = 10;
        private int rageMeter = 0;
        private int oneHandDamage = 15;
        private int[] position = new int[2];
        
        public Player(int health, int mana, int x, int y)
        {
            this.health = health;
            this.mana = mana;
            this.position[0] = x;
            this.position[1] = y;
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
        private int health;
        private int x;
        private int y;

        public int Health { get => health; set => health = value; }
        public int Y { get => y; set => y = value; }
        public int X { get => x; set => x = value; }
        public NPC()
        {
        }
        public NPC(int health, int x, int y)
        {
            this.Health = health;
            this.X = x;
            this.Y = y;
        }
        public int TakeDamage(int damage)
        {
            return health - damage;
        }
    }
    class Enemy : NPC
    {
        string typeOf;
        public Enemy()
        {

        }
        public Enemy(string typeOf,int health, int x, int y)
            : base (health, x, y)
        {
            this.typeOf = typeOf;
        }
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
        public DarkWizard(string typeOf, int health, int x, int y, int mana, int magicDamage, int magicRange)
            : base (typeOf, health, x, y)
        {
            this.mana = mana;
            this.magicDamage = magicDamage;
            this.magicRange = magicRange;
        }
        private int mana;
        private int magicDamage;
        private int magicRange;
        // should check range if can melee use magic
    }
    class LightWizard : NPC
    {
        private double mana;
        private double magicDamage;
        //should be able to heal the player
    }
}