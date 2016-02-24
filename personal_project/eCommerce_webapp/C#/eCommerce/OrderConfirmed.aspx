<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderConfirmed.aspx.cs" Inherits="eCommerce.OrderConfirmed" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Congratulations! Order Confirmed..
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Start Over" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
