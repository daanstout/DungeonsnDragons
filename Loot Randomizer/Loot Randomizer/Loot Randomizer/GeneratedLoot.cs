using System;
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
        int verticalWindowSize;

        public GeneratedLoot(List<lootInheritanceClass> obtainedLoot) {
            InitializeComponent();

            this.obtainedLoot = obtainedLoot;

            verticalWindowSize = Height;

            generatedLootInit();
        }

        public void generatedLootInit() {
            int windowResize = 12;
            obtainedLootLabel.Text = "";
            Console.WriteLine(obtainedLoot.Count);
            if (obtainedLoot.Count > 0) {
                Random rnd;
                foreach (lootInheritanceClass l in obtainedLoot) {
                    if (l is Loot) {
                        Loot m = (Loot)l;
                        if (m.lootDropAmount > 0) {
                            obtainedLootLabel.Text += m.lootName + " - " + m.lootDropAmount + "x\n";
                        } else if (m.lootMinimumDropAmount > 0 && m.lootMaximumDropAmount > 0) {
                            rnd = new Random();
                            int hit = rnd.Next(m.lootMinimumDropAmount, m.lootMaximumDropAmount);
                            obtainedLootLabel.Text += m.lootName + " - " + hit + "x\n";
                        }
                        generatedLootPictureBox.Height += windowResize;
                        Height += windowResize;
                        closeButton.Location = new Point(closeButton.Location.X, closeButton.Location.Y + windowResize);
                    } else if (l is LootFamily) {
                        LootFamily m = (LootFamily)l;
                        if (m.lootDropAmount > 0) {
                            obtainedLootLabel.Text += "LootFamily, " + m.lootDropAmount + "x:\n";
                            generatedLootPictureBox.Height += windowResize;
                            Height += windowResize;
                            closeButton.Location = new Point(closeButton.Location.X, closeButton.Location.Y + windowResize);
                            foreach (Loot n in m.lootFamily) {
                                obtainedLootLabel.Text += "     " + n.lootName + "\n";
                                generatedLootPictureBox.Height += windowResize;
                                Height += windowResize;
                                closeButton.Location = new Point(closeButton.Location.X, closeButton.Location.Y + windowResize);
                            }
                        } else if (m.lootMinimumDropAmount > 0 && m.lootMaximumDropAmount > 0) {
                            rnd = new Random();
                            int hit = rnd.Next(m.lootMinimumDropAmount, m.lootMaximumDropAmount);
                            obtainedLootLabel.Text += "LootFamily, " + hit + "x:\n";
                            generatedLootPictureBox.Height += windowResize;
                            Height += windowResize;
                            closeButton.Location = new Point(closeButton.Location.X, closeButton.Location.Y + windowResize);
                            foreach (Loot n in m.lootFamily) {
                                obtainedLootLabel.Text += "     " + n.lootName + "\n";
                                generatedLootPictureBox.Height += windowResize;
                                Height += windowResize;
                                closeButton.Location = new Point(closeButton.Location.X, closeButton.Location.Y + windowResize);
                            }
                        }
                    }
                }
            } else {
                obtainedLootLabel.Text += "No Loot Found";
            }
        }

        private void closeButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
