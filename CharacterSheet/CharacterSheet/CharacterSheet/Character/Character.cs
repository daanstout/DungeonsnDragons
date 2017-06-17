using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet {
    public class Character {
        public string characterName { get; set; }
        public CharacterClass characterClass { get; set; }
        public uint characterLevel { get; set; }
        public string characterBackground { get; set; }
        public string playerName { get; set; }
        public string characterRace { get; set; }
        public string characterAlignment { get; set; }
        public int characterExperience { get; set; }
        public AbilityScoreField abilityScores { get; }
        public string adventureGroup { get; set; }
        public bool inspiration { get; set; }
        public Armor characterArmor { get; set; }
        public bool characterShield { get; set; }
        public int characterCurrentHealth { get; set; }
        public int characterTemporaryHealth { get; set; }
        public bool unconscious { get; set; } = false;
        public bool death { get; set; } = false;
        public Inventory inventory { get; }

        public Character(string characterName, CharacterClass characterClass, uint characterLevel, string characterBackground, string playerName, string characterRace, string characterAlignment, int characterExperience, string adventureGroup, Armor characterArmor, bool characterShield) {
            inventory = new Inventory(this);
            abilityScores = new AbilityScoreField(this);

            this.characterName = characterName;
            this.characterClass = characterClass;
            this.characterLevel = characterLevel;
            this.characterBackground = characterBackground;
            this.playerName = playerName;
            this.characterRace = characterRace;
            this.characterAlignment = characterAlignment;
            this.characterExperience = characterExperience;
            this.adventureGroup = adventureGroup;
            inspiration = false;
            this.characterArmor = characterArmor;
            this.characterShield = characterShield;

            characterCurrentHealth = Referal.getMaxHitPoints(characterClass.hitDie, Referal.getModifier(abilityScores.Constitution.score), Referal.getLevel(characterExperience));
            characterTemporaryHealth = 0;
        }
    }
}
