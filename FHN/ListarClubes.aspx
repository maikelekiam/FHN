<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarClubes.aspx.cs" Inherits="FHN.ListarClubes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <!--GRILLA PARA MOSTRAR LOS CLUBES DE LA BASE DE DATOS-->
    <h4>Grilla de CLUBES</h4>
    <div class="form-group">
        <div class="col-md-9 col-md-offset-1">
            <asp:GridView ID="dgvClub" runat="server" AutoGenerateColumns="false"
                CssClass="table table-hover table-striped" BorderWidth="2px"
                GridLines="Both" EmptyDataText="No existen clubes" ShowHeaderWhenEmpty="true"
                OnRowDeleting="dgvClub_RowDeleting">
                <Columns>
                    <asp:BoundField HeaderText="ID" DataField="idClub" ItemStyle-HorizontalAlign="Left" HeaderStyle-BackColor="#cccccc" />
                    <asp:BoundField HeaderText="Nombre" DataField="nombreInstitucional" ItemStyle-HorizontalAlign="Left" HeaderStyle-BackColor="#cccccc" />
                    <asp:BoundField HeaderText="Email" DataField="email" ItemStyle-HorizontalAlign="Left" HeaderStyle-BackColor="#cccccc"/>
                    <asp:ButtonField HeaderText="Detalles" CommandName="delete" HeaderStyle-BackColor="#cccccc" ControlStyle-Width="50" ItemStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle" ControlStyle-CssClass="glyphicon glyphicon-search" />
                </Columns>
            </asp:GridView>
        </div>
    </div>

</asp:Content>
