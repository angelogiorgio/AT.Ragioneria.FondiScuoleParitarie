using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AT.Ragioneria.FondiScuoleParitarie.BLL
{
    public class EnteGestore: DAL.SQL_DAL
    {
        
        private Ordine_Scuola _ordine = null;
        private string _codiceMeccanografico = string.Empty;
        private string _denominazione = string.Empty;

        public EnteGestore(string ordine, string codice, string denominazione)
        {
            this._ordine = new Ordine_Scuola(ordine);
            this._codiceMeccanografico = codice;
            this._denominazione = denominazione;
        }

        public void Insert()
        {
            List<DAL.SQL_DAL.SP_Parameter> list = new List<DAL.SQL_DAL.SP_Parameter>();
            list.Add(new DAL.SQL_DAL.SP_Parameter("@codiceMeccanografico", this._codiceMeccanografico));
            list.Add(new DAL.SQL_DAL.SP_Parameter("@denominazione", this._denominazione));
            list.Add(new DAL.SQL_DAL.SP_Parameter("@fkordine", this._ordine.ID));


            base.Execute_SP("usp_Insert_Scuola", list);
        }
    }
}