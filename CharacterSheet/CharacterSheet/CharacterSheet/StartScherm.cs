using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterSheet {
    public partial class StartScherm : Form {
        public StartScherm() {
            InitializeComponent();

            Referal.fillConfigurable();
        }

        private void newCharacterButton_Click(object sender, EventArgs e) {
            AbilityScoreField field = new AbilityScoreField();
            Character dummy = new Character("Valdor Stormrager", Referal.Rogue, 4, Referal.Criminal, "Daan Stout", Referal.Half_Elf, Referal.Chaotic_Neutral, 2984, field, "Group 1", Referal.Studded_Leather, false);

            Sheet sheet = new Sheet(this, dummy);
            sheet.Show();
            Visible = false;
        }
    }
}
