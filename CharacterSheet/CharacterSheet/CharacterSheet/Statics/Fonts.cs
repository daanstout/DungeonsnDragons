using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterSheet.Properties;

namespace CharacterSheet {
    public static class Fonts {
        public static Font arial20 = new Font("Arial", 20);
        public static Font bookman10 = new Font("Bookman Old Style", 10);
        public static Font bookman13 = new Font("Bookman Old Style", 13);
        public static Font bookman14 = new Font("Bookman Old Style", 14);
        public static Font bookman18 = new Font("Bookman Old Style", 18);
        public static Font bookman16Bold = new Font("Bookman Old Style", 16, FontStyle.Bold);
        public static Font bookman18Bold = new Font("Bookman Old Style", 18, FontStyle.Bold);
        public static Font bookman24Bold = new Font("Bookman Old Style", 24, FontStyle.Bold);

        public static SolidBrush blackBrush = new SolidBrush(Color.Black);
        public static SolidBrush redBrush = new SolidBrush(Color.Red);
    }
}
