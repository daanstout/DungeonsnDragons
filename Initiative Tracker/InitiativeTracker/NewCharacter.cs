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
    public partial class NewCharacter : Form {
        public Character character;
        public NewCharacter() {
            InitializeComponent();
            character = new Character();
        }
    }
}
