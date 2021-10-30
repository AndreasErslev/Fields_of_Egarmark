using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Roles.Enemies;

namespace Game.Attacks.Character
{
    public class Slash : ICharacterAttack
    {
        public double Atack(IEnemy targetEnemy)
        {
            targetEnemy.TakeDamage(3);
            return 0;
        }
    }
}
