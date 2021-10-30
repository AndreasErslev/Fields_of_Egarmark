using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Roles.Enemies;

namespace Game.Attacks.Character
{
    public interface ICharacterAttack
    {
        double Atack(IEnemy targetEnemy);
    }
}
