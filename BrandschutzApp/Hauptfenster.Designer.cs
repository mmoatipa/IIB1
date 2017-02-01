namespace BrandschutzApp
{
    partial class Hauptfenster
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
            this.listBoxTueren = new System.Windows.Forms.ListBox();
            this.listBoxBrandschutzTueren = new System.Windows.Forms.ListBox();
            this.buttonEntfernen = new System.Windows.Forms.Button();
            this.buttonHinzufuegen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxRaum = new System.Windows.Forms.GroupBox();
            this.buttonEinfügen = new System.Windows.Forms.Button();
            this.buttonAnnehmen = new System.Windows.Forms.Button();
            this.groupBoxRaum.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxTueren
            // 
            this.listBoxTueren.FormattingEnabled = true;
            this.listBoxTueren.Location = new System.Drawing.Point(6, 46);
            this.listBoxTueren.Name = "listBoxTueren";
            this.listBoxTueren.Size = new System.Drawing.Size(116, 95);
            this.listBoxTueren.TabIndex = 0;
            // 
            // listBoxBrandschutzTueren
            // 
            this.listBoxBrandschutzTueren.FormattingEnabled = true;
            this.listBoxBrandschutzTueren.Location = new System.Drawing.Point(209, 46);
            this.listBoxBrandschutzTueren.Name = "listBoxBrandschutzTueren";
            this.listBoxBrandschutzTueren.Size = new System.Drawing.Size(116, 95);
            this.listBoxBrandschutzTueren.TabIndex = 1;
            this.listBoxBrandschutzTueren.DoubleClick += new System.EventHandler(this.listBoxBrandschutzTueren_DoubleClick);
            // 
            // buttonEntfernen
            // 
            this.buttonEntfernen.Location = new System.Drawing.Point(128, 103);
            this.buttonEntfernen.Name = "buttonEntfernen";
            this.buttonEntfernen.Size = new System.Drawing.Size(75, 23);
            this.buttonEntfernen.TabIndex = 2;
            this.buttonEntfernen.Text = "entfernen";
            this.buttonEntfernen.UseVisualStyleBackColor = true;
            this.buttonEntfernen.Click += new System.EventHandler(this.buttonEntfernen_Click);
            // 
            // buttonHinzufuegen
            // 
            this.buttonHinzufuegen.Location = new System.Drawing.Point(128, 74);
            this.buttonHinzufuegen.Name = "buttonHinzufuegen";
            this.buttonHinzufuegen.Size = new System.Drawing.Size(75, 23);
            this.buttonHinzufuegen.TabIndex = 2;
            this.buttonHinzufuegen.Text = "hinzufügen";
            this.buttonHinzufuegen.UseVisualStyleBackColor = true;
            this.buttonHinzufuegen.Click += new System.EventHandler(this.buttonHinzufuegen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Normale Türen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Brandschutztüren";
            // 
            // groupBoxRaum
            // 
            this.groupBoxRaum.Controls.Add(this.listBoxBrandschutzTueren);
            this.groupBoxRaum.Controls.Add(this.buttonHinzufuegen);
            this.groupBoxRaum.Controls.Add(this.buttonEntfernen);
            this.groupBoxRaum.Controls.Add(this.label2);
            this.groupBoxRaum.Controls.Add(this.listBoxTueren);
            this.groupBoxRaum.Controls.Add(this.label1);
            this.groupBoxRaum.Location = new System.Drawing.Point(12, 12);
            this.groupBoxRaum.Name = "groupBoxRaum";
            this.groupBoxRaum.Size = new System.Drawing.Size(331, 159);
            this.groupBoxRaum.TabIndex = 4;
            this.groupBoxRaum.TabStop = false;
            this.groupBoxRaum.Text = "groupBox1";
            // 
            // buttonEinfügen
            // 
            this.buttonEinfügen.Location = new System.Drawing.Point(192, 177);
            this.buttonEinfügen.Name = "buttonEinfügen";
            this.buttonEinfügen.Size = new System.Drawing.Size(145, 23);
            this.buttonEinfügen.TabIndex = 5;
            this.buttonEinfügen.Text = "Markierungen einfügen";
            this.buttonEinfügen.UseVisualStyleBackColor = true;
            this.buttonEinfügen.Click += new System.EventHandler(this.buttonEinfügen_Click);
            // 
            // buttonAnnehmen
            // 
            this.buttonAnnehmen.Location = new System.Drawing.Point(18, 177);
            this.buttonAnnehmen.Name = "buttonAnnehmen";
            this.buttonAnnehmen.Size = new System.Drawing.Size(145, 23);
            this.buttonAnnehmen.TabIndex = 6;
            this.buttonAnnehmen.Text = "Änderungen übernehmen";
            this.buttonAnnehmen.UseVisualStyleBackColor = true;
            this.buttonAnnehmen.Click += new System.EventHandler(this.buttonAnnehmen_Click);
            // 
            // Hauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 212);
            this.Controls.Add(this.buttonAnnehmen);
            this.Controls.Add(this.buttonEinfügen);
            this.Controls.Add(this.groupBoxRaum);
            this.Name = "Hauptfenster";
            this.Text = "Brandschutz App";
            this.groupBoxRaum.ResumeLayout(false);
            this.groupBoxRaum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTueren;
        private System.Windows.Forms.ListBox listBoxBrandschutzTueren;
        private System.Windows.Forms.Button buttonEntfernen;
        private System.Windows.Forms.Button buttonHinzufuegen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxRaum;
        private System.Windows.Forms.Button buttonEinfügen;
        private System.Windows.Forms.Button buttonAnnehmen;
    }
}

