
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Roles.Characters
{
    public abstract class Character
    {


        protected readonly string _name;
        protected readonly int _xp;

        protected double _health { get; set; }
        protected double _damage { get; set; }
        protected double _mana { get; set; }

        public Character(string name, string type)
        {
            _name = name;
            _xp = 0;

        }
        public Character(string name, string type, int xp)
        {
            _name = name;
            _xp = xp;


        }

        public abstract void Heal();
        public abstract void DealDamage();
        public abstract void TakeDamage(double damage);
        public abstract void Defend();
        public abstract void CheckLevel();

    }
}
