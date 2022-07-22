<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificaTipoContratto.aspx.cs" Inherits="root_popup_modifica_ModificaTipoContratto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtTipoContratto" runat="server"></asp:TextBox>
            <asp:Button ID="btnModifica" runat="server" Text="Modifica" OnClick="btnModifica_Click" />
        </div>
    </form>
</body>
</html>
