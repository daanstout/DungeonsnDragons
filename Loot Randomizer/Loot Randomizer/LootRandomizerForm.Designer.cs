namespace Loot_Randomizer {
    partial class lootRandomizerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lootRandomizerForm));
            this.LootTablesComboBox = new System.Windows.Forms.ComboBox();
            this.generateLootButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LootTablesComboBox
            // 
            this.LootTablesComboBox.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LootTablesComboBox.FormattingEnabled = true;
            this.LootTablesComboBox.Location = new System.Drawing.Point(16, 29);
            this.LootTablesComboBox.Name = "LootTablesComboBox";
            this.LootTablesComboBox.Size = new System.Drawing.Size(159, 23);
            this.LootTablesComboBox.TabIndex = 0;
            // 
            // generateLootButton
            // 
            this.generateLootButton.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateLootButton.Location = new System.Drawing.Point(185, 29);
            this.generateLootButton.Name = "generateLootButton";
            this.generateLootButton.Size = new System.Drawing.Size(151, 25);
            this.generateLootButton.TabIndex = 1;
            this.generateLootButton.Text = "Generate Loot";
            this.generateLootButton.UseVisualStyleBackColor = true;
            this.generateLootButton.Click += new System.EventHandler(this.generateLootButton_Click);
            // 
            // lootRandomizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 90);
            this.Controls.Add(this.generateLootButton);
            this.Controls.Add(this.LootTablesComboBox);
            this.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "lootRandomizerForm";
            this.Text = "Loot Randomizer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox LootTablesComboBox;
        private System.Windows.Forms.Button generateLootButton;
    }
}

