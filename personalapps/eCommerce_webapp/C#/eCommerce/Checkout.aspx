<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="eCommerce.Checkout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        &nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Selected="True" Value="0"></asp:ListItem>
            <asp:ListItem Value="1"></asp:ListItem>
            <asp:ListItem Value="2"></asp:ListItem>
            <asp:ListItem Value="3"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        &nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem Selected="True">0</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        &nbsp;
        <asp:DropDownList ID="DropDownList3" runat="server">
            <asp:ListItem Selected="True">0</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Checkout" Width="127px" OnClick="Button1_Click" />
    
        <br />
        <br />
    
    </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:eCommerceConnectionString %>" OnSelecting="SqlDataSource1_Selecting" SelectCommand="SELECT [ItemName], [Quantity], [ID] FROM [checkout]"></asp:SqlDataSource>
    </form>
</body>
</html>
