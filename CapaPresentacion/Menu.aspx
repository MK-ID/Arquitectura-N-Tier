<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="CapaPresentacion.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-6 offset-md-3" class="text-justify">
                    <div class="jumbotron jumbotron-fluid">
                      <div class="container">
                        <h1 class="display-4 text-center font-weight-bold">YARA SYSTEMS</h1>
                        <p class="lead">El presente proyecto es la actividad asignada por el docente Ing.Hugo Espetia Huamanga del curso Desarrollo de Plataformas de Software </p>
                      </div>
                    </div>
                    <div class="list-group">
                      <a href="#" class="list-group-item list-group-item-action">
                          <asp:Button type="button" class="btn btn-outline-dark btn-block" Text="Alumno" runat="server" Id="btnIrAlumno" OnClick="btnIrAlumno_Click"/>
                      </a>
                      <a href="#" class="list-group-item list-group-item-action">
                          <asp:Button type="button" class="btn btn-outline-dark btn-block" Text="Carga Académica" runat="server" Id="btnIrCargaAcademica" OnClick="btnIrCargaAcademica_Click1"/>
                      </a>
                      <a href="#" class="list-group-item list-group-item-action">
                          <asp:Button type="button" class="btn btn-outline-dark btn-block" Text="Curso" runat="server" Id="btnIrCurso" OnClick="btnIrCurso_Click"/>
                      </a>
                      <a href="#" class="list-group-item list-group-item-action">
                          <asp:Button type="button" class="btn btn-outline-dark btn-block" Text="Docente" runat="server" Id="btnIrDocente" OnClick="btnIrDocente_Click"/>
                      </a>
                      <a href="#" class="list-group-item list-group-item-action">
                          <asp:Button type="button" class="btn btn-outline-dark btn-block" Text="Escuela" runat="server" Id="btnIrEscuela" OnClick="btnIrEscuela_Click"/>
                      </a>
                      <a href="#" class="list-group-item list-group-item-action">
                          <asp:Button type="button" class="btn btn-outline-dark btn-block" Text="Notas" runat="server" Id="btnIrNotas" OnClick="btnIrNotas_Click"/>
                      </a>
                      <a href="#" class="list-group-item list-group-item-action">
                          <asp:Button type="button" class="btn btn-outline-dark btn-block" Text="Usuario" runat="server" Id="btnIrUsuario" OnClick="btnIrUsuario_Click"/>
                      </a>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js" integrity="sha384-B4gt1jrGC7Jh4AgTPSdUtOBvfO8shuf57BaghqFfPlYxofvL8/KUEfYiJOMMV+rV" crossorigin="anonymous"></script>
</body>
</html>
