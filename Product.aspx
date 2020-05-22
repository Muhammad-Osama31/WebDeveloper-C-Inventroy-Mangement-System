<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="WebApplication1.Product1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 728px;
            height: 405px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="Label1" runat="server" Text="Product id" Font-Bold="True" Font-Size="15pt"></asp:Label>

                <asp:TextBox ID="txtid" runat="server" style="margin-left: 50px" Width="220px"></asp:TextBox>

            <br />
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="15pt" Text="Productname"></asp:Label>
                <asp:TextBox ID="txtproductname" runat="server" Width="193px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="15pt" Text="unit"></asp:Label>
                <asp:TextBox ID="txtunit" runat="server" Width="194px" style="margin-left: 77px"></asp:TextBox>
                <br />
                <br />
                <img alt="imaga" class="auto-style1" src="1.png" /><br />
                <asp:Button ID="btnAddnewUser0" runat="server" BackColor="#6699FF" OnClick="btnAddnewUser_Click" Text="Add New Product" />
                &nbsp;<asp:Button ID="btndelete" runat="server" BackColor="#3399FF" OnClick="Button1_Click" style="margin-left: 34px" Text="Delete" Width="68px" />
                &nbsp;
                <asp:Button ID="update" runat="server" OnClick="update_Click" Text="Update" BackColor="#9999FF" />
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:GridView ID="GridView1" runat="server" Height="175px" Width="588px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                </asp:GridView>
                <br />
                <br />
                <br />
        </div>
    </form>
</body>
</html>
