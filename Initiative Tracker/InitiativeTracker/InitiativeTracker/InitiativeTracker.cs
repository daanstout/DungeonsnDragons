using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InitiativeTracker {
    public partial class InitiativeTracker : Form {
        List<Character> characterList;
        public InitiativeTracker() {
            InitializeComponent();
            
            characterList = new List<Character>();
        }

        private void newCharacterButton_Click(object sender, EventArgs e) {
            NewCharacter newChar = new NewCharacter();
            newChar.Show();
        }
    }
}
