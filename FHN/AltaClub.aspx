<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AltaClub.aspx.cs" Inherits="FHN.AltaClub" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <asp:Panel ID="Panel1" CssClass="panel panel-default" runat="server">
            <div class="panel-heading">
                <h3>Formulario de ALTA Club</h3>
            </div>
            <!--ID INTERNO-->
            <br />
            <div class="form-group">
                <asp:Label ID="lblIdInterno" runat="server" Text="ID INTERNO" CssClass="col-md-3 control-label"></asp:Label>
                <div class="col-md-2">
                    <asp:TextBox ID="txtIdInterno" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <!--NOMBRE INSTITUCIONAL-->
            <div class="form-group">
                <asp:Label ID="lblNombreInstitucional" runat="server" Text="NOMBRE INSTITUCIONAL" CssClass="col-md-3 control-label"></asp:Label>
                <div class="col-md-8">
                    <asp:TextBox ID="txtNombreInstitucional" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <!--PERSONERIA JURIDICA-->
            <div class="form-group">
                <asp:Label ID="lblPersoneriaJuridica" runat="server" Text="PERSONERIA JURIDICA" CssClass="col-md-3 control-label"> </asp:Label>
                <div class="col-md-8">
                    <asp:TextBox ID="txtPersoneriaJuridica" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <!--AÑO AFILIACION-->
            <div class="form-group">
                <asp:Label ID="lblAnioAfiliacion" runat="server" Text="AÑO AFILIACION" CssClass="col-md-3 control-label"> </asp:Label>
                <div class="col-md-2">
                    <asp:TextBox ID="txtAnioAfiliacion" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <!--NUMERO CUIL-->
            <div class="form-group">
                <asp:Label ID="lblNumeroCuil" runat="server" Text="NUMERO CUIL" CssClass="col-md-3 control-label"> </asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtNumeroCuil" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <!--DOMICILIO SEDE-->
            <div class="form-group">
                <asp:Label ID="lblDomicilioSede" runat="server" Text="DOMICILIO SEDE" CssClass="col-md-3 control-label"> </asp:Label>
                <div class="col-md-8">
                    <asp:TextBox ID="txtDomicilioSede" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <!--TELEFONO SEDE-->
            <div class="form-group">
                <asp:Label ID="lblTelefonoSede" runat="server" Text="TELEFONO SEDE" CssClass="col-md-3 control-label"> </asp:Label>
                <div class="col-md-8">
                    <asp:TextBox ID="txtTelefonoSede" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <!--EMAIL-->
            <div class="form-group">
                <asp:Label ID="lblEmail" runat="server" Text="EMAIL" CssClass="col-md-3 control-label"> </asp:Label>
                <div class="col-md-8">
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <!--EMAIL ALTERNATIVO-->
            <div class="form-group">
                <asp:Label ID="lblEmailAlternativo" runat="server" Text="EMAIL ALTERNATIVO" CssClass="col-md-3 control-label"> </asp:Label>
                <div class="col-md-8">
                    <asp:TextBox ID="txtEmailAlternativo" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <!--COLORES OFICIALES-->
            <div class="form-group">
                <asp:Label ID="lblColoresOficiales" runat="server" Text="COLORES OFICIALES" CssClass="col-md-3 control-label"> </asp:Label>
                <div class="col-md-8">
                    <asp:TextBox ID="txtColoresOficiales" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <!--COLORES ALTERNATIVOS-->
            <div class="form-group">
                <asp:Label ID="lblColoresAlternativos" runat="server" Text="COLORES ALTERNATIVOS" CssClass="col-md-3 control-label"> </asp:Label>
                <div class="col-md-8">
                    <asp:TextBox ID="txtColoresAlternativos" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <!--DOMICILIO CAMPO DE JUEGO-->
            <div class="form-group">
                <asp:Label ID="lblDomicilioCampoJuego" runat="server" Text="DOMICILIO CAMPO DE JUEGO" CssClass="col-md-3 control-label"> </asp:Label>
                <div class="col-md-8">
                    <asp:TextBox ID="txtDomicilioCampoJuego" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <!--TELEFONO CAMPO DE JUEGO-->
            <div class="form-group">
                <asp:Label ID="lblTelefonoCampoJuego" runat="server" Text="TELEFONO CAMPO DE JUEGO" CssClass="col-md-3 control-label"> </asp:Label>
                <div class="col-md-8">
                    <asp:TextBox ID="txtTelefonoCampoJuego" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <!--EMAIL CAMPO DE JUEGO-->
            <div class="form-group">
                <asp:Label ID="lblEmailCampoJuego" runat="server" Text="EMAIL CAMPO DE JUEGO" CssClass="col-md-3 control-label"> </asp:Label>
                <div class="col-md-8">
                    <asp:TextBox ID="txtEmailCampoJuego" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <!--BOTON GUARDAR CLUB-->
            <div class="form-group">
                <div class="col-md-2 col-md-offset-2">
                    <br />
                    <asp:Button ID="btnGuardarClub" runat="server" Text="Guardar Club" CssClass="btn btn-success form-control" OnClick="btnGuardarClub_Click" />
                </div>
            </div>
        </asp:Panel>
    </div>



</asp:Content>
