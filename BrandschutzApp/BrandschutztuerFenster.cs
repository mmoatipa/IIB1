using System;
using System.Windows.Forms;
using BrandschutzDaten;

namespace BrandschutzApp
{
    /// <summary>
    /// In dieser Form kann der Nutzer die Brandschutzanforderungen der ausgewählten Tür ändern.
    /// </summary>
    public partial class BrandschutztuerFenster : Form
    { 
        public Tuer betrachteteTuer;

        /// <summary>
        /// Konstruktor.
        /// </summary>
        /// <param name="_tuer">betrachtete Tür</param>
        public BrandschutztuerFenster(Tuer _tuer)
        {
            InitializeComponent();
            betrachteteTuer = _tuer;
            initiiereBedienelemente();
        }

        #region Kontrollstrukturen
        /// <summary>
        /// Betätigen dieses Buttons öffnet eine MessageBox mit der Definition der zur Auswahl stehenden Brandschutzanforderungen.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void buttonHilfe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hilfestellung");
        }

        /// <summary>
        /// Bei Betätigen dieses Buttons wird der in der ComboBox ausgewählte Wert an das Hauptfenster übergeben und 
        /// dieses Fenster geschlossen.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void buttonBestaetigen_Click(object sender, EventArgs e)
        {
            betrachteteTuer.Brandschutz = comboBoxBrandschutz.SelectedItem.ToString();
            //TODO: neuen Wert an das Hauptfenster übergeben.
            this.Close();
        }

        /// <summary>
        /// Bei Betätigen dieses Buttons wird das Fenster ohne Annahme der Änderung geschlossen.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        //TODO: Methode um Brandschutzanforderungen ans Hauptfenster übertragen

        /// <summary>
        /// Diese Methode füllt die Bedienelemente mit Werten der betrachteten Tür.
        /// </summary>
        private void initiiereBedienelemente()
        {
            groupBoxBrandschutztuer.Text = betrachteteTuer.Name;
            comboBoxBrandschutz.SelectedIndex = 0;
            //TODO: Brandschutzanforderung der Tür auswählen
        }

    }
}
