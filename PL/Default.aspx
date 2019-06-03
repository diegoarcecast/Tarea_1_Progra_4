<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PL._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <div class="jumbotron">
        <h1>Ejemplo de una calculadora</h1>
        <div class="jumbotron" style="width: 80%; margin: 0 auto" >
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <asp:TextBox ID="TextBox1" runat="server" Width="492px" OnTextChanged="TextBox1_TextChanged" Enabled="False"></asp:TextBox>
        <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" Width="100px" OnClick="btnLimpiar_Click" />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="Error de Sintaxis" OnDataBinding="TextBox1_TextChanged" ValidationExpression="^[-+]?[0-9]+([-+*/]+[-+]?[0-9]+)*$" EnableClientScript="False"></asp:RegularExpressionValidator>
        <br />
        <asp:Button ID="btn1" runat="server" Text="1" Width="100px" OnClick="btn1_Click" />
        <asp:Button ID="btn2" runat="server" Text="2" Width="100px" OnClick="btn2_Click" />
        <asp:Button ID="btn3" runat="server" Text="3" Width="100px" OnClick="btn3_Click" />
        <asp:Button ID="btndiv" runat="server" Text="/" Width="100px" OnClick="btndiv_Click" />
        <asp:Button ID="btnData" runat="server" Text="DATA" Width="100px" OnClick="btnData_Click" />

        <br />
        <asp:Button ID="btn4" runat="server" Text="4" Width="100px" OnClick="btn4_Click" />
        <asp:Button ID="btn5" runat="server" Text="5" Width="100px" OnClick="btn5_Click" />
        <asp:Button ID="btn6" runat="server" Text="6" Width="100px" OnClick="btn6_Click" />
        <asp:Button ID="btnMult" runat="server" Text="X" Width="100px" OnClick="btnMult_Click" />
        <br />
        <asp:Button ID="btn7" runat="server" Text="7" Width="100px" OnClick="btn7_Click" />
        <asp:Button ID="btn8" runat="server" Text="8" Width="100px" OnClick="btn8_Click" />
        <asp:Button ID="btn9" runat="server" Text="9" Width="100px" OnClick="btn9_Click" />
        <asp:Button ID="btnMenos" runat="server" Text="-" Width="100px" OnClick="btnMenos_Click" />
        <br />
        <asp:Button ID="btn0" runat="server" Text="0" Width="204px" OnClick="btn0_Click" />
        <asp:Button ID="btnPunto" runat="server" Text="&lt;---" Width="100px" OnClick="btnPunto_Click" />
        <asp:Button ID="btnMas" runat="server" Text="+" Width="100px" OnClick="btnMas_Click" />
        <asp:Button ID="btnIgual" runat="server" Text="=" Width="100px" OnClick="btnIgual_Click" />
        <br />
            </div>
        <div class="jumbotron" style="width: 50%; margin: 0 auto" >
        <p><asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" Visible="False" AllowPaging="True">
            <Columns>
                <asp:BoundField DataField="Resultado" HeaderText="Resultado" SortExpression="Resultado" />
                <asp:BoundField DataField="Mensaje" HeaderText="Mensaje" SortExpression="Mensaje" />
                <asp:CheckBoxField DataField="EsValido" HeaderText="EsValido" SortExpression="EsValido" />
            </Columns>
            <HeaderStyle CssClass="header" />
            <PagerStyle CssClass="pager" />
            <RowStyle CssClass="rows" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CalculadoraConnectionString %>" SelectCommand="SELECT * FROM [Resultados]"></asp:SqlDataSource>
        </p>
            </div>
    </div>

    <div class="row">
    </div>

</asp:Content>
