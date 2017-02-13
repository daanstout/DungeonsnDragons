using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterSheet {
    public static class Referal {
        public static string Dwarf = "Dwarf";
        public static string Elf = "Elf";
        public static string Halfling = "Halfling";
        public static string Human = "Human";
        public static string Dragonborn = "Dragonborn";
        public static string Gnome = "Gnome";
        public static string Half_Elf = "Half-Elf";
        public static string Half_Orc = "Half-Orc";
        public static string Tiefling = "Tiefling";

        //public static int D4 = 4;
        //public static int D6 = 6;
        //public static int D8 = 8;
        //public static int D10 = 10;
        //public static int D12 = 12;
        //public static int D20 = 20;

        public enum hitDie {
            D4 = 4,
            D6 = 6,
            D8 = 8,
            D10 = 10,
            D12 = 12,
            D20 = 20,
        }

        public static string Strength = "Strength";
        public static string Dexterity = "Dexterity";
        public static string Constitution = "Constitution";
        public static string Intelligence = "Intelligence";
        public static string Wisdom = "Wisdom";
        public static string Charisma = "Charisma";

        public static string Acrobatics = "Acrobatis";
        public static string Animal_Handling = "Animal Handling";
        public static string Arcana = "Arcana";
        public static string Athletics = "Athletics";
        public static string Deception = "Deception";
        public static string History = "History";
        public static string Insight = "Insight";
        public static string Intimidation = "Intimidation";
        public static string Investigation = "Investigation";
        public static string Medicine = "Medicine";
        public static string Nature = "Nature";
        public static string Perception = "Perception";
        public static string Performance = "Performance";
        public static string Persuasion = "Persuasion";
        public static string Religion = "Religion";
        public static string Sleight_of_Hand = "Sleight of Hand";
        public static string Stealth = "Stealth";
        public static string Survival = "Survival";

        public static string Lawful_Good = "Lawful Good";
        public static string Neutral_Good = "Neutral Good";
        public static string Chaotic_Good = "Chaotic Good";
        public static string Lawful_Neutral = "Lawful Neutral";
        public static string Neutral = "Neutral";
        public static string Chaotic_Neutral = "Chaotic Neutral";
        public static string Lawful_Evil = "Lawful Evil";
        public static string Neutral_Evil = "Neutral Evil";
        public static string Chaotic_Evil = "Chaotic Evil";

        public static string Acolyte = "Acolyte";
        public static string Charlatan = "Charlatan";
        public static string Criminal = "Criminal";
        public static string Entertainer = "Entertainer";
        public static string Folk_Hero = "Folk Hero";
        public static string Guild_Artisan = "Guild Artisan";
        public static string Hermit = "Hermit";
        public static string Noble = "Noble";
        public static string Outlander = "Outlander";
        public static string Sage = "Sage";
        public static string Sailor = "Sailor";
        public static string Soldier = "Soldier";
        public static string Urchin = "Urchin";

        public static CharacterClass Barbarian = new CharacterClass("Barbarian", "A fierce warrior of primitive background who can enter a battle rage", hitDie.D12, Strength, Strength + "/" + Constitution, "Light and medium armor, shields, simple and martial weapons");
        public static CharacterClass Bard = new CharacterClass("Bard", "An inspiring magician whose power echoes the music of creation", hitDie.D8, Charisma, Dexterity + "/" + Charisma, "Light armor, simple weapons, hand crossbows, longswords, rapiers, shortswords");
        public static CharacterClass Cleric = new CharacterClass("Cleric", "A pries champion who wields divine magic in service of a higher power", hitDie.D8, Wisdom, Wisdom + "/" + Charisma, "Light and medium armor, shields, simple weapons");
        public static CharacterClass Druid = new CharacterClass("Druid", "A pries of the Old Faith, wielding the powers of nature - moonlight and plant growth, fire and lightning - and adopting animal forms", hitDie.D8, Wisdom, Intelligence + "/" + Wisdom, "Light and medium armor (nonmetal), shields (nonmetal), clubs, daggers, darts, javelins, maces, quarterstaffs, scimitars, sickles, slings, spears");
        public static CharacterClass Fighter = new CharacterClass("Fighter", "A master of martial combat, skilled with a variety of weapons and armor", hitDie.D10, Strength + "||" + Dexterity, Strength + "/" + Constitution, "All armor, sields, simple and martial weapons");
        public static CharacterClass Monk = new CharacterClass("Monk", "A master of martial arts, harnessing the power of the body in pursuit of physical and spritual perfection", hitDie.D8, Dexterity + "/" + Wisdom, Strength + "/" + Dexterity, "Simple weapons, shortswords");
        public static CharacterClass Paladin = new CharacterClass("Paladin", "A holy warrior bound to a sacred oath", hitDie.D10, Strength + "/" + Charisma, Wisdom + "/" + Charisma, "All armor, shields, simple and martial weapons");
        public static CharacterClass Ranger = new CharacterClass("Ranger", "A warrior who uses martial prowess and nature magic to combat threats on the edges of civilization", hitDie.D10, Dexterity + "/" + Wisdom, Strength + "/" + Dexterity, "Light and medium armor, shields, simple and martial weapons");
        public static CharacterClass Rogue = new CharacterClass("Rogue", "A scoundrel who uses stealth and trickery to overcome obstacles and enemies", hitDie.D8, Dexterity, Dexterity + "/" + Intelligence, "Light armor, simple weapons, hand, crossbows, longswords, rapiers, shortswords");
        public static CharacterClass Sorcerer = new CharacterClass("Sorcerer", "A Spellcaster who draws on inherent magic from a gift or bloodline", hitDie.D6, Charisma, Constitution + "/" + Charisma, "Daggers, dards, slings, quarterstaffs, light crossbows");
        public static CharacterClass Warlock = new CharacterClass("Warlock", "A wielder of magic that is derived from a bargain with an extraplaner entity", hitDie.D8, Charisma, Wisdom + "/" + Charisma, "Light armor, simple weapons");
        public static CharacterClass Wizard = new CharacterClass("Wizard", "A scholarly magic-user capable of manipulating the structures of reality", hitDie.D6, Intelligence, Intelligence + "/" + Wisdom, "Daggers, dards, slings, quarterstaffs, light crossbows");

        public static Armor Padded = new LightArmor("Padded", 11, true, 8);
        public static Armor Leather = new LightArmor("Leather", 11, false, 10);
        public static Armor Studded_Leather = new LightArmor("Studded_Leather", 12, false, 13);

        public static Armor Hide = new MediumArmor("Hide", 12, false, 12);
        public static Armor Chain_Shirt = new MediumArmor("Chain Shirt", 13, false, 20);
        public static Armor Scale_Mail = new MediumArmor("Scale Mail", 14, true, 45);
        public static Armor Breastplate = new MediumArmor("Breastplate", 14, false, 20);
        public static Armor Half_Plate = new MediumArmor("Half Plate", 15, true, 40);

        public static Armor Ring_Mail = new HeavyArmor("Ring Mail", 14, true, 40, 0);
        public static Armor Chain_Mail = new HeavyArmor("Chain Mail", 16, true, 55, 13);
        public static Armor Splint = new HeavyArmor("Splint", 17, true, 60, 15);
        public static Armor Plate = new HeavyArmor("Plate", 18, true, 65, 15);

        public static int getMaxHitPoints(hitDie hpDie, int constitutionModifier, int level) {
            return (int)((int)hpDie + constitutionModifier + ((Math.Ceiling((double)(hpDie + 1) / 2)) + constitutionModifier) * (level - 1));
        }

        public static int getMaxCurrentHitPoints(int maxHitPoints, int bonusHealth) {
            return maxHitPoints + bonusHealth;
        }

        public static int getModifier(int abilityScore) {
            return (int)Math.Floor((double)(abilityScore - 10) / 2);
        }

        public static int getArmorClass(Armor armor, int modifier, bool shield) {
            int baseArmor = armor.baseArmor;

            int bonusArmor = 0;

            if (armor is LightArmor) {
                bonusArmor = modifier;
            }else if(armor is MediumArmor) {
                bonusArmor = modifier > 2 ? 2 : modifier;
            }

            int armorClass = baseArmor + bonusArmor + (shield ? 2 : 0);

            return armorClass;
        }

        public static int getLevel(int experience) {
            int level = 1;
            foreach (int i in Configurable.levelList) {
                if (experience >= i) { level++; } else { break; }
            }
            return level;
        }

        public static int getProficiency(int level) {
            int proficiency = 2;
            foreach (int i in Configurable.proficiencyUpList) {
                if(level == i) proficiency++;
            }
            return proficiency;
        }

        public static Bitmap ResizeImage(Image image, int width, int height) {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage)) {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes()) {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public static void DrawCurvedText(Graphics graphics, string text, Point centre, float distanceFromCentreToBaseOfText, float radiansToTextCentre, Font font, Brush brush) {
            // Circumference for use later
            var circleCircumference = (float)(Math.PI * 2 * distanceFromCentreToBaseOfText);

            // Get the width of each character
            var characterWidths = GetCharacterWidths(graphics, text, font).ToArray();

            // The overall height of the string
            var characterHeight = graphics.MeasureString(text, font).Height;

            var textLength = characterWidths.Sum();

            // The string length above is the arc length we'll use for rendering the string. Work out the starting angle required to 
            // centre the text across the radiansToTextCentre.
            float fractionOfCircumference = textLength / circleCircumference;

            float currentCharacterRadians = radiansToTextCentre - (float)(Math.PI * fractionOfCircumference);

            for (int characterIndex = 0; characterIndex < text.Length; characterIndex++) {
                char @char = text[characterIndex];

                // Polar to cartesian
                float x = (float)(distanceFromCentreToBaseOfText * Math.Sin(currentCharacterRadians));
                float y = -(float)(distanceFromCentreToBaseOfText * Math.Cos(currentCharacterRadians));

                using (GraphicsPath characterPath = new GraphicsPath()) {
                    characterPath.AddString(@char.ToString(), font.FontFamily, (int)font.Style, font.Size, Point.Empty,
                                            StringFormat.GenericTypographic);

                    var pathBounds = characterPath.GetBounds();

                    // Transformation matrix to move the character to the correct location. 
                    // Note that all actions on the Matrix class are prepended, so we apply them in reverse.
                    var transform = new Matrix();

                    // Translate to the final position
                    transform.Translate(centre.X + x, centre.Y + y);

                    // Rotate the character
                    var rotationAngleDegrees = currentCharacterRadians * 180F / (float)Math.PI;
                    transform.Rotate(rotationAngleDegrees);

                    // Translate the character so the centre of its base is over the origin
                    transform.Translate(-pathBounds.Width / 2F, -characterHeight);

                    characterPath.Transform(transform);

                    // Draw the character
                    graphics.FillPath(brush, characterPath);
                }

                if (characterIndex != text.Length - 1) {
                    // Move "currentCharacterRadians" on to the next character
                    var distanceToNextChar = (characterWidths[characterIndex] + characterWidths[characterIndex + 1]) / 2F;
                    float charFractionOfCircumference = distanceToNextChar / circleCircumference;
                    currentCharacterRadians += charFractionOfCircumference * (float)(2F * Math.PI);
                }
            }
        }

        private static IEnumerable<float> GetCharacterWidths(Graphics graphics, string text, Font font) {
            // The length of a space. Necessary because a space measured using StringFormat.GenericTypographic has no width.
            // We can't use StringFormat.GenericDefault for the characters themselves, as it adds unwanted spacing.
            var spaceLength = graphics.MeasureString(" ", font, Point.Empty, StringFormat.GenericDefault).Width;

            return text.Select(c => c == ' ' ? spaceLength : graphics.MeasureString(c.ToString(), font, Point.Empty, StringFormat.GenericTypographic).Width);
        }

        public static void fillConfigurable() {
            Configurable.stringBrush = new SolidBrush(Color.Black);
        }

        public static void setLabelForeColorProficiency(int modifier, ref Label label) {
            if(modifier > 0) {
                label.ForeColor = Color.Green;
            }else if(modifier < 0) {
                label.ForeColor = Color.Red;
            }else {
                label.ForeColor = Color.Black;
            }
        }
    }
}
