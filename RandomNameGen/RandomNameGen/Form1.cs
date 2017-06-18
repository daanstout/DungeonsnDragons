using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNameGen {
    public partial class Form1 : Form {
        private bool isFrozen = false;

        //private Race human;
        private List<Race> races;

        public Form1() {
            InitializeComponent();

            races = new List<Race> {
                new Race("Human"),
                new Race("Elf Child"),
                new Race("Elf Adult")
            };

            foreach (Race child in races) {
                raceListComboBox.Items.Add(child);
            }

            raceListComboBox.SelectedIndex = 0;

            FillHumanLists();
            FillElfChildList();
            FillElfAdultList();

            Race list = (Race)(raceListComboBox.SelectedItem);

            generatedNameLabel.Text = list.getMaleName;
        }

        private void generateNameButton_Click(object sender, EventArgs e) {
            Race list = (Race)raceListComboBox.SelectedItem;

            if (maleCheckBox.Checked) {
                generatedNameLabel.Text = list.getMaleName;
            } else if (femaleCheckBox.Checked) {
                generatedNameLabel.Text = list.getFemaleName;
            }
        }

        private void femaleCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (isFrozen) return;

            isFrozen = true;
            maleCheckBox.Checked = false;
            femaleCheckBox.Checked = true;
            isFrozen = false;
        }

        private void maleCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (isFrozen) return;

            isFrozen = true;
            femaleCheckBox.Checked = false;
            maleCheckBox.Checked = true;
            isFrozen = false;
        }

        private void FillHumanLists() {
            races[0].addMaleFirstName("Aseir");
            races[0].addMaleFirstName("Zasheir");
            races[0].addMaleFirstName("Darvin");
            races[0].addMaleFirstName("Dave");
            races[0].addMaleFirstName("Egbert");
            races[0].addMaleFirstName("Dorn");
            races[0].addMaleFirstName("Helm");
            races[0].addMaleFirstName("Ander");
            races[0].addMaleFirstName("Urth");
            races[0].addMaleFirstName("Faurgar");
            races[0].addMaleFirstName("Bardeid");
            races[0].addMaleFirstName("Haseid");
            races[0].addMaleFirstName("Khemed");
            races[0].addMaleFirstName("Mehmen");
            races[0].addMaleFirstName("Sudeiman");
            races[0].addMaleFirstName("Dorn");
            races[0].addMaleFirstName("Evendur");
            races[0].addMaleFirstName("Gorstag");
            races[0].addMaleFirstName("Grim");
            races[0].addMaleFirstName("Malark");
            races[0].addMaleFirstName("Morn");
            races[0].addMaleFirstName("Randall");
            races[0].addMaleFirstName("Stedd");
            races[0].addMaleFirstName("Bor");
            races[0].addMaleFirstName("Fodel");
            races[0].addMaleFirstName("Glar");
            races[0].addMaleFirstName("Grigor");
            races[0].addMaleFirstName("Igan");
            races[0].addMaleFirstName("Ivor");
            races[0].addMaleFirstName("Kosef");
            races[0].addMaleFirstName("Mival");
            races[0].addMaleFirstName("Orel");
            races[0].addMaleFirstName("Pavel");
            races[0].addMaleFirstName("Sergor");
            races[0].addMaleFirstName("Blath");
            races[0].addMaleFirstName("Bran");
            races[0].addMaleFirstName("Frath");
            races[0].addMaleFirstName("Geth");
            races[0].addMaleFirstName("Lander");
            races[0].addMaleFirstName("Luth");
            races[0].addMaleFirstName("Malcer");
            races[0].addMaleFirstName("Stor");
            races[0].addMaleFirstName("Taman");
            races[0].addMaleFirstName("Daan");
            races[0].addMaleFirstName("Artur");
            races[0].addMaleFirstName("Bart");
            races[0].addMaleFirstName(new string[] { "Aoth", "Bareris" ,"Faurgar", "Jandar", "Kanithar", "Madislak", "Ralmevik", "Shaumar", "Vladislak", "An", "Chen", "Chi", "Fai", "Jiang", "Jun", "Lian", "Long", "Meng", "On", "Shan", "Shui", "Wen", "Anton", "Diero", "Marcon", "Pieron", "Rimardo", "Romero", "Salazar", "Umbero" });
            races[0].addMaleFirstName("Ehput-Ki");
            races[0].addMaleFirstName("Kethoth");
            races[0].addMaleFirstName("Mumed");
            races[0].addMaleFirstName("Ramas");
            races[0].addMaleFirstName("So-Kekur");
            races[0].addMaleFirstName("Thazar-De");
            races[0].addMaleFirstName("Urthur");
            races[0].addMaleFirstName("Borovik");

            races[0].addFemaleFirstName("Atala");
            races[0].addFemaleFirstName("Meilil");
            races[0].addFemaleFirstName("Arveene");
            races[0].addFemaleFirstName("Kerri");
            races[0].addFemaleFirstName("Kara");
            races[0].addFemaleFirstName("Kethra");
            races[0].addFemaleFirstName("Amara");
            races[0].addFemaleFirstName("Mara");
            races[0].addFemaleFirstName("Nephis");
            races[0].addFemaleFirstName("Imzel");
            races[0].addFemaleFirstName("Navarra");
            races[0].addFemaleFirstName("Ceidil");
            races[0].addFemaleFirstName("Hama");
            races[0].addFemaleFirstName("Jasmal");
            races[0].addFemaleFirstName("Seipora");
            races[0].addFemaleFirstName("Yasheira");
            races[0].addFemaleFirstName("Zasheida");
            races[0].addFemaleFirstName("Esvele");
            races[0].addFemaleFirstName("Jhessail");
            races[0].addFemaleFirstName("Lureene");
            races[0].addFemaleFirstName("Miri");
            races[0].addFemaleFirstName("Rowan");
            races[0].addFemaleFirstName("Shandri");
            races[0].addFemaleFirstName("Tessele");
            races[0].addFemaleFirstName("Alethra");
            races[0].addFemaleFirstName("Katernin");
            races[0].addFemaleFirstName("Natali");
            races[0].addFemaleFirstName("Olma");
            races[0].addFemaleFirstName("Tana");
            races[0].addFemaleFirstName("Zora");
            races[0].addFemaleFirstName("Amafrey");
            races[0].addFemaleFirstName("Betha");
            races[0].addFemaleFirstName("Cefrey");
            races[0].addFemaleFirstName("Kethra");
            races[0].addFemaleFirstName("Olga");
            races[0].addFemaleFirstName("Silifrey");
            races[0].addFemaleFirstName("Westra");
            races[0].addFemaleFirstName("Kyra");
            races[0].addFemaleFirstName(new string[] { "Arizima", "Chathi", "Nephis", "Nulera", "Murithi", "Sefris", "Thola", "Umara", "Zolis", "Fyevarra", "Hulmarra", "Immith", "Imzel", "Navarra", "Shevarra", "Thammith", "Yuldra", "Bai", "Chao", "Jia", "Lei", "Mei", "Qiao", "Shui", "Tai", "Balama", "Dona", "Faila", "Jalana", "Luisa", "Marta", "Quara", "Selise", "Vonda" });

            races[0].addLastName("Windhel");
            races[0].addLastName("Jassan");
            races[0].addLastName("Buckman");
            races[0].addLastName("Evenwood");
            races[0].addLastName("Dotsk");
            races[0].addLastName("Windrivver");
            races[0].addLastName("Lackman");
            races[0].addLastName("Fezim");
            races[0].addLastName("Ulmokina");
            races[0].addLastName("Pisacar");
            races[0].addLastName("Basha");
            races[0].addLastName("Dumein");
            races[0].addLastName("Khalid");
            races[0].addLastName("Mostana");
            races[0].addLastName("Pashar");
            races[0].addLastName("Rein");
            races[0].addLastName("Amblecrown");
            races[0].addLastName("GreyCastle");
            races[0].addLastName("Dundragon");
            races[0].addLastName("Tallstag");
            races[0].addLastName("Bersk");
            races[0].addLastName("Chernin");
            races[0].addLastName("Kulenov");
            races[0].addLastName("Marsk");
            races[0].addLastName("Nemetsk");
            races[0].addLastName("Shemov");
            races[0].addLastName("Starag");
            races[0].addLastName("Brightwood");
            races[0].addLastName("Helder");
            races[0].addLastName("Hornraven");
            races[0].addLastName("Stormwind");
            races[0].addLastName("Stout");
            races[0].addLastName("Smets");
            races[0].addLastName("Holsappel");
            races[0].addLastName("Miron");
            races[0].addLastName("Berg, van den");
            races[0].addLastName(new string[] { "Ankhalab", "Anskuld", "Fezim", "Hahpet", "Nathandem", "Sepret", "Uuthrakt", "Chergoba", "Dyernina", "Iltazyara", "Murnyethara", "Stayanoga", "Ulmokina", "Chien", "Huang", "Kao", "Kung", "Lao", "Ling", "Mei", "Pin", "Shin", "Sum", "Tan", "Wan", "Agosto", "Astorio", "Calabra", "Domine", "Falone", "Marivaldi", "Pisacar", "Ramondo" });
        }

        public void FillElfChildList() {
            races[1].addMaleFirstName(new string[] { "Ara", "Bryn", "Del", "Eryn", "Faen", "Innil", "Lael", "Mella", "Naill", "Naeris", "Phann", "Rael", "Rinn", "Sai", "Syllin", "Thia", "Vall" });
            races[1].addFemaleFirstName(new string[] { "Ara", "Bryn", "Del", "Eryn", "Faen", "Innil", "Lael", "Mella", "Naill", "Naeris", "Phann", "Rael", "Rinn", "Sai", "Syllin", "Thia", "Vall" });
            races[1].addLastName(new string[] { "Amakiir", "Amastacia", "Galanodel", "Holimion", "Ilphelkiir", "Liadon", "Meliamne", "Naïlo", "Siannodel", "Xiloscient" });
        }

        public void FillElfAdultList() {
            races[2].addMaleFirstName(new string[] { "Adran", "Aelar", "Aramil", "Arannis", "Aust", "Beiro", "Berrian", "Carric", "Enialis", "Erdan", "Erevan", "Galinndan", "Hadarai", "Heian", "Himo", "Immeral", "Ivellios", "Laucian", "Mindartis", "Paelias", "Perem", "Quarion", "Riardon", "Rolen", "Soveliss", "Thamior", "Tharivol", "Theren", "Varis" });
            races[2].addFemaleFirstName(new string[] { "Adrie", "Althaea", "Anastrianna", "Andraste", "Bethrynna", "Birel", "Caelynn", "Drusilia", "Enna", "Felosial", "Ielenia", "Jelenneth", "Keyleth", "Leshanna", "Lia", "Meriele", "Mialee", "Naivara", "Quelenna", "Quillathe", "Sariel", "Shanairra", "Shava", "Silaqui", "Theirastra", "Thia", "Vadannia", "Valanthe", "Xanaphia" });
            races[2].addLastName(new string[] { "Amakiir", "Amastacia", "Galanodel", "Holimion", "Ilphelkiir", "Liadon", "Meliamne", "Naïlo", "Siannodel", "Xiloscient" });
        }
    }
}

