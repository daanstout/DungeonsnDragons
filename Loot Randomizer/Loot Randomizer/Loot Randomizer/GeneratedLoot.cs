﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loot_Randomizer {
    public partial class GeneratedLoot : Form {
        List<lootInheritanceClass> obtainedLoot;

        public GeneratedLoot(List<lootInheritanceClass> obtainedLoot) {
            InitializeComponent();

            this.obtainedLoot = obtainedLoot;

            generatedLootInit();
        }

        public void generatedLootInit() {

        }
    }
}
