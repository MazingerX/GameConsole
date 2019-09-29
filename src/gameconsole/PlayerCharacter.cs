using System;

namespace gameconsole
{
    class PlayerCharacter
    {
        public PlayerCharacter()
        {
            DateOfBirth = DateTime.MinValue;  //magic number
            DaysSinceLastLogin = -1;  //magic number
        }
        public string Name { get; set; }
        public int DaysSinceLastLogin { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}