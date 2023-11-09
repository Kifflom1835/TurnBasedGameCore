namespace Core.Ability
{
    public class AttackAbility : Ability
    {
        public Cube attackCube;
        private DamageType damageType;
        private Cube damageCube;
        private int damage;

        public override void Init()
        {
            base.Init();
        }

        public int GetDamage()
        {
            if (damageType == DamageType.Cube)
            {
                return damageCube.Calculate();
            }
            else
            {
                return damage;
            }
        }
    }
}