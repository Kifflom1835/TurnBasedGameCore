using Core.FieldAndObjects;

namespace Core.Ability
{
    public class Effect
    {
        private EffectType effectType;
        private Cube effectCube;
        private int effectDifficult;
        //ReleaseCondition
        //EndCondition
        //EffectData

        protected Unit effectOwner;

        public virtual void Init( /*EffectData data*/)
        {
        }

        public virtual void ActivateEffect(Unit unit)
        {
            effectOwner = unit;
        }

        public virtual void ReleaseEffect()
        {
            
        }

        public virtual void EndEffect()
        {
            effectOwner.effects.RemoveEffect(this);
        }
    }
}