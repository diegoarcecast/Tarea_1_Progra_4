﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PL._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <asp:TextBox ID="TextBox1" runat="server" Width="400px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" Width="100px" />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="Error de Sintaxis" OnDataBinding="TextBox1_TextChanged" ValidationExpression="^[-+]?[0-9]+([-+*/]+[-+]?[0-9]+)*$"></asp:RegularExpressionValidator>
        <br />
        <asp:Button ID="btn1" runat="server" Text="1" Width="100px" />
        <asp:Button ID="btn2" runat="server" Text="2" Width="100px" />
        <asp:Button ID="btn3" runat="server" Text="3" Width="100px" />
        <asp:Button ID="btndiv" runat="server" Text="/" Width="100px" />
        <asp:Button ID="btnData" runat="server" Text="DATA" Width="100px" />

        <br />
        <asp:Button ID="btn4" runat="server" Text="4" Width="100px" />
        <asp:Button ID="btn5" runat="server" Text="5" Width="100px" />
        <asp:Button ID="btn6" runat="server" Text="6" Width="100px" />
        <asp:Button ID="btnMult" runat="server" Text="X" Width="100px" />
        <br />
        <asp:Button ID="btn7" runat="server" Text="7" Width="100px" />
        <asp:Button ID="btn8" runat="server" Text="8" Width="100px" />
        <asp:Button ID="btn9" runat="server" Text="9" Width="100px" />
        <asp:Button ID="btnMenos" runat="server" Text="-" Width="100px" />
        <br />
        <asp:Button ID="btn0" runat="server" Text="0" Width="200px" />
        <asp:Button ID="btnPunto" runat="server" Text="." Width="100px" />
        <asp:Button ID="btnMas" runat="server" Text="+" Width="100px" />
        <asp:Button ID="btnIgual" runat="server" Text="=" Width="100px" OnClick="btnIgual_Click" />
        <br />
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>