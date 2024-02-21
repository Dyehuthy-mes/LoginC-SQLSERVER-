<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectoPrueba._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <section class="p-3 mb-2 bg-light text-dark">
        <div class="container px-4 py-5 px-md-5 text-center text-lg-start my-5">
            <div class="row gx-lg-5 align-items-center mb-5">
                <div class="col-lg-6 mb-5 mb-lg-0" style="z-index: 10">
                    <h1 class="my-5 display-5 fw-bold ls-tight" style="color: hsl(218, 81%, 70%)">Login
                        <br />
                        <span style="color: hsl(218, 81%, 50%)">Proyecto Prueba </span>
                    </h1>
                </div>
                <div class="col-lg-5 mb-5 mb-lg-0 position-relative">
                    <div id="radius-shape-1" class="position-absolute rounded-circle shadow-5-strong"></div>
                    <div id="radius-shape-2" class="position-absolute shadow-5-strong"></div>
                    <div class="card bg-glass">
                        <div class="card-body px-4 py-5 px-md-5">
                            <div class="col-md-6 mb-4">
                                <div class="form-outline">
                                    <div>
                                        <asp:TextBox runat="server" ID="txtusuario" placeholder="Usuario" class="form-control" /></div>
                                    <div>
                                        <asp:TextBox runat="server" ID="txtcontraseña" Type="password" placeholder="Contraseña" class="form-control" /></div>
                                    <asp:Button runat="server" ID="botonIniciar" class="btn btn-light btn-block mb-2" Text="Iniciar Sesión" OnClick="botonIniciar_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

</asp:Content>
