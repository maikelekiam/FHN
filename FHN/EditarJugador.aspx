<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarJugador.aspx.cs" Inherits="FHN.EditarJugador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container-fluid">
        <asp:Panel ID="Panel1" runat="server">
            <div class="panel-heading">
                <h3>Formulario de Edicion de Jugador</h3>
            </div>

            <!--LISTA CON LOS JUGADORES DE LA BD-->
            <div class="form-group">
                <div class="col-md-4 col-md-offset-2">
                    <asp:DropDownList ID="ddlActualizarJugador" runat="server"
                        Width="280"
                        BackColor="WhiteSmoke"
                        ForeColor="#000066"
                        Font-Bold="true"
                        CssClass="form-control"
                        DataTextField="nombre"
                        AutoPostBack="True"
                        AppendDataBoundItems="true"
                        OnSelectedIndexChanged="ddlActualizarJugador_SelectedIndexChanged">
                        <asp:ListItem Value="-1">&lt;Seleccione un Jugador&gt;</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div style="margin-left: auto; margin-right: auto; text-align: right;">

                    <div class="col-md-1 col-md-offset-1">
                        <asp:Label ID="lblIdJ" runat="server" Text="ID = " CssClass="control-label"> </asp:Label>
                    </div>
                </div>
                <div style="margin-left: auto; margin-right: auto; text-align: left;">
                    <div class="col-md-2">
                        <asp:Label ID="lblIdJugador" runat="server" Text="" Font-Bold="true" CssClass="control-label"> </asp:Label>
                    </div>
                </div>
            </div>










        </asp:Panel>
    </div>

</asp:Content>
