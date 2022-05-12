using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Security;


namespace AT.Ragioneria.FondiScuoleParitarie
{
    public partial class Import_Scuole : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private string GetPathFile()
        {
            string fileName = fileUpload.FileName;
            string strFileName;
            string strFilePath = "";
            string strFolder;
            strFolder = Server.MapPath("./");
            // Retrieve the name of the file that is posted.
            strFileName = fileName;
            strFileName = Path.GetFileName(strFileName);
            if (fileUpload.FileName != "")
            {
                // Create the folder if it does not exist.
                if (!Directory.Exists(strFolder))
                {
                    Directory.CreateDirectory(strFolder);
                }
                // Save the uploaded file to the server.
                strFilePath = strFolder + strFileName;
                if (File.Exists(strFilePath))
                {
                    File.Delete(strFilePath);
                    fileUpload.PostedFile.SaveAs(strFilePath);
                    //lblFileUpload.Text = strFileName + " has been successfully uploaded.";
                }
                else
                {
                    fileUpload.PostedFile.SaveAs(strFilePath);
                    //lblFileUpload.Text = strFileName + " has been successfully uploaded.";
                }
            }
            else
            {
               // lblFileUpload.Text = "Click 'Browse' to select the file to upload.";
            }
            // Display the result of the upload.
            //frmConfirmation.Visible = true;

            return strFilePath;
        }

        protected void lnkBnt_CaricaScuole_Click(object sender, EventArgs e)
        {
         
            DAL.XLS_DAL xslDal = new DAL.XLS_DAL(this.GetPathFile());


            List<List<object>> records =  xslDal.ParseSheet(1, 10, 35, 5,402);

            object ordineScuola  = records[0][0];
            object codiceMeccanoGraficoScuola = records[0][1];
            object denominazioneScuola = records[0][2];

            object Tipologia_EnteGestore = records[0][15];
            object Nome_Gestore = records[0][17];
            object CF_EnteGestore = records[0][22];
            object IBAN_EnteGestore = records[0][22];

            
            BLL.Scuola scuola = new BLL.Scuola(ordineScuola.ToString(), codiceMeccanoGraficoScuola.ToString(), denominazioneScuola.ToString());
            scuola.Insert();

        }
    }
}