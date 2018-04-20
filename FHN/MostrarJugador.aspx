<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MostrarJugador.aspx.cs" Inherits="FHN.MostrarJugador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <asp:Panel ID="Panel1" CssClass="panel panel-default" runat="server">
            <div class="panel-heading">
                <h3>Informacion del JUGADOR</h3>
            </div>
            <!-- NOMBRE -->
            <br />
            <div class="form-group">
                <asp:Label ID="lblNombre" runat="server" Text="NOMBRE" CssClass="col-md-3 AlineadoIzquierda"></asp:Label>
                <asp:Label ID="txtNombre" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label>
            </div>
            <!-- APELLIDO -->
            <div class="form-group">
                <asp:Label ID="lblApellido" runat="server" Text="APELLIDO" CssClass="col-md-3 AlineadoIzquierda"></asp:Label>
                <asp:Label ID="txtApellido" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label>
            </div>
            <!-- DOCUMENTO -->
            <div class="form-group">
                <asp:Label ID="lblDocumento" runat="server" Text="DOCUMENTO" CssClass="col-md-3 col-xs-6 AlineadoIzquierda"> </asp:Label>
                <asp:Label ID="txtDocumento" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label><br />
            </div>
            <!--FECHA NACIMIENTO-->
            <div class="form-group">
                <asp:Label ID="lblFechaNacimiento" runat="server" Text="FECHA DE NACIMIENTO" CssClass="col-md-3 AlineadoIzquierda"></asp:Label>
                <asp:Label ID="txtFechaNacimiento" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label><br />
            </div>
            <!-- TELEFONO -->
            <div class="form-group">
                <asp:Label ID="lblTelefono" runat="server" Text="TELEFONO" CssClass="col-md-3 AlineadoIzquierda"> </asp:Label>
                <asp:Label ID="txtTelefono" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label><br />
            </div>
            <!-- CELULAR -->
            <div class="form-group">
                <asp:Label ID="lblCelular" runat="server" Text="CELULAR" CssClass="col-md-3 AlineadoIzquierda"> </asp:Label>
                <asp:Label ID="txtCelular" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label><br />
            </div>
            <!-- CORREO ELECTRONICO -->
            <div class="form-group">
                <asp:Label ID="lblEmail" runat="server" Text="CORREO ELECTRONICO" CssClass="col-md-3 AlineadoIzquierda"> </asp:Label>
                <asp:Label ID="txtEmail" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label><br />
            </div>
            <!-- DOMICILIO -->
            <div class="form-group">
                <asp:Label ID="lblDomicilio" runat="server" Text="DOMICILIO" CssClass="col-md-3 AlineadoIzquierda"> </asp:Label>
                <asp:Label ID="txtDomicilio" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label><br />
            </div>
            <!-- NUMERO DE SOCIO -->
            <div class="form-group">
                <asp:Label ID="lblNumeroSocio" runat="server" Text="NUMERO DE SOCIO" CssClass="col-md-3 AlineadoIzquierda"> </asp:Label>
                <asp:Label ID="txtNumeroSocio" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label><br />
            </div>
            <!-- SECTOR -->
            <div class="form-group">
                <asp:Label ID="lblSector" runat="server" Text="SECTOR" CssClass="col-md-3 AlineadoIzquierda"> </asp:Label>
                <asp:Label ID="txtSector" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label><br />
            </div>
            <!-- CLUB -->
            <div class="form-group">
                <asp:Label ID="lblClub" runat="server" Text="CLUB" CssClass="col-md-3 AlineadoIzquierda"> </asp:Label>
                <asp:Label ID="txtClub" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label><br />
            </div>
            <!-- ACTIVO -->
            <div class="form-group">
                <asp:Label ID="lblActivo" runat="server" Text="ESTADO" CssClass="col-md-3 AlineadoIzquierda"> </asp:Label>
                <asp:Label ID="txtActivo" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label><br />
            </div>
        </asp:Panel>
        <asp:Panel ID="Panel2" CssClass="panel panel-default" runat="server">
            <div class="panel-heading">
                <h3>Contacto de Emergencia</h3>
            </div>
            <!--NOMBRE Y APELLIDO-->
            <div class="form-group">
                <br />
                <asp:Label ID="lblContactoNombre" runat="server" Text="NOMBRE y APELLIDO" CssClass="col-md-3 AlineadoIzquierda"></asp:Label>
                <asp:Label ID="txtContactoNombre" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label><br />
            </div>
            <!--PARENTEZCO-->
            <div class="form-group">
                <asp:Label ID="lblContactoParentezco" runat="server" Text="PARENTEZCO" CssClass="col-md-3 AlineadoIzquierda"></asp:Label>
                <asp:Label ID="txtContactoParentezco" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label><br />
            </div>
            <!--TELEFONO-->
            <div class="form-group">
                <asp:Label ID="lblContactoTelefono" runat="server" Text="TELEFONO" CssClass="col-md-3 AlineadoIzquierda"></asp:Label>
                <asp:Label ID="txtContactoTelefono" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label><br />
            </div>
        </asp:Panel>
    </div>
</asp:Content>
