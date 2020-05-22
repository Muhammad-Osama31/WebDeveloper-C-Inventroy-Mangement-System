<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="units.aspx.cs" Inherits="WebApplication1.units" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Unit" Font-Bold="True" Font-Size="15pt"></asp:Label>
<asp:TextBox ID="txtunit" runat="server"></asp:TextBox>
<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1">
</asp:GridView>
    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="15pt" Text="id_unit"></asp:Label>
    <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
    <asp:Button ID="Button3" runat="server" BackColor="#6699FF" Font-Bold="True" Height="35px" OnClick="Button3_Click" Text="Update" Width="78px" />
    <asp:Button ID="Button2" runat="server" BackColor="#6699FF" Font-Bold="True" Font-Size="10pt" Height="33px" OnClick="Button2_Click" Text="Delete" Width="77px" />
<asp:Button ID="Button1" runat="server" BackColor="#3366FF" Font-Bold="True" OnClick="Button1_Click" Text="Add Unit" Height="35px" />
    </asp:Content>
