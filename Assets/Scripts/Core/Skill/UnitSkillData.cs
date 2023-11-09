using System.Collections.Generic;

namespace Core.Skill
{
    public class UnitSkillData
    {
        List<Skill> skills = new List<Skill>();

        public void Init(/*SkillData*/)
        {
            
        }

        public Skill GetSkill(SkillType type)
        {
            return skills.Find(s => s.skillType == type);
        }
    }
}