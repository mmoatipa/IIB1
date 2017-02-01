using System;

namespace BrandschutzDaten
{
    public abstract class RevitElement
    {
        private String revitId;
        private String name;

        public string RevitId
        {
            get
            {
                return revitId;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public RevitElement()
        {
            revitId = "not set";
            name = "not set";
        }

        public RevitElement(String _revitId)
        {
            revitId = _revitId;
            name = "not set";
        }


        public RevitElement(String _revitId, String _name)
        {
            revitId = _revitId;
            name = _name;
        }
    }
}