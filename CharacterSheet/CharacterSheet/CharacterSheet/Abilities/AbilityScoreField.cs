using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet {
    public class AbilityScoreField {
        public AbilityScore Strength { get; private set; }
        public AbilityScore Dexterity { get; private set; }
        public AbilityScore Constitution { get; private set; }
        public AbilityScore Intelligence { get; private set; }
        public AbilityScore Wisdom { get; private set; }
        public AbilityScore Charisma { get; private set; }

        public AbilityScoreField() {
            AbilityScoreFieldInit();
        }

        private void AbilityScoreFieldInit() {
            List<SubAbilityScore> list = new List<SubAbilityScore>();
            list.Add(new SubAbilityScore(Referal.Athletics, -1));
            Strength = new AbilityScore(Referal.Strength, 8, list);

            list = new List<SubAbilityScore>();
            list.Add(new SubAbilityScore(Referal.Acrobatics, 5));
            list.Add(new SubAbilityScore(Referal.Sleight_of_Hand, 5));
            list.Add(new SubAbilityScore(Referal.Stealth, 5));
            Dexterity = new AbilityScore(Referal.Dexterity, 16, list);

            Constitution = new AbilityScore(Referal.Constitution, 14, new List<SubAbilityScore>());

            list = new List<SubAbilityScore>();
            list.Add(new SubAbilityScore(Referal.Arcana, 0));
            list.Add(new SubAbilityScore(Referal.History, 0));
            list.Add(new SubAbilityScore(Referal.Investigation, 4));
            list.Add(new SubAbilityScore(Referal.Nature, 0));
            list.Add(new SubAbilityScore(Referal.Religion, 0));
            Intelligence = new AbilityScore(Referal.Intelligence, 10, list);

            list = new List<SubAbilityScore>();
            list.Add(new SubAbilityScore(Referal.Animal_Handling, 1));
            list.Add(new SubAbilityScore(Referal.Insight, 3));
            list.Add(new SubAbilityScore(Referal.Medicine, 1));
            list.Add(new SubAbilityScore(Referal.Perception, 5));
            list.Add(new SubAbilityScore(Referal.Survival, 1));
            Wisdom = new AbilityScore(Referal.Wisdom, 12, list);

            list = new List<SubAbilityScore>();
            list.Add(new SubAbilityScore(Referal.Deception, 5));
            list.Add(new SubAbilityScore(Referal.Intimidation, 3));
            list.Add(new SubAbilityScore(Referal.Performance, 3));
            list.Add(new SubAbilityScore(Referal.Persuasion, 3));
            Charisma = new AbilityScore(Referal.Charisma, 16, list);
        }
    }
}
