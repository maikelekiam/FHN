<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarJugador.aspx.cs" Inherits="FHN.EditarJugador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">

        <asp:Panel ID="Panel1" CssClass="panel panel-default" runat="server">
            <div class="panel-heading">
                <h3>Datos del JUGADOR</h3>
            </div>

            <!--LISTA CON LOS JUGADORES DE LA BD-->
            <div class="form-group">
                <br />
                <div class="col-md-4 col-md-offset-2">
                    <asp:DropDownList ID="ddlJugador" runat="server"
                        Width="500"
                        CssClass="selectpicker form-control show-tick"
                        data-live-search="true"
                        BackColor="WhiteSmoke"
                        ForeColor="#000066"
                        Font-Bold="true"
                        DataTextField="nombre"
                        AutoPostBack="True"
                        AppendDataBoundItems="true"
                        OnSelectedIndexChanged="ddlJugador_SelectedIndexChanged">
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
            <!--NOMBRE-->
            <div class="form-group">
                <asp:Label ID="lblNombre" runat="server" Text="NOMBRE" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-6">
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <!--APELLIDO-->
            <div class="form-group">
                <asp:Label ID="lblApellido" runat="server" Text="APELLIDO" CssClass="col-md-2 control-label"> </asp:Label>
                <div class="col-md-6">
                    <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <!--TIPO DOCUMENTO-->
            <div class="form-group">
                <asp:Label ID="lblTipoDocumento" runat="server" Text="TIPO DOCUMENTO" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:DropDownList ID="ddlTipoDocumento" runat="server"
                        CssClass="selectpicker form-control show-tick"
                        data-width="fit">
                        <asp:ListItem Value="DNI">DNI</asp:ListItem>
                        <asp:ListItem Value="DU">DU</asp:ListItem>
                        <asp:ListItem Value="LE">LE</asp:ListItem>
                        <asp:ListItem Value="CI">CI</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <!--DNI-->
            <div class="form-group">
                <asp:Label ID="lblDocumento" runat="server" Text="DOCUMENTO" class="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtDocumento" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>
            <!--FECHA NACIMIENTO-->
            <div class="form-group">
                <asp:Label ID="lblFechaNacimiento" runat="server" Text="FECHA DE NACIMIENTO" CssClass="col-md-2 control-label"></asp:Label>
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

            <!--TELEFONO-->
            <div class="form-group">
                <asp:Label ID="lblTelefono" runat="server" Text="TELEFONO" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <!--CELULAR-->
            <div class="form-group">
                <asp:Label ID="lblCelular" runat="server" Text="CELULAR" CssClass="col-md-2 control-label"> </asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtCelular" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <!--EMAIL-->
            <div class="form-group">
                <asp:Label ID="lblEmail" runat="server" Text="EMAIL" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-8">
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <!--DOMICILIO-->
            <div class="form-group">
                <asp:Label ID="lblDomicilio" runat="server" Text="DOMICILIO" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtDomicilio" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <!--NUMERO DE SOCIO-->
            <div class="form-group">
                <asp:Label ID="lblNumeroSocio" runat="server" Text="N°SOCIO" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtNumeroSocio" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <!--SECTOR-->
            <div class="form-group">
                <asp:Label ID="lblSector" runat="server" Text="SECTOR" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:DropDownList ID="ddlSector" runat="server"
                        CssClass="selectpicker form-control show-tick"
                        data-width="280px">
                        <asp:ListItem Value="DAMAS">Damas</asp:ListItem>
                        <asp:ListItem Value="CABALLEROS">Caballeros</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <!-- CLUB -->
            <div class="form-group">
                <asp:Label ID="lblClub" runat="server" Text="CLUB" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-8">
                    <asp:DropDownList ID="ddlClub" runat="server"
                        BackColor="WhiteSmoke"
                        ForeColor="#000066"
                        CssClass="selectpicker form-control show-tick"
                        data-live-search="true"
                        AutoPostBack="False"
                        AppendDataBoundItems="true">
                        <asp:ListItem Value="-1">&lt;Seleccione Club&gt;</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <!-- ACTIVO-->
            <div class="form-group">
                <asp:Label ID="lblActivo" runat="server" Text="ACTIVO" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-1">
                    <asp:CheckBox ID="chkActivo" runat="server" />
                </div>
            </div>
        </asp:Panel>

        <asp:Panel ID="Panel2" CssClass="panel panel-default" runat="server">
            <div class="panel-heading">
                <h3>Contacto Emergencia</h3>
            </div>
            <!--NOMBRE Y APELLIDO-->
            <div class="form-group">
                <br />
                <asp:Label ID="lblContactoNombre" runat="server" Text="NOMBRE y APELLIDO" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-6">
                    <asp:TextBox ID="txtContactoNombre" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <!--PARENTEZCO-->
            <div class="form-group">
                <asp:Label ID="lblContactoParentezco" runat="server" Text="PARENTESCO" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-6">
                    <asp:TextBox ID="txtContactoParentezco" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <!--TELEFONO-->
            <div class="form-group">
                <asp:Label ID="lblContactoTelefono" runat="server" Text="TELEFONO" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtContactoTelefono" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </asp:Panel>


        <!--BOTON ACTUALIZAR-->
        <div class="form-group">
            <div class="col-md-2 col-md-offset-2">
                <asp:Button ID="btnActualizar" runat="server" Text="ACTUALIZAR" Width="250" CssClass="boton_azul" OnClick="btnActualizar_Click" />
            </div>
        </div>








    </div>

</asp:Content>
