using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet {
    public static class Configurable {
        public static SolidBrush stringBrush;

        public static int[] levelList = new int[19] { 300, 900, 2700, 6500, 14000, 23000, 34000, 48000, 64000, 85000, 100000, 120000, 140000, 165000, 195000, 225000, 265000, 305000, 355000 };
        public static int[] proficiencyUpList = new int[4] { 5, 9, 13, 16 };
    }
}
