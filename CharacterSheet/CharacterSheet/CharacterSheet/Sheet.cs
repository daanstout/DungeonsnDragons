using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharacterSheet.Properties;

namespace CharacterSheet {
    public partial class Sheet : Form {
        Character character { get; }
        StartScherm startScherm;

        bool shiftPressed = false;

        public Sheet(StartScherm startScherm, Character character) {
            InitializeComponent();

            this.startScherm = startScherm;
            this.character = character;

            //sheetPictureBox.Size = new Size(833, 1084);

            sheetPictureBox.Image = Referal.ResizeImage(Resources.CharacterSheetAdjusted, sheetPictureBox.Width, sheetPictureBox.Height);
        }

        private void sheetPictureBox_Paint(object sender, PaintEventArgs e) {
            base.OnPaint(e);
            {
                characterNameLabel.Text = character.characterName;
                //characterNameLabel.Width = (int)e.Graphics.MeasureString(characterNameLabel.Text, characterNameLabel.Font).Width;


                characterLevelLabel.Text = Referal.getLevel(character.characterExperience).ToString();
                characterLevelLabel.Location = new Point((int)(286 + ((e.Graphics.MeasureString("00", characterLevelLabel.Font).Width - e.Graphics.MeasureString(characterLevelLabel.Text, characterLevelLabel.Font).Width) / 2)), 73);
                //Console.WriteLine(characterLevelLabel.Location);


                raceClassLabel.Text = character.characterRace + " " + character.characterClass.className;
                backgroundLabel.Text = character.characterBackground;
                playerNameLabel.Text = character.playerName;
                experiencePointsLabel.Text = character.characterExperience.ToString();
                alignmentLabel.Text = character.characterAlignment;
                adventuringGroupLabel.Text = character.adventureGroup;


                strengthLabel.Location = new Point((int)(72 - (e.Graphics.MeasureString(character.abilityScores.Strength.score.ToString(), Fonts.bookman16Bold).Width / 2)), 196);
                strengthLabel.Text = character.abilityScores.Strength.score.ToString();

                int strengthModifier = Referal.getModifier(character.abilityScores.Strength.score);
                strengthModifierLabel.Location = new Point(strengthModifier == 0 ? 68 : 64, 235);
                strengthModifierLabel.Text = strengthModifier > 0 ? "+" + strengthModifier : strengthModifier.ToString();
                Referal.setLabelForeColorProficiency(strengthModifier, ref strengthModifierLabel);


                dexterityLabel.Location = new Point((int)(72 - (e.Graphics.MeasureString(character.abilityScores.Dexterity.score.ToString(), Fonts.bookman16Bold).Width / 2)), 294);
                dexterityLabel.Text = character.abilityScores.Dexterity.score.ToString();

                int dexterityModifier = Referal.getModifier(character.abilityScores.Dexterity.score);
                dexterityModifierLabel.Location = new Point(dexterityModifier == 0 ? 68 : 64, 333);
                dexterityModifierLabel.Text = dexterityModifier > 0 ? "+" + dexterityModifier : dexterityModifier.ToString();
                Referal.setLabelForeColorProficiency(dexterityModifier, ref dexterityModifierLabel);


                constitutionLabel.Location = new Point((int)(72 - (e.Graphics.MeasureString(character.abilityScores.Constitution.score.ToString(), Fonts.bookman16Bold).Width / 2)), 392);
                constitutionLabel.Text = character.abilityScores.Constitution.score.ToString();

                int constitutionModifier = Referal.getModifier(character.abilityScores.Constitution.score);
                constitutionModifierLabel.Location = new Point(constitutionModifier == 0 ? 68 : 64, 431);
                constitutionModifierLabel.Text = constitutionModifier > 0 ? "+" + constitutionModifier : constitutionModifier.ToString();
                Referal.setLabelForeColorProficiency(constitutionModifier, ref constitutionModifierLabel);



                intelligenceLabel.Location = new Point((int)(72 - (e.Graphics.MeasureString(character.abilityScores.Intelligence.score.ToString(), Fonts.bookman16Bold).Width / 2)), 490);
                intelligenceLabel.Text = character.abilityScores.Intelligence.score.ToString();

                int intelligenceModifier = Referal.getModifier(character.abilityScores.Intelligence.score);
                intelligenceModifierLabel.Location = new Point(intelligenceModifier == 0 ? 68 : 64, 529);
                intelligenceModifierLabel.Text = intelligenceModifier > 0 ? "+" + intelligenceModifier : intelligenceModifier.ToString();
                Referal.setLabelForeColorProficiency(intelligenceModifier, ref intelligenceModifierLabel);


                wisdomLabel.Location = new Point((int)(72 - (e.Graphics.MeasureString(character.abilityScores.Wisdom.score.ToString(), Fonts.bookman16Bold).Width / 2)), 588);
                wisdomLabel.Text = character.abilityScores.Wisdom.score.ToString();

                int wisdomModifier = Referal.getModifier(character.abilityScores.Wisdom.score);
                wisdomModifierLabel.Location = new Point(wisdomModifier == 0 ? 68 : 64, 627);
                wisdomModifierLabel.Text = wisdomModifier > 0 ? "+" + wisdomModifier : wisdomModifier.ToString();
                Referal.setLabelForeColorProficiency(wisdomModifier, ref wisdomModifierLabel);


                charismaLabel.Location = new Point((int)(74 - (e.Graphics.MeasureString(character.abilityScores.Charisma.score.ToString(), Fonts.bookman16Bold).Width / 2)), 686);
                charismaLabel.Text = character.abilityScores.Charisma.score.ToString();

                int charismaModifier = Referal.getModifier(character.abilityScores.Charisma.score);
                charismaModifierLabel.Location = new Point(charismaModifier == 0 ? 68 : 64, 725);
                charismaModifierLabel.Text = charismaModifier > 0 ? "+" + charismaModifier : charismaModifier.ToString();
                Referal.setLabelForeColorProficiency(charismaModifier, ref charismaModifierLabel);
                

                inspirationPictureBox.Image = Referal.ResizeImage(character.inspiration ? Resources.Green_Check : Resources.Red_Cross, inspirationPictureBox.Width, inspirationPictureBox.Height);

                proficiencyLabel.Text = "+" + Referal.getProficiency(Referal.getLevel(character.characterExperience));

                armorClassLabel.Text = Referal.getArmorClass(character.characterArmor, Referal.getModifier(character.abilityScores.Dexterity.score), character.characterShield).ToString();

                maxHealthLabel.Text = Referal.getMaxHitPoints(character.characterClass.hitDie, Referal.getModifier(character.abilityScores.Constitution.score), Referal.getLevel(character.characterExperience)).ToString();

                temporaryHealthLabel.Text = character.characterTemporaryHealth.ToString();
                temporaryHealthLabel.Location = new Point((int)(468 + ((e.Graphics.MeasureString("00", temporaryHealthLabel.Font).Width - e.Graphics.MeasureString(temporaryHealthLabel.Text, temporaryHealthLabel.Font).Width) / 2)), temporaryHealthLabel.Location.Y);

                //try {
                //    character.characterCurrentHealth = Convert.ToInt32(maxHealthLabel.Text) + Convert.ToInt32(temporaryHealthLabel.Text);
                //}catch (Exception ex) {
                //    Console.WriteLine("error: " + ex);
                //}

                addHealthPictureBox.Image = Referal.ResizeImage(Resources.Green_Plus, addHealthPictureBox.Width, addHealthPictureBox.Height);
                removeHealthPictureBox.Image = Referal.ResizeImage(Resources.Red_Minus, removeHealthPictureBox.Width, removeHealthPictureBox.Height);
                healFullPictureBox.Image = Referal.ResizeImage(Resources.Healing, healFullPictureBox.Width, healFullPictureBox.Height);



                currentHealthLabel.Text = character.characterCurrentHealth.ToString();
                if(character.characterCurrentHealth <= (Referal.getMaxHitPoints(character.characterClass.hitDie, Referal.getModifier(character.abilityScores.Constitution.score), Referal.getLevel(character.characterExperience)) / 3)) {
                    currentHealthLabel.ForeColor = Color.Red;
                }else if(character.characterCurrentHealth <= (Referal.getMaxHitPoints(character.characterClass.hitDie, Referal.getModifier(character.abilityScores.Constitution.score), Referal.getLevel(character.characterExperience)) / 3 * 2)) {
                    currentHealthLabel.ForeColor = Color.Orange;
                }else {
                    currentHealthLabel.ForeColor = Color.FromArgb(39, 175, 47);
                }


                hitDieLabel.Text = character.characterClass.hitDie.ToString();

                //string[] savingThrows = character.characterClass.savingThrowProficiencies.Split('/');
                //foreach (string str in savingThrows) Console.WriteLine(str);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == (Keys.Shift | Keys.ShiftKey)) {
                shiftPressed = true;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Sheet_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.ShiftKey) {
                shiftPressed = false;
            }
        }

        private void Sheet_Load(object sender, EventArgs e) {
            sheetPictureBox.Invalidate();
        }

        private void Sheet_FormClosed(object sender, FormClosedEventArgs e) {
            startScherm.Close();
        }

        private void addHealthPictureBox_Click(object sender, EventArgs e) {
            Console.WriteLine("ADD");
            int characterMaxHealth = 0;
            int characterTemporaryHealth = 0;
            try {
                characterMaxHealth = Convert.ToInt32(maxHealthLabel.Text);
                characterTemporaryHealth = Convert.ToInt32(temporaryHealthLabel.Text);
            }catch(Exception ex) {
                Console.WriteLine(ex);
            }

            character.characterCurrentHealth += (shiftPressed ? 5 : 1);
            
            if(character.characterCurrentHealth > (characterMaxHealth + characterTemporaryHealth)) {
                character.characterCurrentHealth = (characterMaxHealth + characterTemporaryHealth);
            }
            sheetPictureBox.Invalidate();
            currentHealthLabel.Text = character.characterCurrentHealth.ToString();
        }

        private void removeHealthPictureBox_Click(object sender, EventArgs e) {
            Console.WriteLine("Start");
            Console.WriteLine(character.characterCurrentHealth);
            character.characterCurrentHealth -= (shiftPressed ? 5 : 1);
            Console.WriteLine(character.characterCurrentHealth);
            character.unconscious = character.characterCurrentHealth < 0;

            currentHealthLabel.Text = character.characterCurrentHealth.ToString();
            sheetPictureBox.Invalidate();
            Console.WriteLine(currentHealthLabel);
            Console.WriteLine("End\n");
        }

        private void healFullPictureBox_Click(object sender, EventArgs e) {
            int characterMaxHealth = 0;
            int characterTemporaryHealth = 0;
            try {
                characterMaxHealth = Convert.ToInt32(maxHealthLabel.Text);
                characterTemporaryHealth = Convert.ToInt32(temporaryHealthLabel.Text);
            } catch (Exception ex) {
                Console.WriteLine(ex);
            }

            character.characterCurrentHealth = characterMaxHealth + characterTemporaryHealth;

            currentHealthLabel.Text = character.characterCurrentHealth.ToString();
        }
    }
}

