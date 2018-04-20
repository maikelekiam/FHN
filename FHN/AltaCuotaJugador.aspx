<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AltaCuotaJugador.aspx.cs" Inherits="FHN.AltaCuotaJugador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <asp:Panel ID="Panel1" CssClass="panel panel-default" runat="server">
            <div class="panel-heading">
                <h3>Cuota de JUGADOR</h3>
            </div>
            <!--NOMBRE-->
            <br />
            <div class="form-group">
                <asp:Label ID="lblNombre" runat="server" Text="NOMBRE" CssClass="col-md-2 AlineadoDerecha"></asp:Label>
                <div class="col-md-6">
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <!--AÑO-->
            <div class="form-group">
                <asp:Label ID="lblAnio" runat="server" Text="AÑO" CssClass="col-md-2 AlineadoDerecha"> </asp:Label>
                <div class="col-md-6">
                    <asp:TextBox ID="txtAnio" runat="server" CssClass="form-control" onkeypress="return validarSoloNumeros(event);" MaxLength="4"></asp:TextBox>
                </div>
            </div>
            <!--FECHA VENCIMIENTO-->
            <div class="form-group">
                <asp:Label ID="lblFechaVencimiento" runat="server" Text="FECHA VENCIMIENTO" CssClass="col-md-2 AlineadoDerecha"></asp:Label>
                <div class="col-md-6">
                    <asp:DropDownList ID="ddlDia" runat="server"
                        CssClass="selectpicker form-control show-tick"
                        data-live-search="true"
                        data-width="90">
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlMes" runat="server"
                        CssClass="selectpicker form-control show-tick"
                        data-live-search="true"
                        data-width="150">
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlAnio" runat="server"
                        CssClass="selectpicker form-control show-tick"
                        data-live-search="true"
                        data-width="110">
                    </asp:DropDownList>
                </div>
            </div>
            <!--MONTO-->
            <div class="form-group">
                <asp:Label ID="lblMonto" runat="server" Text="MONTO" CssClass="col-md-2 AlineadoDerecha"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtMonto" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <!--DETALLE-->
            <div class="form-group">
                <asp:Label ID="lblDetalles" runat="server" Text="DETALLE" CssClass="col-md-2 AlineadoDerecha"></asp:Label>
                <div class="col-md-6">
                    <asp:TextBox ID="txtDetalles" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <!--OBSERVACIONES-->
            <div class="form-group">
                <asp:Label ID="lblObservaciones" runat="server" Text="OBSERVACIONES" CssClass="col-md-2 AlineadoDerecha"></asp:Label>
                <div class="col-md-6">
                    <asp:TextBox ID="txtObservaciones" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </asp:Panel>
        <!--BOTON GUARDAR-->
        <div class="form-group">
            <div class="col-md-2 col-md-offset-2">
                <br />
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="boton_verde" OnClick="btnGuardar_Click" />
            </div>
        </div>
    </div>

</asp:Content>
