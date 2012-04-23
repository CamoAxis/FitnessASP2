<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fitness.aspx.cs" Inherits="FitnessWeb.Fitness" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 367px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table border="0" style="width:100%;">
        <tr>
            <td class="style1">
    <asp:Label ID="Label1" runat="server" Text="Available Classes"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
        <asp:Button ID="buttonSortId" runat="server" Height="29px" 
            Text="Sort By ID" Width="85px" onclick="buttonSortId_Click" />
        <asp:Button ID="buttonSortLoc" runat="server" Height="29px" 
            Text="Sort By Location" Width="109px" onclick="buttonSortLoc_Click" />
        <asp:Button ID="buttonSortDate" runat="server" Height="29px"
            Text="Sort By Date" Width="95px" onclick="buttonSortDate_Click" />
            </td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Description"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style1">

    <asp:ListBox ID="listClasses" runat="server" Height="320px" Width="320px" 
                    onselectedindexchanged="listClasses_SelectedIndexChanged" AutoPostBack="true">
        </asp:ListBox>
            </td>
            <td valign="top">
                <asp:Label ID="textClassDescr" runat="server" Text="..."></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style1">
    <asp:Button ID="buttonAddClass" runat="server" Height="29px" 
        Text="Add A Class" Width="95px" onclick="buttonAddClass_Click" />
    <asp:Button ID="buttonDeleteClass" runat="server" Height="29px" 
        Text="Delete a Class" Width="111px" />
    <asp:Button ID="buttonSave" runat="server" Height="29px" 
        Text="Save All" Width="95px" onclick="buttonSave_Click" />
            </td>
            <td></td>
        </tr>
    </table>
    </form>
</body>
</html>
