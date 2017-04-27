﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarJugador.aspx.cs" Inherits="FHN.EditarJugador" %>

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



            <!--NOMBRE + APELLIDO-->
            <div class="form-group">
                <asp:Label ID="lblNombre" runat="server" Text="NOMBRE" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <asp:Label ID="lblApellido" runat="server" Text="APELLIDO" CssClass="col-md-2 control-label"> </asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <!--TIPO DOCUMENTO + DNI-->
            <div class="form-group">
                <asp:Label ID="lblTipoDocumento" runat="server" Text="TIPO DOCUMENTO" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:DropDownList ID="ddlTipoDocumento" runat="server"
                        CssClass="selectpicker form-control show-tick"
                        data-live-search="true"
                        data-width="fit">
                        <asp:ListItem Value="DNI">DNI</asp:ListItem>
                        <asp:ListItem Value="DU">DU</asp:ListItem>
                        <asp:ListItem Value="LE">LE</asp:ListItem>
                        <asp:ListItem Value="CI">CI</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <asp:Label ID="lblDocumento" runat="server" Text="DOCUMENTO" class="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtDocumento" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>

            <!--FECHA NACIMIENTO-->
            <div class="form-group">
                <asp:Label ID="lblFechaNacimiento" runat="server" Text="FECHA DE NACIMIENTO" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-3">
                    <div class="input-group date"
                        data-provide="datepicker"
                        data-date-format="dd/mm/yyyy"
                        data-date-autoclose="true"
                        data-date-today-btn="true"
                        data-date-clear-btn="true"
                        data-date-today-highlight="true">
                        <asp:TextBox CssClass="form-control" runat="server" ID="txtFechaNacimiento"></asp:TextBox>
                        <div class="input-group-addon">
                            <span class="glyphicon glyphicon-th"></span>
                        </div>
                    </div>
                </div>
            </div>

            <!--TELEFONO + CELULAR-->
            <div class="form-group">
                <asp:Label ID="lblTelefono" runat="server" Text="TELEFONO" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <asp:Label ID="lblCelular" runat="server" Text="CELULAR" CssClass="col-md-2 control-label"> </asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtCelular" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <!--FICHA + SECTOR-->
            <div class="form-group">
                <asp:Label ID="lblFicha" runat="server" Text="FICHA" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtFicha" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <asp:Label ID="lblSector" runat="server" Text="SECTOR" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:DropDownList ID="ddlSector" runat="server"
                        CssClass="selectpicker form-control show-tick"
                        data-live-search="true"
                        data-width="280px">
                        <asp:ListItem Value="DAMAS">Damas</asp:ListItem>
                        <asp:ListItem Value="CABALLEROS">Caballeros</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

            <!-- ACTIVO-->
            <div class="form-group">
                <asp:Label ID="lblIsActivo" runat="server" Text="ACTIVO" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-1">
                    <asp:CheckBox ID="chkIsActivo" runat="server" />
                </div>
            </div>

            <!-- CLUB + EMAIL-->
            <div class="form-group">
                <asp:Label ID="lblClub" runat="server" Text="CLUB" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtClub" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <asp:Label ID="lblEmail" runat="server" Text="EMAIL" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <!--BOTON-->
            <div class="form-group">
                <div class="col-md-2 col-md-offset-2">
                    <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" CssClass="btn btn-info form-control" OnClick="btnActualizar_Click" />
                </div>
            </div>








        </asp:Panel>
    </div>

</asp:Content>
