using Core.Ability.Effects;
using Core.FieldAndObjects;
using UniversalUnity.Helpers.MonoBehaviourExtenders;

namespace Core
{
    public static class CubeBoard 
    {
        public static bool ContestCompare(Cube attackerCube, Unit defensive)
        {
            int attackerValue = attackerCube.Calculate();
            int defenderValue = defensive.CurrentDefenceCude.Calculate();
            
            defensive.effects.AddEffect(new DecreaseDefenseCubeEffect());

            if (attackerValue > defenderValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool DifficultCompare(Cube skillCube, int difficult)
        {
            if (skillCube.Calculate() > difficult)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}