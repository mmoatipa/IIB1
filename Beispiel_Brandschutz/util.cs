using System;
using System.Collections.Generic;
using System.Linq;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB.Architecture;
using BrandschutzDaten;
using Autodesk.Revit.DB.Structure;

namespace BrandschutzRevit
{
    /// <summary>
    /// Statische Util-Klasse, die das Parsing zwischen Revit und eigener Datenhaltung übernimmt und weitere Filterfunktionen für die Revit API bietet.
    /// </summary>
    public static class Util
    {
        #region Attribute
        private static Document doc=null;

        public static Document Doc
        {
            set
            {
                doc = value;
            }
        }
        #endregion;

        #region Methoden

        //TODO: Methode zum Speichern der Änderungen schreiben

        //TODO: Methode zum Markieren der Notausgänge schreiben
                
        #region Parsing
        /// <summary>
        /// Parst einen Revit-Raum in einen Raum-Raum.
        /// </summary>
        /// <param name="_room">Raum, der geparst werden soll.</param>
        /// <returns>Den Raum als Instanz der Klasse Raum</returns>
        public static Raum ParseRaum(Room _room)
        {
            Dictionary<FamilyInstance, bool> zugehörigeTueren = FindeAlleRaumTueren(_room);
            Dictionary<Tuer, bool> meineTueren = new Dictionary<Tuer, bool>();
            foreach (FamilyInstance f in zugehörigeTueren.Keys)
                meineTueren.Add(ParseTuer(f), zugehörigeTueren[f]);
            return new Raum(_room.UniqueId, _room.Name, meineTueren);
        }

        /// <summary>
        /// Parst eine Revit FamilyInstance (Door) in eine Tuer.
        /// </summary>
        /// <param name="revitTuer">Tür, die geparst werden soll.</param>
        /// <returns>Die Tür als Instanz der Klasse Tuer</returns>
        public static Tuer ParseTuer(FamilyInstance revitTuer)
        {
            string brandschutz ="";
            return new Tuer(revitTuer.UniqueId,revitTuer.Name,brandschutz);            
        }
        #endregion

        /// <summary>
        /// Platziert FamilyInstances vor der ausgewählten Tür.
        /// </summary>
        /// <param name="tuer">Tür, vor der eine Bodenlampe platziert werden soll</param
        /// <param name="markierung">Das FamilySymbol, das vor der Tür platziert werden soll.</param>
        private static void PlatziereMarkierung(FamilyInstance tuer, FamilySymbol markierung)
        {
            double wanddicke = 0, korrekturX = 0, korrekturY = 0;
            XYZ tuerPlatzierung = null, tuerOrientierung = null, markierungPlatzierung = null; 
            //TODO: Platzierung der Tür herausfinden

            //Wenn die Tür entlang der Y-Achse ausgerichtet ist
            if(Math.Abs(tuerOrientierung.X)>0.1)
            {
                if (tuerOrientierung.X > 0)
                    korrekturX = -wanddicke;
                else
                    korrekturX = wanddicke;
            }
            //Wenn die Tür entlang der X-Achse ausgerichtet ist
            else
            {
                if (tuerOrientierung.Y > 0)
                    korrekturY = -wanddicke;
                else
                    korrekturY = wanddicke;
            }
            
            //TODO: Platzierung des Elements
        }
        
        //TODO: Methode zum Auslesen des zu platzierenden FamilySymbols schreiben

        /// <summary>
        /// Findet alle zugehörigen Notausgänge eines Raumes (als Raum). Anforderung an einen Notausgang ist, dass dieser Brandschutz-
        /// anforderungen besitzt.
        /// </summary>
        /// <param name="raum">Raum, für den die Notausgänge gefunden werden sollen.</param>
        /// <returns>Einen Dictionary aller Türen (als Tuer) und jeweils einem Boolean, der wahr ist, wenn die Tür in den Raum hineinführt</returns>
        private static Dictionary<Tuer, bool> FindeNotausgaenge(Raum raum)
        {
            Dictionary<Tuer,bool> notausgaenge = new Dictionary<Tuer, bool>();
            
            //TODO: Notausgänge filtern

            return notausgaenge;
        }

        /// <summary>
        /// Findet alle Türen, die an den betrachteten Raum (als Room) angrenzen. Dabei gibt der Value-Boolean an, ob die Tür in den
        /// Raum hineinführt (true) oder nicht.
        /// </summary>
        /// <param name="room">Betrachteter Raum</param>
        /// <returns>Einen Dictionary aller Türen (als FamilyInstance) und jeweils einem Boolean, der wahr ist, wenn die Tür in den Raum hineinführt</returns>
        private static Dictionary<FamilyInstance, bool> FindeAlleRaumTueren(Room room)
        {
            Dictionary<FamilyInstance, bool> alleTueren = new Dictionary<FamilyInstance, bool>();
            try
            {
                FilteredElementCollector coll = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_Doors).
                    OfClass(typeof(FamilyInstance));
                List<FamilyInstance> allDoors = new List<FamilyInstance>();
                //TODO: Die Türen, die an den betrachteten Raum angrenzen, herausfiltern und herausfinden, ob sie in den Raum herein oder aus ihm heraus führen.
            }
            catch (Exception ex)
            {
                TaskDialog.Show("", ex.Message);
            }

            return alleTueren;
        }
        #endregion
    }
}
