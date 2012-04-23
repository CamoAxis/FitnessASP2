﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FitnessOps.aspx.cs" Inherits="FitnessWeb.FitnessOps" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 166px;
        }
        .style2
        {
            width: 166px;
            height: 50px;
        }
        .style3
        {
            height: 50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="style1" align="right">
    <asp:Label ID="Label1" runat="server" Text="Class Id"></asp:Label>
            </td>
            <td>
    <asp:TextBox ID="TextBox1" runat="server" Width="170px" 
                    style="margin-left: 0px; margin-bottom: 0px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1" align="right">
    <asp:Label ID="Label2" runat="server" Text="Class Description"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox9" runat="server" Height="71px" Rows="4" Width="333px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1" align="right">
    <asp:Label ID="Label3" runat="server" Text="Location"></asp:Label>
            </td>
            <td>
    <asp:TextBox ID="TextBox3" runat="server" Width="332px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1" align="right">
    <asp:Label ID="Label4" runat="server" Text="Spaces in Class"></asp:Label>
            </td>
            <td>
    <asp:TextBox ID="TextBox4" runat="server" Width="170px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1" align="right">
    <asp:Label ID="Label5" runat="server" Text="Day of the Week"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Height="25px" Width="175px">
                    <asp:ListItem Value="0">Monday</asp:ListItem>
                    <asp:ListItem Value="1">Tuesday</asp:ListItem>
                    <asp:ListItem Value="2">Wednesday</asp:ListItem>
                    <asp:ListItem Value="3">Thursday</asp:ListItem>
                    <asp:ListItem Value="4">Friday</asp:ListItem>
                    <asp:ListItem Value="5">Saturday</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style1" align="right">
    <asp:Label ID="Label6" runat="server" Text="Time"></asp:Label>
            </td>
            <td>
    <asp:TextBox ID="TextBox6" runat="server" Width="170px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1" align="right">
    <asp:Label ID="Label7" runat="server" Text="Duration"></asp:Label>
            </td>
            <td>
    <asp:TextBox ID="TextBox7" runat="server" Width="170px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1" align="right">
    <asp:Label ID="Label9" runat="server" Text="Multiweek Class"></asp:Label>
            </td>
            <td>
    <asp:CheckBox ID="CheckBox1" runat="server" Text="Yes" />
            </td>
        </tr>
        <tr>
            <td class="style1" align="right">
    <asp:Label ID="Label8" runat="server" Text="Start Date"></asp:Label>
            </td>
            <td>
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            </td>
        </tr>
        <tr>
            <td class="style2" align="right">
    <asp:Label ID="Label10" runat="server" Text="Number of Sessions"></asp:Label>
            </td>
            <td class="style3">
    <asp:TextBox ID="TextBox10" runat="server" Width="170px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td>
    <asp:Button ID="button2" runat="server" Height="29px" onclick="button2_Click" 
        Text="Cancel" Width="75px" />
    <asp:Button ID="button1" runat="server" Height="29px" Text="Add Class" 
        Width="165px" />
            </td>
        </tr>
    </table></form>
</body>
</html>
