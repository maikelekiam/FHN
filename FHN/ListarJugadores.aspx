<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarJugadores.aspx.cs" Inherits="FHN.ListarJugadores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <!--GRILLA PARA MOSTRAR LOS JUGADORES DE LA BASE DE DATOS-->
    <h3>LIBRO DE ASOCIADOS</h3>
    <div class="form-group">
        <div class="col-md-9 col-md-offset-1">
            <asp:GridView ID="dgvJugador" runat="server" AutoGenerateColumns="false"
                CssClass="table table-hover table-striped" BorderWidth="2px"
                GridLines="Both" EmptyDataText="No existen jugadores" ShowHeaderWhenEmpty="true"
                OnRowDeleting="dgvJugador_RowDeleting">
                <Columns>
                    <asp:BoundField HeaderText="ID" DataField="idJugador" ItemStyle-HorizontalAlign="Left" HeaderStyle-BackColor="#cccccc" />
                    <asp:BoundField HeaderText="N°Socio" DataField="numeroSocio" ItemStyle-HorizontalAlign="Left" HeaderStyle-BackColor="#cccccc" />
                    <asp:BoundField HeaderText="Nombre" DataField="nombre" ItemStyle-HorizontalAlign="Left" HeaderStyle-BackColor="#cccccc" />
                    <asp:BoundField HeaderText="Apellido" DataField="apellido" ItemStyle-HorizontalAlign="Left" HeaderStyle-BackColor="#cccccc" />
                    <asp:BoundField HeaderText="Tipo" DataField="tipo" ItemStyle-HorizontalAlign="Center" HeaderStyle-BackColor="#cccccc" />
                    <asp:BoundField HeaderText="Documento" DataField="documento" ItemStyle-HorizontalAlign="Center" HeaderStyle-BackColor="#cccccc" />
                    <asp:ButtonField HeaderText="Detalles" CommandName="delete" HeaderStyle-BackColor="#cccccc" ControlStyle-Width="50" ItemStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle" ControlStyle-CssClass="glyphicon glyphicon-search" />
                </Columns>
            </asp:GridView>
        </div>
    </div>


</asp:Content>
