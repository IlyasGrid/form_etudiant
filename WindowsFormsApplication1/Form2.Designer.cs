namespace WindowsFormsApplication1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnAjout = new System.Windows.Forms.Button();
            this.BtnSupp = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.btnAnnule = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BtnMod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // BtnAjout
            // 
            this.BtnAjout.Location = new System.Drawing.Point(44, 270);
            this.BtnAjout.Name = "BtnAjout";
            this.BtnAjout.Size = new System.Drawing.Size(108, 45);
            this.BtnAjout.TabIndex = 1;
            this.BtnAjout.Text = "Ajouter";
            this.BtnAjout.UseVisualStyleBackColor = true;
            // 
            // BtnSupp
            // 
            this.BtnSupp.Location = new System.Drawing.Point(342, 270);
            this.BtnSupp.Name = "BtnSupp";
            this.BtnSupp.Size = new System.Drawing.Size(108, 45);
            this.BtnSupp.TabIndex = 3;
            this.BtnSupp.Text = "Supprimer";
            this.BtnSupp.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(483, 269);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(108, 45);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // btnAnnule
            // 
            this.btnAnnule.Location = new System.Drawing.Point(643, 270);
            this.btnAnnule.Name = "btnAnnule";
            this.btnAnnule.Size = new System.Drawing.Size(108, 45);
            this.btnAnnule.TabIndex = 5;
            this.btnAnnule.Text = "Annuler";
            this.btnAnnule.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 7;
            // 
            // BtnMod
            // 
            this.BtnMod.Location = new System.Drawing.Point(186, 270);
            this.BtnMod.Name = "BtnMod";
            this.BtnMod.Size = new System.Drawing.Size(115, 43);
            this.BtnMod.TabIndex = 8;
            this.BtnMod.Text = "Modifier";
            this.BtnMod.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnMod);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAnnule);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnSupp);
            this.Controls.Add(this.BtnAjout);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnAjout;
        private System.Windows.Forms.Button BtnSupp;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button btnAnnule;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BtnMod;
    }
}