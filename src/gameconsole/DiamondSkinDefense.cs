using System;

namespace gameconsole
{
    public class DiamondSkinDefense : SpecialDefense
    {
        public override int CalculateDamageReduction(int totalDamage)
        {
            return 1;
        }
    }
}