using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AT.Ragioneria.FondiScuoleParitarie.BLL
{
    public class Ordine_Scuola : Anagrafica
    {

        private static string INFANZIA = "Scuola dell'infanzia";
        private static string PRIMARIA = "Scuola primaria";
        private static string I_GRADO = "Scuola Secondaria I grado";
        private static string II_GRADO = "Scuola Secondaria II grado";

        enum ORDINE_TIPO : ushort
        {
            INFANZIA = 1,
            PRIMARIA = 2,
            I_GRADO = 3,
            II_GRADO= 4
        }

        public Ordine_Scuola(string denominazione) : base(denominazione)
        {
            if (denominazione.Equals(INFANZIA))
            {
                base.ID = (long)ORDINE_TIPO.INFANZIA;
            }
            else if (denominazione.Equals(PRIMARIA))
            {
                base.ID = (long)ORDINE_TIPO.PRIMARIA;
            }
            else if (denominazione.Equals(I_GRADO))
            {
                base.ID = (long)ORDINE_TIPO.I_GRADO;
            }
            else if (denominazione.Equals(II_GRADO))
            {
                base.ID = (long)ORDINE_TIPO.II_GRADO;
            }
        }




        public Ordine_Scuola(long id, string denominazione) : base(id, denominazione)
        { }
        
    }
}