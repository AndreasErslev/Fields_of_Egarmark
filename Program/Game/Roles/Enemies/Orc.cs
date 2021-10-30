using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Roles.Characters;

namespace Game.Roles.Enemies
{
    public class Orc : IEnemy
    {
        private Random _random = new Random();
        private double _health { get; set; }
        private double _damage { get; set; }
        private double _mana { get; set; }

        public void DealDamage(Character character)
        {
            switch (_random.Next(1,4))
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
            }
        }
        public void Defend()
        {

        }

        public void Heal()
        {

        }

        public void TakeDamage(double damage)
        {
            _health -= damage;

            if (_health <= 0)
                Console.WriteLine("The Orc has been slain");

        }
    }
}
