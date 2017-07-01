using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GetStatRolls {
    public class XMLLoader {
        //delegate int del(XmlNode x);
        //del sane = x => int.Parse(x.InnerText);

        Func<XmlNode, int> getInt = node => int.Parse(node.InnerText);

        public void importClassGuide(string fileName, ref List<ClassGuide> list) {
            ClassGuide guide = new ClassGuide();

            try {
                XmlDocument doc = new XmlDocument();
                FileStream fs = new FileStream("Guides/" + fileName + ".xml", FileMode.Open, FileAccess.Read);
                doc.Load(fs);
                XmlNode root = doc.LastChild;
                XmlNodeList objects = root.ChildNodes;

                foreach (XmlNode node in objects) {
                    switch (node.Name) {
                        case "ClassName":
                            guide.className = node.InnerText;
                            break;
                        case "averageStrength":
                            guide.averageStrength = getInt(node);
                            break;
                        case "strengthLeeWay":
                            guide.strengthLeeWay = getInt(node);
                            break;
                        case "averageDexterity":
                            guide.averageDexterity = getInt(node);
                            break;
                        case "dexterityLeeWay":
                            guide.dexterityLeeWay = getInt(node);
                            break;
                        case "averageConstitution":
                            guide.averageConstitution = getInt(node);
                            break;
                        case "constitutionLeeWay":
                            guide.constitutionLeeWay = getInt(node);
                            break;
                        case "averageIntelligence":
                            guide.averageIntelligence= getInt(node);
                            break;
                        case "intelligenceLeeWay":
                            guide.intelligenceLeeWay = getInt(node);
                            break;
                        case "averageWisdom":
                            guide.averageWisdom= getInt(node);
                            break;
                        case "wisdomLeeWay":
                            guide.wisdomLeeWay= getInt(node);
                            break;
                        case "averageCharisma":
                            guide.averageCharisma = getInt(node);
                            break;
                        case "charismaLeeWay":
                            guide.charismaLeeWay = getInt(node);
                            break;
                    }
                }

                list.Add(guide);

            } catch (Exception e) {
                Console.WriteLine(e);
            }
        }
    }
}
