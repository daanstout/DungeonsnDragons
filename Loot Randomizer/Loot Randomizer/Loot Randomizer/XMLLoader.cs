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

        public LootTable importLootTable(string fileName) {
            LootTable lootTable = new LootTable();

            try {
                XmlDocument doc = new XmlDocument();
                FileStream fs = new FileStream(Referal.lootTablesMapName + fileName + Referal.XMLFileAnotation, FileMode.Open, FileAccess.Read);
                doc.Load(fs);
                XmlNode root = doc.LastChild;
                XmlNodeList objects = root.ChildNodes;

                del sane = x => int.Parse(x.InnerText);

                

                foreach(XmlNode i in objects) {
                    switch (i.Name) {
                        case "lootTableName":
                            lootTable.lootTableName = i.InnerText.ToString();
                            break;
                        case "loot":
                            Loot temp = new Loot();
                            foreach(XmlNode j in i) {
                                switch (j.Name) {
                                    case "lootName":
                                        temp.lootName = j.InnerText;
                                        break;
                                    case "lootDropChance":
                                        temp.lootDropChance = sane(j);
                                        break;
                                    case "lootMinimumDropAmount":
                                        temp.lootMinimumDropAmount = sane(j);
                                        break;
                                    case "lootMaximumDropAmount":
                                        temp.lootMinimumDropAmount = sane(j);
                                        break;
                                    case "lootDropAmount":
                                        temp.lootDropAmount = sane(j);
                                        break;
                                    default:
                                        MessageBox.Show("Onbekend object type: " + j.Name, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        break;
                                }
                            }
                            lootTable.addLoost(temp);
                            break;
                        default:
                            MessageBox.Show("Onbekend object type: " + i.Name, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                    }
                }
                
                lootTable.printTable();


            } catch (Exception e) {

            }
            return null;
        }
    }
}
