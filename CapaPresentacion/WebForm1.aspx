<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CapaPresentacion.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Mantenimiento de la tabla escuela</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
          <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarTogglerDemo03" aria-controls="navbarTogglerDemo03" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
          </button>
          <a class="navbar-brand" href="#">App Universidad</a>

          <div class="collapse navbar-collapse" id="navbarTogglerDemo03">
            <ul class="navbar-nav mr-auto mt-2 mt-lg-0">
              <li class="nav-item active">
                <asp:Button type="button" class="btn btn-outline-light" Text="Menu" runat="server" Id="btnIrMenu" OnClick="btnIrMenu_Click"/>
              </li>
            </ul>
          </div>
        </nav>
        <div class="container-fluid">
        <!-- Stack the columns on mobile by making one full-width and the other half-width -->
            <div class="jumbotron">
            <h1 class="display-4">Bienvenido al formulario de Escuela!</h1>
            <p class="lead">Liste, Genere, Modifique, Elimine y Busque</p>
        </div>
            <div class="row">
                <div class="col-4">
                    <form>
                        <div class="form-group">
                            <asp:TextBox CssClass="input-group" placeholder="Código de Escuela"  runat="server" Id="txtCodEscuela" />
                            <asp:RequiredFieldValidator ID="rfvCodEscuela" runat="server" ControlToValidate="txtCodEscuela" ErrorMessage="Codigo Escuela Obligatorio" ValidationGroup="A">*</asp:RequiredFieldValidator>
                            <asp:RequiredFieldValidator ID="rfvCodEscuela2" runat="server" ControlToValidate="txtCodEscuela" ErrorMessage="Campo Obligatorio" ValidationGroup="B">(*)</asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <asp:TextBox CssClass="input-group" placeholder="Nombre de Escuela" runat="server" Id="txtEscuela" />
                            <asp:RequiredFieldValidator ID="rfvEscuela" runat="server" ControlToValidate="txtEscuela" ErrorMessage="Escuela Obligatorio" ValidationGroup="A">*</asp:RequiredFieldValidator>
                        </div>
                        <div class="form-row">
                        <div class="form-group col-md-6">
                            <asp:TextBox CssClass="input-group" placeholder="Buscar" runat="server" Id="txtBuscar" />
                        </div>
                        <div class="form-group col-md-4">
                            <asp:DropDownList CssClass="custom-select" runat="server" Id="ddlCriterio">
                                <asp:ListItem Text="Codigo" />
                                <asp:ListItem Text="Escuela" />
                            </asp:DropDownList>
                        </div>
                        <div class="form-group col-md-2">
                            <asp:Button type="button" class="btn btn-outline-primary" Text="Buscar" runat="server" Id="btnBuscar" OnClick="btnBuscar_Click" />
                        </div>
                        </div>
                        <div class="list-group-horizontal-xl text-center align-items-center">
                           
                                <asp:Button type="button" CssClass="btn btn-outline-primary" Text="Listar" runat="server" Id="Button4" OnClick="btnListar_Click"/>
                                <asp:Button type="button" CssClass="btn btn-outline-primary" Text="Agregar" runat="server" Id="Button1" OnClick="btnAgregar_Click" ValidationGroup="A" />
                                <asp:Button type="button" CssClass="btn btn-outline-warning" Text="Actualizar" runat="server" Id="Button3" OnClick="btnActualizar_Click" ValidationGroup="A" />
                                <asp:Button type="button" CssClass="btn btn-outline-danger" Text="Eliminar" runat="server" Id="Button2" OnClick="btnEliminar_Click" ValidationGroup="B" />
                        </div>
                    </form>
                </div>
                <div class="col-8">
                    <p>
                        <asp:GridView class="table table-dark" runat="server" ID="gvEscuela">
                        </asp:GridView>
                    </p>
                </div>
            </div>
          
            
  
            
        </div>
        <asp:ValidationSummary ID="vsAgregar" runat="server" ShowMessageBox="True" ValidationGroup="A" />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ValidationGroup="B" />
    </form>
<script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js" integrity="sha384-B4gt1jrGC7Jh4AgTPSdUtOBvfO8shuf57BaghqFfPlYxofvL8/KUEfYiJOMMV+rV" crossorigin="anonymous"></script>
</body>
</html>
