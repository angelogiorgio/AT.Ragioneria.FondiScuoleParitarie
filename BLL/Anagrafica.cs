using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AT.Ragioneria.FondiScuoleParitarie.BLL
{
    [Serializable]
    public class Anagrafica
    {
        private long _ID = long.MinValue;
        private string _Denominazione = string.Empty;

        public long ID { get { return this._ID; } set { this._ID = value; } }

        public string Denominazione { get { return this._Denominazione; } }

        public Anagrafica(long id, string denominazione) : this(denominazione)
        {
            this._ID = id;
        }


        public Anagrafica(string denominazione)
        {

            this._Denominazione = denominazione;
        }

    }
}