using System;

namespace BrandschutzDaten
{
    public class Tuer : RevitElement
    {
        #region Attribute
        private string brandschutz;
        
        public string Brandschutz
        {
            get
            {
                return brandschutz;
            }

            set
            {
                brandschutz = value;
            }
        }
        #endregion

        /// <summary>
        /// Standardkonstruktor der Klasse Tuer
        /// </summary>
        public Tuer() : base()
        {
            brandschutz = "";
        }
        /// <summary>
        /// Erzeugt eine neue Instanz der Klasse Tuer
        /// </summary>
        /// <param name="_revitId">Die von Revit verwendete GUID</param>
        /// <param name="_name">Der Name der hinzuzufügenden Tür</param>
        /// <param name="_brandschutz">Die Brandschutzanforderung an die Tür</param>
        public Tuer(String _revitId, String _name, String _brandschutz) : base(_revitId, _name)
        {
            brandschutz = _brandschutz;
        }
    }
}
