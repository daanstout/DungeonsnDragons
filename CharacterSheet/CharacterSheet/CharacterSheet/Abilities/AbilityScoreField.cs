using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet {
    public class AbilityScoreField {
        private readonly Character owner;

        public AbilityScore Strength { get; private set; }
        public AbilityScore Dexterity { get; private set; }
        public AbilityScore Constitution { get; private set; }
        public AbilityScore Intelligence { get; private set; }
        public AbilityScore Wisdom { get; private set; }
        public AbilityScore Charisma { get; private set; }

        public AbilityScoreField(Character owner) {
            this.owner = owner;

            AbilityScoreFieldInit();
        }
        
        private void AbilityScoreFieldInit() {
            List<SubAbilityScore> list = new List<SubAbilityScore> {
                new SubAbilityScore(Referal.Athletics, false)
            };
            Strength = new AbilityScore(Referal.Strength, 8, list, false);

            list = new List<SubAbilityScore> {
                new SubAbilityScore(Referal.Acrobatics, true),
                new SubAbilityScore(Referal.Sleight_of_Hand, true),
                new SubAbilityScore(Referal.Stealth, true)
            };
            Dexterity = new AbilityScore(Referal.Dexterity, 16, list, true);

            Constitution = new AbilityScore(Referal.Constitution, 14, null, false);

            list = new List<SubAbilityScore> {
                new SubAbilityScore(Referal.Arcana, false),
                new SubAbilityScore(Referal.History, false),
                new SubAbilityScore(Referal.Investigation, true),
                new SubAbilityScore(Referal.Nature, false),
                new SubAbilityScore(Referal.Religion, false)
            };
            Intelligence = new AbilityScore(Referal.Intelligence, 10, list, true);

            list = new List<SubAbilityScore> {
                new SubAbilityScore(Referal.Animal_Handling, false),
                new SubAbilityScore(Referal.Insight, true),
                new SubAbilityScore(Referal.Medicine, false),
                new SubAbilityScore(Referal.Perception, true),
                new SubAbilityScore(Referal.Survival, false)
            };
            Wisdom = new AbilityScore(Referal.Wisdom, 12, list, false);

            list = new List<SubAbilityScore> {
                new SubAbilityScore(Referal.Deception, true),
                new SubAbilityScore(Referal.Intimidation, false),
                new SubAbilityScore(Referal.Performance, false),
                new SubAbilityScore(Referal.Persuasion, false)
            };
            Charisma = new AbilityScore(Referal.Charisma, 16, list, false);
        }
    }
}
