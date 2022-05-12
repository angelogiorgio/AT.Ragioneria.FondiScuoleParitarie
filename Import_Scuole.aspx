<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Import_Scuole.aspx.cs" Inherits="AT.Ragioneria.FondiScuoleParitarie.Import_Scuole" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="jumbotron" style="background-color:lavender; border: inherit">
        <h1>Import</h1>
        <hr style='width: 100%' />
        <p class="btn btn-default">Caricamento File Allievi Istituto</p>
    </div>
    <div class="jumbotron" style="width: 100%; background-color: azure">
       <table style="width: 100%; border-spacing: 10px;">
            <tr>
                <td>
                    File
                </td>
                <td>
                      <asp:FileUpload ID="fileUpload" runat="server" Width="100%" />
                </td>
               
            </tr>
            <tr>
                <td>
                    Carica 
                </td>
                <td>
                       <asp:LinkButton ID="lnkBnt_CaricaScuole" runat="server" 
        OnClick="lnkBnt_CaricaScuole_Click">Carica Dati Scuole</asp:LinkButton>
                </td>
               
            </tr>
        </table>
       </div>
    
   
</asp:Content>
