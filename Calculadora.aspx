<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="calcu.Calculadora1" %>


<!DOCTYPE html>
<html lang="es">
<head>
    <title>Calculadora</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Calculadora Web</h2>
            <label for="">Número 1:</label>
            <asp:TextBox ID="txtNumero1" runat="server" OnTextChanged="txtNumero1_TextChanged"></asp:TextBox>
            <br />
            <label for="txtNumero2">Número 2:</label>
            <asp:TextBox ID="txtNumero2" runat="server" OnTextChanged="txtNumero2_TextChanged"></asp:TextBox>
            <br /><br />

            <!-- Checkboxes -->
            <h3>Operaciones con Checkboxes</h3>
            <asp:CheckBox ID="chkSuma" runat="server" Text="Sumar" />
            <asp:CheckBox ID="chkResta" runat="server" Text="Restar" OnCheckedChanged="chkResta_CheckedChanged" />
            <asp:CheckBox ID="chkMultiplicacion" runat="server" Text="Multiplicar" />
            <asp:CheckBox ID="chkDivision" runat="server" Text="Dividir" />
            <br /><br />

            <!-- Radiobuttons -->
            <h3>Operaciones con Radiobuttons</h3>
            <asp:RadioButton ID="rbSuma" GroupName="Operacion" runat="server" Text="Sumar" OnCheckedChanged="rbSuma_CheckedChanged" />
            <asp:RadioButton ID="rbResta" GroupName="Operacion" runat="server" Text="Restar" />
            <asp:RadioButton ID="rbMultiplicacion" GroupName="Operacion" runat="server" Text="Multiplicar" />
            <asp:RadioButton ID="rbDivision" GroupName="Operacion" runat="server" Text="Dividir" />
            <br /><br />

            <!-- Dropdown List -->
            <h3>Operaciones con Dropdown List</h3>
            <asp:DropDownList ID="ddlOperaciones" runat="server" OnSelectedIndexChanged="ddlOperaciones_SelectedIndexChanged">
                <asp:ListItem Text="Seleccione una operación" Value="" />
                <asp:ListItem Text="Sumar" Value="Suma" />
                <asp:ListItem Text="Restar" Value="Resta" />
                <asp:ListItem Text="Multiplicar" Value="Multiplicacion" />
                <asp:ListItem Text="Dividir" Value="Division" />
            </asp:DropDownList>
            <br /><br />

            <!-- Botón para calcular -->
            <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click" />
            <br /><br />

            <!-- Resultado -->
            <asp:Label ID="lblResultado" runat="server" Text="El resultado aparecerá aquí"></asp:Label>
        </div>
    </form>
</body>
</html>
