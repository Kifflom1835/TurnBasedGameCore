using System.Collections.Generic;
using Core.FieldAndObjects;

namespace Core.Ability
{
    public class UnitEffectsData
    {
        private List<Effect> effects = new List<Effect>();
        private Unit owner;

        public void Init(Unit unit)
        {
            owner = unit;
        }

        public void AddEffect(Effect effect)
        {
            effects.Add(effect);
            effect.ActivateEffect(owner);
        }

        public void RemoveEffect(Effect effect)
        {
            effects.Remove(effect);
        }
    }
}