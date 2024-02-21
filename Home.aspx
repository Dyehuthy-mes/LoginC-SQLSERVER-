<%@ Page Title="Datos del Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ProyectoPrueba.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container text-center ">
        <h2><%: Title %></h2>
    </div>

    <div class="container py-5">
        <div class="row">
            <div class="col-lg-7 mx-auto">
                <div class="card rounded-0 border-0 shadow">
                    <div class="card-body p-5">
                        <div class="table-responsive">
                            <table class="table">
                                <thead>
                                    <tr>
                                        <th scope="col">Nombre Usuario</th>
                                        <th scope="col">Mail</th>
                                        <th scope="col">Telefono</th>
                                        <th scope="col">Dirección</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td scope="row">
                                            <asp:Label ID="NombreUsuario" runat="server"></asp:Label></td>
                                        <td>
                                            <asp:Label ID="Mail" runat="server"></asp:Label></td>
                                        <td>
                                            <asp:Label ID="Telefono" runat="server"></asp:Label></td>
                                        <td>
                                            <asp:Label ID="Direccion" runat="server"></asp:Label></td>
                                    </tr>
                                </tbody>
                            </table>                        
                        </div>
                    </div>
                </div>
            </div>
        </div>
      <div class="col">
        <asp:Button runat="server" ID="botonCerrar" class="btn btn-light btn-block mb-2 center-block" Text="Cerrar Sesión" OnClick="botonCerrar_Click" />
      </div>
    </div>


</asp:Content>
