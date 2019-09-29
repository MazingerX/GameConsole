using System;

namespace gameconsole
{
    class PlayerCharacter
    {
        public PlayerCharacter()
        {
            DateOfBirth = null;
            DaysSinceLastLogin = null;
        }
        public string Name { get; set; }
        public Nullable<int> DaysSinceLastLogin { get; set; }
        public Nullable<DateTime> DateOfBirth { get; set; }
    }
}