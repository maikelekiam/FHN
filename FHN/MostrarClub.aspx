<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MostrarClub.aspx.cs" Inherits="FHN.MostrarClub" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <asp:Panel ID="Panel1" CssClass="panel panel-default" runat="server">
            <div class="panel-heading">
                <h3>Informacion del CLUB</h3>
            </div>
            <!-- NOMBRE INSTITUCIONAL -->
            <br />
            <div class="form-group">
                <asp:Label ID="lblNombreInstitucional" runat="server" Text="NOMBRE INSTITUCIONAL" CssClass="col-md-3 AlineadoIzquierda"></asp:Label>
                <asp:Label ID="txtNombreInstitucional" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label>
            </div>
            <!-- NOMBRE CORTO -->
            <div class="form-group">
                <asp:Label ID="lblNombreCorto" runat="server" Text="NOMBRE CORTO" CssClass="col-md-3 AlineadoIzquierda"></asp:Label>
                <asp:Label ID="txtNombreCorto" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label>
            </div>
            <!-- ID INTERNO -->
            <div class="form-group">
                <asp:Label ID="lblIdInterno" runat="server" Text="ID INTERNO" CssClass="col-md-3 AlineadoIzquierda"></asp:Label>
                <asp:Label ID="txtIdInterno" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label>
            </div>
            <!-- PERSONERIA JURIDICA -->
            <div class="form-group">
                <asp:Label ID="lblPersoneriaJuridica" runat="server" Text="PERSONERIA JURIDICA" CssClass="col-md-3 col-xs-6 AlineadoIzquierda"> </asp:Label>
                <asp:Label ID="txtPersoneriaJuridica" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label><br />
            </div>
            <!--AÑO AFILIACION-->
            <div class="form-group">
                <asp:Label ID="lblAnioAfiliacion" runat="server" Text="AÑO AFILIACION" CssClass="col-md-3 AlineadoIzquierda"></asp:Label>
                <asp:Label ID="txtAnioAfiliacion" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label><br />
            </div>
            <!-- NUMERO DE CUIL -->
            <div class="form-group">
                <asp:Label ID="lblNumeroCuil" runat="server" Text="NUMERO DE CUIL" CssClass="col-md-3 AlineadoIzquierda"> </asp:Label>
                <asp:Label ID="txtNumeroCuil" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label><br />
            </div>
        </asp:Panel>
        <asp:Panel ID="Panel3" CssClass="panel panel-default" runat="server">
            <div class="panel-heading">
                <h3>Sede</h3>
            </div>
            <br />
            <div class="form-group">
                <asp:Label ID="lblDomicilioSede" runat="server" Text="DOMICILIO" CssClass="col-md-3 AlineadoIzquierda"> </asp:Label>
                <asp:Label ID="txtDomicilioSede" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label><br />
            </div>
            <div class="form-group">
                <asp:Label ID="lblTelefonoSede" runat="server" Text="TELEFONO" CssClass="col-md-3 AlineadoIzquierda"> </asp:Label>
                <asp:Label ID="txtTelefonoSede" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label><br />
            </div>
            <div class="form-group">
                <asp:Label ID="lblEmail" runat="server" Text="EMAIL" CssClass="col-md-3 AlineadoIzquierda"> </asp:Label>
                <asp:Label ID="txtEmail" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label><br />
            </div>
            <div class="form-group">
                <asp:Label ID="lblEmailAlternativo" runat="server" Text="EMAIL ALTERNATIVO" CssClass="col-md-3 AlineadoIzquierda"> </asp:Label>
                <asp:Label ID="txtEmailAlternativo" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label><br />
            </div>
        </asp:Panel>
        <asp:Panel ID="Panel2" CssClass="panel panel-default" runat="server">
            <div class="panel-heading">
                <h3>Campo de Juego</h3>
            </div>
            <div class="form-group">
                <br />
                <asp:Label ID="lblColoresOficiales" runat="server" Text="COLORES OFICIALES" CssClass="col-md-3 AlineadoIzquierda"></asp:Label>
                <asp:Label ID="txtColoresOficiales" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label><br />
            </div>
            <div class="form-group">
                <asp:Label ID="lblColoresAlternativos" runat="server" Text="COLORES ALTERNATIVOS" CssClass="col-md-3 AlineadoIzquierda"></asp:Label>
                <asp:Label ID="txtColoresAlternativos" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label><br />
            </div>
            <div class="form-group">
                <asp:Label ID="lblDomicilioCampoJuego" runat="server" Text="DOMICILIO" CssClass="col-md-3 AlineadoIzquierda"></asp:Label>
                <asp:Label ID="txtDomicilioCampoJuego" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label><br />
            </div>
            <div class="form-group">
                <asp:Label ID="lblTelefonoCampoJuego" runat="server" Text="TELEFONO" CssClass="col-md-3 AlineadoIzquierda"></asp:Label>
                <asp:Label ID="txtTelefonoCampoJuego" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label><br />
            </div>
            <div class="form-group">
                <asp:Label ID="lblEmailCampoJuego" runat="server" Text="EMAIL" CssClass="col-md-3 AlineadoIzquierda"></asp:Label>
                <asp:Label ID="txtEmailCampoJuego" runat="server" CssClass="col-md-6 AlineadoIzquierda" Font-Bold="true"></asp:Label><br />
            </div>
        </asp:Panel>
    </div>
</asp:Content>
