using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStatRolls {
    public class ClassGuide {
        public string className;

        public int averageStrength;
        public int strengthLeeWay;

        public int averageDexterity;
        public int dexterityLeeWay;

        public int averageConstitution;
        public int constitutionLeeWay;

        public int averageIntelligence;
        public int intelligenceLeeWay;

        public int averageWisdom;
        public int wisdomLeeWay;

        public int averageCharisma;
        public int charismaLeeWay;

        public override string ToString() {
            return className;
        }
    }
}
