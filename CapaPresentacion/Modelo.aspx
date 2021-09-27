<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Modelo.aspx.cs" Inherits="CapaPresentacion.Modelo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                <asp:Button Text="Opcion1" runat="server" ID="btnOpcion1" OnClick="btnOpcion1_Click" />
                <asp:Button Text="Opcion2" runat="server" ID="btnOpcion2" OnClick="btnOpcion2_Click" />
                <asp:Button Text="Opcion3" runat="server" ID="btnOpcion3" OnClick="btnOpcion3_Click" />
                <asp:Button Text="Opcion4" runat="server" ID="btnOpcion4" OnClick="btnOpcion4_Click" />
            </p>
            <!-- CONTROLES QUE PERMITEN -->
            <asp:MultiView ID="mvEjemplo" runat="server">
                <asp:View ID="vOpcion1" runat="server">
                    <h1>Este contenido pertenece a la opcion 1</h1>
                    <asp:Button ID="Text" runat="server" />
                </asp:View>
                <asp:View ID="vOpcion2" runat="server">
                    <h1>Este contenido pertenece a la opcion 2</h1>
                    <asp:Button ID="Button1" runat="server" />
                </asp:View>
                <asp:View ID="vOpcion3" runat="server">
                    <h1>Este contenido pertenece a la opcion 3</h1>
                    <asp:Button ID="Button2" runat="server" />
                </asp:View>
                <asp:View ID="vOpcion4" runat="server">
                    <h1>Este contenido pertenece a la opcion 4</h1>
                    <asp:Button ID="Button3" runat="server" />
                </asp:View>
            </asp:MultiView>
        </div>
    </form>
</body>
</html>
