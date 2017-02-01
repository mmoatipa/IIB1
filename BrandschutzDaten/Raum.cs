using System;
using System.Collections.Generic;

namespace BrandschutzDaten
{
    /// <summary>
    /// Diese Klasse dient der Verwaltung von Räumen.
    /// </summary>
    public class Raum : RevitElement
    {
        #region Attribute
        //Der bool des Dictionaries gibt ist true, wenn die Tür in den Raum hereinführt.
        //Der Dictionary besitzt nur einen Getter, da aus der App keine Änderung in der Zuweisung der Räume stattfinden soll.
        private Dictionary<Tuer, bool> tueren;
        public Dictionary<Tuer, bool> Tueren
        {
            get
            {
                return tueren;
            }
        }

        #endregion

        #region Konstruktoren
        /// <summary>
        /// Standardkonstruktor der Klasse Raum
        /// </summary>
        public Raum() : base()
        {
            tueren = new Dictionary<Tuer, bool>();
        }

        /// <summary>
        /// Erzeugt eine neue Instanz der Klasse Raum
        /// </summary>
        /// <param name="_revitId">Die von Revit verwendete GUID</param>
        /// <param name="_name">Der Name des zu erzeugenden Raumes</param>
        public Raum(String _revitId, String _name) :base(_revitId,_name)
        {
            tueren = new Dictionary<Tuer, bool>();
        }

        /// <summary>
        /// Erzeugt eine neue Instanz der Klasse Raum
        /// </summary>
        /// <param name="_revitId">Die von Revit verwendete GUID</param>
        /// <param name="_name">Der Name des zu erzeugenden Raumes</param>
        /// <param name="_hereinfuehrendeTueren">Die Liste der in den Raum hereinführenden Türen</param>
        /// <param name="_herausfuehrendeTueren">Die Liste der aus den Raum herausführenden Türen</param>
        public Raum(String _revitId, String _name, Dictionary<Tuer,bool> _tueren) : base(_revitId, _name)
        {
            tueren = _tueren;
        }            
        #endregion
    }
}
