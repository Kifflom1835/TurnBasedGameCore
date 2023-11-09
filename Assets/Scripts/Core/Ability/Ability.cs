namespace Core.Ability
{
    public class Ability
    {
        public int ap;
        public int countOfUse;
        
        public AbilityResult abilityResult;

        public virtual void Init()
        {
            abilityResult.Init();
        }
    }
}