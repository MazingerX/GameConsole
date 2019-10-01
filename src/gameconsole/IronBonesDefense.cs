using System;

namespace gameconsole
{
    public class IronBoneDefense : SpecialDefense
    {
        public override int CalculateDamageReduction(int totalDamage)
        {
            return 5;
        }
    }
}