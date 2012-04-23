<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fitness.aspx.cs" Inherits="FitnessWeb.Fitness" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
&nbsp;<p>
        <asp:Button ID="button1" runat="server" Height="57px" onclick="Button1_Click" 
            Text="Sort By ID" Width="95px" />
&nbsp;&nbsp;
        <asp:Button ID="button2" runat="server" Height="57px" onclick="Button2_Click" 
            Text="Sort By Location" Width="101px" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="button3" runat="server" Height="57px" onclick="Button3_Click" 
            Text="Sort By Date" Width="95px" />
&nbsp;</p>
    <asp:ListBox ID="listBox1" runat="server" Height="320px" 
        onselectedindexchanged="ListBox1_SelectedIndexChanged" Width="320px">
    </asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="textBox1" runat="server" ForeColor="Black" Height="320px" 
        Width="320px"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="button4" runat="server" Height="57px" onclick="button4_Click" 
        Text="Add A Class" Width="95px" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="button5" runat="server" Height="57px" onclick="button5_Click" 
        Text="Delete a Class" Width="95px" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="button6" runat="server" Height="57px" onclick="button6_Click" 
        Text="Save All" Width="95px" />
    </form>
</body>
</html>
