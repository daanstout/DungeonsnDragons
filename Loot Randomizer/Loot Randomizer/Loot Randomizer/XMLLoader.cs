using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace Loot_Randomizer {
    public class XMLLoader {
        //private LootTable lootTable;

        delegate int del(XmlNode x);
        del sane = x => int.Parse(x.InnerText);

        public LootTable importLootTable(string fileName) {
            LootTable lootTable = new LootTable();

            try {
                XmlDocument doc = new XmlDocument();
                FileStream fs = new FileStream(Referal.lootTablesMapName + fileName + Referal.XMLFileAnotation, FileMode.Open, FileAccess.Read);
                doc.Load(fs);
                XmlNode root = doc.LastChild;
                XmlNodeList objects = root.ChildNodes;

                if (root.Name.Equals("lootTable")) {
                    return obtainTable(objects);
                }
            } catch (Exception e) {

            }
            return new LootTable(); ;
        }

        private LootTable obtainTable(XmlNodeList objects) {
            LootTable lootTable = new LootTable();

            foreach (XmlNode i in objects) {
                switch (i.Name) {
                    case "lootTableName":
                        lootTable.lootTableName = i.InnerText.ToString();
                        break;
                    case "loot":
                        Loot l = new Loot();
                        foreach (XmlNode j in i) {
                            switch (j.Name) {
                                case "lootName":
                                    l.lootName = j.InnerText;
                                    break;
                                case "lootDropChance":
                                    l.lootDropChance = sane(j);
                                    break;
                                case "lootMinimumDropAmount":
                                    l.lootMinimumDropAmount = sane(j);
                                    break;
                                case "lootMaximumDropAmount":
                                    l.lootMaximumDropAmount = sane(j);
                                    break;
                                case "lootDropAmount":
                                    l.lootDropAmount = sane(j);
                                    break;
                                default:
                                    MessageBox.Show("Onbekend object type: " + j.Name, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    break;
                            }
                        }
                        lootTable.addLoost(l);
                        break;
                    case "lootFamily":
                        LootFamily lf = new LootFamily();
                        int ldc, lmida, lmada, lda;
                        ldc = lmida = lmada = lda = 0;
                        foreach (XmlNode j in i) {
                            switch (j.Name) {
                                case "lootDropChance":
                                    ldc = sane(j);
                                    break;
                                case "lootMinimumDropAmount":
                                    lmida = sane(j);
                                    break;
                                case "lootMaximumDropAmount":
                                    lmada = sane(j);
                                    break;
                                case "lootDropAmount":
                                    lda = sane(j);
                                    break;
                                case "loot":
                                    lf.addLoot(new Loot(j.InnerText, ldc, lmida, lmada, lda));
                                    break;
                                default:
                                    MessageBox.Show("Onbekend object type: " + j.Name, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    break;
                            }
                        }
                        lootTable.addLootFamilyList(lf);
                        break;
                    default:
                        MessageBox.Show("Onbekend object type: " + i.Name, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                }
            }

            //lootTable.printTable();

            return lootTable;
        }
    }
}
