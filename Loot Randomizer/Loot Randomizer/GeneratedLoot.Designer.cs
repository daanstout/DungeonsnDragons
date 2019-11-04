namespace Loot_Randomizer {
    partial class GeneratedLoot {
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
            this.generatedLootPictureBox = new System.Windows.Forms.PictureBox();
            this.obtainedLootLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.generatedLootPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // generatedLootPictureBox
            // 
            this.generatedLootPictureBox.BackColor = System.Drawing.Color.White;
            this.generatedLootPictureBox.Location = new System.Drawing.Point(0, 0);
            this.generatedLootPictureBox.Name = "generatedLootPictureBox";
            this.generatedLootPictureBox.Size = new System.Drawing.Size(339, 39);
            this.generatedLootPictureBox.TabIndex = 0;
            this.generatedLootPictureBox.TabStop = false;
            // 
            // obtainedLootLabel
            // 
            this.obtainedLootLabel.AutoSize = true;
            this.obtainedLootLabel.BackColor = System.Drawing.Color.White;
            this.obtainedLootLabel.Location = new System.Drawing.Point(13, 13);
            this.obtainedLootLabel.Name = "obtainedLootLabel";
            this.obtainedLootLabel.Size = new System.Drawing.Size(15, 14);
            this.obtainedLootLabel.TabIndex = 1;
            this.obtainedLootLabel.Text = "T";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.Control;
            this.closeButton.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(133, 50);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // GeneratedLoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 85);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.obtainedLootLabel);
            this.Controls.Add(this.generatedLootPictureBox);
            this.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GeneratedLoot";
            this.Text = "GeneratedLoot";
            ((System.ComponentModel.ISupportInitialize)(this.generatedLootPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox generatedLootPictureBox;
        private System.Windows.Forms.Label obtainedLootLabel;
        private System.Windows.Forms.Button closeButton;
    }
}