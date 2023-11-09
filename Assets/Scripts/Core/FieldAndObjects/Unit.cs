using System;
using System.Collections.Generic;
using Core.Ability;
using Core.Ability.Effects;
using Core.Skill;

namespace Core.FieldAndObjects
{
    public class Unit : Entity, IimpactAttackAbility, IimpactStatusAbility
    {
        
        private string unitID;
        private int maxHP;
        private int maxAP;
        private Cube maxDefenceCube;
        
        private int teamID; 
        public int TeamID
        {
            get => teamID;
            private set => teamID = value;
        }
        
        private int currentHP;
        public int CurrentHp
        {
            get => currentHP;
            set
            {
                currentHP += value;
                if (currentHP <= 0)
                {
                    Knockout();
                }
            }
        }

        private int currentAP;

        public int CurrentAP
        {
            get
            {
                if (currentAP != 0)
                {
                    int c = currentAP;
                    if (currentAP != maxAP)
                    {
                        effects.AddEffect(new DecreaseDefenseCubeEffect());
                    }
                    currentAP--;
                    return c;
                }

                return currentAP;
            }
            set
            {
                if (value > maxAP)
                {
                    currentAP = maxAP;
                }
                else
                {
                    currentAP = value;
                }
            }
        }

        private Cube currentDefenceCude;

        public Cube CurrentDefenceCude
        {
            get
            {
                Cube cube = currentDefenceCude;
                effects.AddEffect(new DecreaseDefenseCubeEffect());
                return cube;
            }
            set => currentDefenceCude = value;
        }

        public Cube initiativeCube;
        public UnitAbilitiesData activeAbilities;
        public UnitSkillData skills;
        public UnitEffectsData effects;


        public Action AEffectAdded;

        
        public override void Interact(Unit interactingUnit)
        {
            
        }

        public int GetInitiative()
        {
            return initiativeCube.Calculate();
        }

        public void CastAbility(Ability.Ability ability, Unit target)
        {
            if (CurrentAP != 0)
            {
                
            }
            
            if (ability.GetType() == typeof(StatusAbility))
            {
                target.ImpactStatusAbility((StatusAbility)ability);
            }
            else
            {
                bool isWin = CubeBoard.ContestCompare((ability as AttackAbility).attackCube, target);

                if (isWin)
                {
                    target.ImpactAttackAbility((AttackAbility)ability);
                }
                else
                {
                    //fail contest
                }
            }
            
            
        }

        public void ImpactAttackAbility(AttackAbility ability)
        {
            throw new System.NotImplementedException();
        }

        public void ImpactStatusAbility(StatusAbility ability)
        {
            throw new System.NotImplementedException();
        }
        
        void Knockout()
        {
            
        }
    }
}