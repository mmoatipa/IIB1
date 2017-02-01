using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BrandschutzDaten;
using Autodesk.Revit.UI;

namespace BrandschutzApp
{
    /// <summary>
    /// Dies ist das Hauptfenster der BrandschutzApp. 
    /// </summary>
    public partial class Hauptfenster : Form
    {
        #region Attribute
        private Raum betrachteterRaum;

        //der betrachtete Raum besitzt nur einen Getter, da dieser ohne Benutzereingabe über Auswahl in Revit nicht verändert werden soll.
        public Raum BetrachteterRaum
        {
            get
            {
                return betrachteterRaum;
            }
        }
        #endregion

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="updateEvent">Das Externe Event, das durch die Aufforderung die Änderungen zu übernehmen getriggert werden soll.</param>
        /// <param name="_raum">Der vom Benutzer in Revit ausgewählte Raum.</param>
        public Hauptfenster(Raum _raum)
        {
            InitializeComponent();
            betrachteterRaum = _raum;
            InitiiereBedienelemente();
        }

        #region Kontrollstrukturen
        /// <summary>
        /// Durch Betätigen des Hinzufügen Buttons wird die ausgewählte Tür den Brandschutztüren hinzugefügt.
        /// </summary>
        /// <param name="sender">Sender des Befehls</param>
        /// <param name="e">Event</param>
        private void buttonHinzufuegen_Click(object sender, EventArgs e)
        {
            if (listBoxTueren.SelectedItem != null)
            {
                //TODO: ausgewählte Tür den Brandschutztüren zufügen
            }
            else
                MessageBox.Show("Bitte zunächst eine Tür auswählen!");
        }

        /// <summary>
        /// Durch Betätigen des Entfernen Buttons wird die ausgewählte Brandschutztür aus den Brandschutztüren entfernt und ihr Attribut
        /// Brandschutz geleert.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void buttonEntfernen_Click(object sender, EventArgs e)
        {
            if (listBoxBrandschutzTueren.SelectedItem != null)
            {
                //TODO: ausgewählte Brandschutztür aus den Brandschutztüren löschen
            }
            else
                MessageBox.Show("Bitte zunächst eine Brandschutztür auswählen!");
        }

        /// <summary>
        /// Durch Betätigung des Annehmen Buttons werden alle Änderungen an den Brandschutzanforderungen der Türen des Raumes in das Revit
        /// Dokument übernommen.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void buttonAnnehmen_Click(object sender, EventArgs e)
        {
            //TODO: Veränderte Brandschutzanforderungen in das Revit Dokument übernehmen
        }

        /// <summary>
        /// Durch Betätigung des Einfügen Buttons werden an allen Türen, die aus diesem Raum herausführen und nicht in Büros enden, Notausgangs-
        /// schilder im Revit Dokument platziert
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void buttonEinfügen_Click(object sender, EventArgs e)
        {
            //TODO: Markierungen im Revit Dokument vor den Notausgängen platzieren
        }

        /// <summary>
        /// Durch einen Doppelklick auf eine Brandschutztür wird ein neues Fenster geöffnet, in dem die Brandschutzanforderungen an diese Tür
        /// definiert werden können.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void listBoxBrandschutzTueren_DoubleClick(object sender, EventArgs e)
        {
            Tuer ausgewaehlteTuer = (Tuer)listBoxBrandschutzTueren.SelectedItem;
            BrandschutztuerFenster tuerFenster = new BrandschutztuerFenster(ausgewaehlteTuer);
            tuerFenster.ShowDialog();

        }
        #endregion

        #region Methoden
        /// <summary>
        /// Diese Methode initiiert alle Bedienelemente und füllt sie mit Informationen des betrachteten Raums
        /// </summary>
        private void InitiiereBedienelemente()
        {
            groupBoxRaum.Text = BetrachteterRaum.Name;
            listBoxBrandschutzTueren.ClearSelected();
            listBoxTueren.ClearSelected();
            //TODO: ListBoxen mit normalen und Brandschutztüren füllen
        }
        #endregion
    }
}
