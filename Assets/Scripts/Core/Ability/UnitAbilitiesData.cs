using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.FieldAndObjects;
using UnityEngine;

namespace Core.Ability
{
    public class UnitAbilitiesData
    {
        private List<Ability> abilities = new List<Ability>();

        public void Init()
        {

        }

        public List<T> GetAbilities<T>() where T: Ability
        {
            List<Ability> findedAbilities = abilities.FindAll(a => a.GetType() == typeof(T));

            List<T> result = new List<T>();

            foreach (var a in findedAbilities)
            {
                result.Add((T)a);
            }

            return result;
        }
        
        public Ability GetAbility<T>() where T : Ability
        {
            return abilities.Find(a => a.GetType() == typeof(T));
        }

        public void AddAbility(Ability ability)
        {
            if (!abilities.Contains(ability))
                abilities.Add(ability);
            else
                Debug.Log("Ability already contains in AbilityesData :"/*Unit*/);
        }

        public void RemoveAbility(Ability ability)
        {
            if (abilities.Contains(ability))
                abilities.Remove(ability);
        }
    }
}