namespace BrandschutzApp
{
    partial class BrandschutztuerFenster
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
            this.buttonBestaetigen = new System.Windows.Forms.Button();
            this.comboBoxBrandschutz = new System.Windows.Forms.ComboBox();
            this.groupBoxBrandschutztuer = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.buttonHilfe = new System.Windows.Forms.Button();
            this.groupBoxBrandschutztuer.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBestaetigen
            // 
            this.buttonBestaetigen.Location = new System.Drawing.Point(167, 41);
            this.buttonBestaetigen.Name = "buttonBestaetigen";
            this.buttonBestaetigen.Size = new System.Drawing.Size(75, 23);
            this.buttonBestaetigen.TabIndex = 0;
            this.buttonBestaetigen.Text = "Bestätigen";
            this.buttonBestaetigen.UseVisualStyleBackColor = true;
            this.buttonBestaetigen.Click += new System.EventHandler(this.buttonBestaetigen_Click);
            // 
            // comboBoxBrandschutz
            // 
            this.comboBoxBrandschutz.FormattingEnabled = true;
            this.comboBoxBrandschutz.Location = new System.Drawing.Point(6, 49);
            this.comboBoxBrandschutz.Name = "comboBoxBrandschutz";
            this.comboBoxBrandschutz.Size = new System.Drawing.Size(130, 21);
            this.comboBoxBrandschutz.TabIndex = 1;
            // 
            // groupBoxBrandschutztuer
            // 
            this.groupBoxBrandschutztuer.Controls.Add(this.label1);
            this.groupBoxBrandschutztuer.Controls.Add(this.comboBoxBrandschutz);
            this.groupBoxBrandschutztuer.Controls.Add(this.buttonAbbrechen);
            this.groupBoxBrandschutztuer.Controls.Add(this.buttonHilfe);
            this.groupBoxBrandschutztuer.Controls.Add(this.buttonBestaetigen);
            this.groupBoxBrandschutztuer.Location = new System.Drawing.Point(12, 12);
            this.groupBoxBrandschutztuer.Name = "groupBoxBrandschutztuer";
            this.groupBoxBrandschutztuer.Size = new System.Drawing.Size(260, 100);
            this.groupBoxBrandschutztuer.TabIndex = 2;
            this.groupBoxBrandschutztuer.TabStop = false;
            this.groupBoxBrandschutztuer.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Brandschutzanforderung";
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Location = new System.Drawing.Point(167, 70);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.buttonAbbrechen.TabIndex = 0;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
            // 
            // buttonHilfe
            // 
            this.buttonHilfe.Location = new System.Drawing.Point(167, 12);
            this.buttonHilfe.Name = "buttonHilfe";
            this.buttonHilfe.Size = new System.Drawing.Size(75, 23);
            this.buttonHilfe.TabIndex = 0;
            this.buttonHilfe.Text = "Hilfe";
            this.buttonHilfe.UseVisualStyleBackColor = true;
            this.buttonHilfe.Click += new System.EventHandler(this.buttonHilfe_Click);
            // 
            // BrandschutztuerFenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 118);
            this.Controls.Add(this.groupBoxBrandschutztuer);
            this.Name = "BrandschutztuerFenster";
            this.Text = "BrandschutztuerFenster";
            this.groupBoxBrandschutztuer.ResumeLayout(false);
            this.groupBoxBrandschutztuer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBestaetigen;
        private System.Windows.Forms.ComboBox comboBoxBrandschutz;
        private System.Windows.Forms.GroupBox groupBoxBrandschutztuer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAbbrechen;
        private System.Windows.Forms.Button buttonHilfe;
    }
}