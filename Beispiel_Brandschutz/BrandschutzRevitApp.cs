using System;
using System.IO;
using System.Windows.Media.Imaging;
using Autodesk.Revit.UI;
using BrandschutzApp;
using Autodesk.Revit.DB.Architecture;
using BrandschutzDaten;

namespace BrandschutzRevit
{
    /// <summary>
    /// Beispielanwendung zur Demonstration von:
    /// 1. Erzeugen eines Ribbons mit Buttons
    /// 2. Verändern vorhandener Objekte aus einer GUI heraus
    /// 3. Platzieren neuer Family Instanzen aus einer GUI heraus
    /// 
    /// Ribbon: Neben der Revit Referenzen müssen weitere Referenzen hinzugefügt werden (Für das Handling von Grafiken auf den Buttons):
    /// - PresentationCore
    /// - WindowsBase
    /// - System.Windows.Forms
    /// - System.Windows.Presentation
    /// 
    /// Quellen: 
    /// - Revit 2017 SDK, Sample "Ribbon"
    /// </summary>
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    [Autodesk.Revit.Attributes.Regeneration(Autodesk.Revit.Attributes.RegenerationOption.Manual)]
    [Autodesk.Revit.Attributes.Journaling(Autodesk.Revit.Attributes.JournalingMode.NoCommandData)]
    public class BrandschutzRevitApp : IExternalApplication
    {
        #region Attribute
        // class instance
        public static BrandschutzRevitApp thisApp = null;
        // ModelessForm instance
        public static Hauptfenster revitAppForm;
        #endregion

        #region IExternalApplication Members
        /// <summary>
        /// Implement this method to implement the external application which should be called when 
        /// Revit starts before a file or default template is actually loaded.
        /// Quelle: Revit 2017 SDK, Sample "Ribbon"
        /// </summary>
        /// <param name="application">An object that is passed to the external application 
        /// which contains the controlled application.</param>
        /// <returns>Return the status of the external application. 
        /// A result of Succeeded means that the external application successfully started. 
        /// Cancelled can be used to signify that the user cancelled the external operation at 
        /// some point.
        /// If Failed is returned then Revit should inform the user that the external application 
        /// failed to load and the release the internal reference.</returns>
        public Autodesk.Revit.UI.Result OnStartup(UIControlledApplication application)
        {
            try
            {
                revitAppForm = null;   // no dialog needed yet; the command will bring it
                thisApp = this;  // static access to this application instance
                //TODO: Ribbon erstellen

                return Autodesk.Revit.UI.Result.Succeeded;
            }
            catch (Exception ex)
            {
                TaskDialog.Show("Ribbon Sample", ex.ToString());

                return Autodesk.Revit.UI.Result.Failed;
            }
        }

        /// <summary>
        /// Implement this method to implement the external application which should be called when 
        /// Revit is about to exit, Any documents must have been closed before this method is called.
        /// Quelle: Revit 2017 SDK, Sample "Ribbon"
        /// </summary>
        /// <param name="application">An object that is passed to the external application 
        /// which contains the controlled application.</param>
        /// <returns>Return the status of the external application. 
        /// A result of Succeeded means that the external application successfully shutdown. 
        /// Cancelled can be used to signify that the user cancelled the external operation at 
        /// some point.
        /// If Failed is returned then the Revit user should be warned of the failure of the external 
        /// application to shut down correctly.</returns>
        public Autodesk.Revit.UI.Result OnShutdown(UIControlledApplication application)
        {
            //close forms
            if (revitAppForm != null && revitAppForm.Visible)
            {
                revitAppForm.Close();
            }

            return Autodesk.Revit.UI.Result.Succeeded;
        }
        #endregion

        #region Methoden
        /// <summary>
        /// Diese Methode ruft das Fenster der BranschutzApp auf.
        /// Quelle: https://knowledge.autodesk.com/search-result/caas/CloudHelp/cloudhelp/2016/ENU/Revit-API/files/GUID-0A0D656E-5C44-49E8-A891-6C29F88E35C0-htm.html
        /// </summary>
        /// <param name="uiapp">Die UIApplication, aus der die Methode aufgerufen wird.</param>
        public void ShowForm(UIApplication uiapp)
        {
            // If we do not have a dialog yet, create and show it
            if (revitAppForm == null || revitAppForm.IsDisposed)
            {
                // We give the objects to the new dialog;
                // The dialog becomes the owner responsible for disposing them, eventually.
                UIApplication mapp = uiapp;
                UIDocument mdoc = mapp.ActiveUIDocument;
                Util.Doc = mdoc.Document;

                //TODO: Den Nutzer einen Raum auswählen lassen und diesen in der BrandschutzApp darstellen/ändern lassen
                
            }
        }    
        #endregion
        
    }
}
