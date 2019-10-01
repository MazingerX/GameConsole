using System;

namespace gameconsole
{
    public abstract SpecialDefense
    {
        public abstract int CalculateDamageReduction(int totalDamage);

    public static SpecialDefense Null { get; } = new NullDefense();

    private class NullDefense : SpecialDefense
    {
        private override int CalculateDamageReduction(int totalDamage)
        {
            return 0;   //no operation / "do nothing" behavior
        }
    }
}
}