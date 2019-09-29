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
        public int? DaysSinceLastLogin { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}