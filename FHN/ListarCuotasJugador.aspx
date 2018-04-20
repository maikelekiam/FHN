<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarCuotasJugador.aspx.cs" Inherits="FHN.ListarCuotasJugador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!--GRILLA PARA MOSTRAR LOS CLUBES DE LA BASE DE DATOS-->

    <h3>Cuotas de Jugador</h3>
    <div class="form-group">
        <div class="col-md-9 col-md-offset-1">
            <asp:GridView ID="dgvCuotaJugadores" runat="server" AutoGenerateColumns="false"
                CssClass="table table-hover table-striped" BorderWidth="2px"
                GridLines="Both" EmptyDataText="No existen cuotas de jugador registradas" ShowHeaderWhenEmpty="true"
                OnRowDeleting="dgvCuotaJugadores_RowDeleting">
                <Columns>
                    <asp:BoundField HeaderText="ID" DataField="idCuotaJugador" ItemStyle-HorizontalAlign="Left" HeaderStyle-BackColor="#cccccc" />
                    <asp:BoundField HeaderText="Año" DataField="Anio" ItemStyle-HorizontalAlign="Left" HeaderStyle-BackColor="#cccccc" />
                    <asp:BoundField HeaderText="Cuota" DataField="nombre" ItemStyle-HorizontalAlign="Left" HeaderStyle-BackColor="#cccccc" />
                    <asp:BoundField HeaderText="Vencimiento" DataField="fechaVencimiento"
                        DataFormatString="{0:dd-MMM-yyyy}" HeaderStyle-BackColor="#cccccc" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="120" HeaderStyle-Width="120" />
                    <asp:ButtonField HeaderText="Detalles" CommandName="delete" HeaderStyle-BackColor="#cccccc" ControlStyle-Width="50" ItemStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle" ControlStyle-CssClass="glyphicon glyphicon-search" />
                </Columns>
            </asp:GridView>
        </div>
    </div>

</asp:Content>
