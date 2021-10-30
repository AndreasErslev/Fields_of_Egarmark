using System;
using Game.Roles.Characters;
using Game.Roles.Enemies;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Character player;
            IEnemy orc;
            orc = new Orc();
            CharacterSelect character = new CharacterSelect();
            player = character.ChooseCharacter();
            
        }
    }
}
