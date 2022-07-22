<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EliminaSpese.aspx.cs" Inherits="EliminaSpesePopUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="mod" runat="server">
                <p>Sicuro di voler eliminare la Spesa?</p>
                <asp:Button ID="btnElimina" runat="server" Text="Elimina" OnClick="btnElimina_Click" />
            </div>
        </div>
    </form>
</body>
</html>
