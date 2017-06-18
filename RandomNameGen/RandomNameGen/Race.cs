using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNameGen {
    public class Race {
        public readonly string race;

        private List<string> maleFirstName;
        public string getMaleFirstName {
            get {
                return maleFirstName[random.Next(0, maleFirstName.Count)];
            }
        }

        private List<string> femaleFirstName;
        public string getFemaleFirstName {
            get {
                return femaleFirstName[random.Next(0, femaleFirstName.Count)];
            }
        }

        private List<string> lastName;
        public string getLastName {
            get {
                return lastName[random.Next(0, lastName.Count)];
            }
        }

        public string getMaleName {
            get {
                return getMaleFirstName + " " + getLastName;
            }
        }

        public string getFemaleName {
            get {
                return getFemaleFirstName + " " + getLastName;
            }
        }

        private Random random;

        public Race(string race) {
            this.race = race;
            maleFirstName = new List<string>();
            femaleFirstName = new List<string>();
            lastName = new List<string>();
            random = new Random();
        }

        public override string ToString() {
            return race;
        }

        public void addMaleFirstName(string name) {
            if(!maleFirstName.Contains(name)) maleFirstName.Add(name);
        }

        public void addMaleFirstName(string[] name) {
            foreach (string child in name) addMaleFirstName(child);
        }

        public void addFemaleFirstName(string name) {
            if(!femaleFirstName.Contains(name)) femaleFirstName.Add(name);
        }

        public void addFemaleFirstName(string[] name) {
            foreach (string child in name) addFemaleFirstName(child);
        }

        public void addLastName(string name) {
            if(!lastName.Contains(name)) lastName.Add(name);
        }

        public void addLastName(string[] name) {
            foreach (string child in name) addLastName(child);
        }
    }
}
