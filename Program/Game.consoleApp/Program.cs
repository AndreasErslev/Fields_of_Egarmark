using Game.Roles.Characters;
using Game.Roles.Enemies;
using System;

namespace Game.consoleApp
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
