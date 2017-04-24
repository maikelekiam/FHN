<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarJugadores.aspx.cs" Inherits="FHN.ListarJugadores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <!--GRILLA PARA MOSTRAR LOS JUGADORES DE LA BASE DE DATOS-->
    <h4>GRILLA DE JUGADORES</h4>
    <div class="form-group">
        <div class="col-md-9 col-md-offset-1">
            <asp:GridView ID="dgvJugador" runat="server" AutoGenerateColumns="false"
                CssClass="table table-hover table-bordered table-striped" BorderWidth="2px"
                GridLines="Both" EmptyDataText="No existen jugadores" ShowHeaderWhenEmpty="true"
                OnSelectedIndexChanging="dgvJugador_SelectedIndexChanging"
                OnRowDeleting="dgvJugador_RowDeleting">
                <Columns>
                    <asp:BoundField HeaderText="ID" DataField="idPersona" ItemStyle-HorizontalAlign="Center" HeaderStyle-BackColor="#cccccc" />
                    <asp:BoundField HeaderText="Nombre" DataField="nombre" ItemStyle-HorizontalAlign="Center" HeaderStyle-BackColor="#cccccc" />
                    <asp:BoundField HeaderText="Apellido" DataField="apellido" ItemStyle-HorizontalAlign="Center" HeaderStyle-BackColor="#cccccc" />
                    <asp:BoundField HeaderText="Tipo" DataField="tipoDocumento" ItemStyle-HorizontalAlign="Center" HeaderStyle-BackColor="#cccccc" />
                    <asp:BoundField HeaderText="Documento" DataField="documento" ItemStyle-HorizontalAlign="Center" HeaderStyle-BackColor="#cccccc" />
                    <asp:BoundField HeaderText="Fecha Nac" DataField="fechaNacimiento" DataFormatString="{0:d}" ItemStyle-HorizontalAlign="Center" HeaderStyle-BackColor="#cccccc" />
                    <asp:BoundField HeaderText="Club" DataField="club" ItemStyle-HorizontalAlign="Center" HeaderStyle-BackColor="#cccccc" />
                    <asp:ButtonField Text="Editar" CommandName="select" HeaderStyle-BackColor="#cccccc" />
                    <asp:ButtonField Text="Borrar" CommandName="delete" HeaderStyle-BackColor="#cccccc" />
                </Columns>
            </asp:GridView>
        </div>
    </div>


</asp:Content>
