namespace RandomNameGen {
    partial class Form1 {
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
            this.generateNameButton = new System.Windows.Forms.Button();
            this.raceListComboBox = new System.Windows.Forms.ComboBox();
            this.generatedNameLabel = new System.Windows.Forms.Label();
            this.maleCheckBox = new System.Windows.Forms.CheckBox();
            this.femaleCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // generateNameButton
            // 
            this.generateNameButton.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateNameButton.Location = new System.Drawing.Point(162, 80);
            this.generateNameButton.Name = "generateNameButton";
            this.generateNameButton.Size = new System.Drawing.Size(100, 23);
            this.generateNameButton.TabIndex = 0;
            this.generateNameButton.Text = "Generate Name";
            this.generateNameButton.UseVisualStyleBackColor = true;
            this.generateNameButton.Click += new System.EventHandler(this.generateNameButton_Click);
            // 
            // raceListComboBox
            // 
            this.raceListComboBox.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceListComboBox.FormattingEnabled = true;
            this.raceListComboBox.Location = new System.Drawing.Point(24, 80);
            this.raceListComboBox.Name = "raceListComboBox";
            this.raceListComboBox.Size = new System.Drawing.Size(121, 23);
            this.raceListComboBox.TabIndex = 1;
            // 
            // generatedNameLabel
            // 
            this.generatedNameLabel.AutoSize = true;
            this.generatedNameLabel.Font = new System.Drawing.Font("Bookman Old Style", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatedNameLabel.Location = new System.Drawing.Point(19, 189);
            this.generatedNameLabel.Name = "generatedNameLabel";
            this.generatedNameLabel.Size = new System.Drawing.Size(79, 25);
            this.generatedNameLabel.TabIndex = 2;
            this.generatedNameLabel.Text = "label1";
            // 
            // maleCheckBox
            // 
            this.maleCheckBox.AutoSize = true;
            this.maleCheckBox.Checked = true;
            this.maleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.maleCheckBox.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleCheckBox.Location = new System.Drawing.Point(184, 134);
            this.maleCheckBox.Name = "maleCheckBox";
            this.maleCheckBox.Size = new System.Drawing.Size(52, 19);
            this.maleCheckBox.TabIndex = 3;
            this.maleCheckBox.Text = "Male";
            this.maleCheckBox.UseVisualStyleBackColor = true;
            this.maleCheckBox.CheckedChanged += new System.EventHandler(this.maleCheckBox_CheckedChanged);
            // 
            // femaleCheckBox
            // 
            this.femaleCheckBox.AutoSize = true;
            this.femaleCheckBox.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleCheckBox.Location = new System.Drawing.Point(184, 160);
            this.femaleCheckBox.Name = "femaleCheckBox";
            this.femaleCheckBox.Size = new System.Drawing.Size(65, 19);
            this.femaleCheckBox.TabIndex = 4;
            this.femaleCheckBox.Text = "Female";
            this.femaleCheckBox.UseVisualStyleBackColor = true;
            this.femaleCheckBox.CheckedChanged += new System.EventHandler(this.femaleCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.femaleCheckBox);
            this.Controls.Add(this.maleCheckBox);
            this.Controls.Add(this.generatedNameLabel);
            this.Controls.Add(this.raceListComboBox);
            this.Controls.Add(this.generateNameButton);
            this.Name = "Form1";
            this.Text = "RandomNameGen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateNameButton;
        private System.Windows.Forms.ComboBox raceListComboBox;
        private System.Windows.Forms.Label generatedNameLabel;
        private System.Windows.Forms.CheckBox maleCheckBox;
        private System.Windows.Forms.CheckBox femaleCheckBox;
    }
}

