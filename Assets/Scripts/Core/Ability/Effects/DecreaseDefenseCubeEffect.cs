using Unity.VisualScripting;
using Unit = Core.FieldAndObjects.Unit;

namespace Core.Ability.Effects
{
    public class DecreaseDefenseCubeEffect :Effect
    {
        public override void Init()
        {
            base.Init();
        }

        public override void ActivateEffect(Unit unit)
        {
            base.ActivateEffect(unit);
            ReleaseEffect();
            Battle.Instance.AInitiativeEnd += EndEffect;
        }

        public override void ReleaseEffect()
        {
            effectOwner.CurrentDefenceCude.LevelIndex--;
            base.ReleaseEffect();
        }

        public override void EndEffect()
        {
            effectOwner.CurrentDefenceCude.LevelIndex++;
            Battle.Instance.AInitiativeEnd += EndEffect;
            
            base.EndEffect();
        }
        
        
        
        
    }
}