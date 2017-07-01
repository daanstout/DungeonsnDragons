using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetStatRolls {
    public partial class GetStatRoll : Form {
        XMLLoader loader;
        Random random;

        public GetStatRoll() {
            InitializeComponent();

            random = new Random();
            loader = new XMLLoader();

            getClassGuides();

            if(classGuideComboBox.Items.Count > 0) classGuideComboBox.SelectedIndex = 0;
        }

        public void getClassGuides() {
            List<ClassGuide> list = new List<ClassGuide>();

            string[] guides = Directory.GetFiles("Guides/", "*.xml");
            Regex regex = new Regex(@"(\/[a-z 1-9 A-Z]*)");
            foreach(string str in guides) {
                Match match = regex.Match(str);
                loader.importClassGuide(match.ToString().Substring(1), ref list);
            }

            foreach(ClassGuide guide in list) {
                classGuideComboBox.Items.Add(guide);
            }
        }

        private void generateStatsButton_Click(object sender, EventArgs e) {
            ClassGuide guide = (ClassGuide)classGuideComboBox.SelectedItem;
            ResultLabel.Text = "Strength: " + getRandomStat(guide.averageStrength, guide.strengthLeeWay);
            ResultLabel.Text += "\nDexterity: " + getRandomStat(guide.averageDexterity, guide.dexterityLeeWay);
            ResultLabel.Text += "\nConstitution: " + getRandomStat(guide.averageConstitution, guide.constitutionLeeWay);
            ResultLabel.Text += "\nIntelligence: " + getRandomStat(guide.averageIntelligence, guide.intelligenceLeeWay);
            ResultLabel.Text += "\nWisdom: " + getRandomStat(guide.averageWisdom, guide.wisdomLeeWay);
            ResultLabel.Text += "\nCharisma: " + getRandomStat(guide.averageCharisma, guide.charismaLeeWay);
        }

        public int getRandomStat(int average, int leeway) {
            return random.Next(-leeway, leeway) + average;
        }
    }
}
