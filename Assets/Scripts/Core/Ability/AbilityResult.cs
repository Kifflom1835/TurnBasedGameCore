using System.Collections.Generic;

namespace Core.Ability
{
    public class AbilityResult
    {
        List<Effect> effects = new List<Effect>();
        
        //ResultData data;

        public void Init(/*ResultData data*/)
        {
            foreach (var effect in effects)
            {
                effect.Init();
            }
        }

        public void ReleaseResult()
        {
            
        }
    }
}