<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormEnterData.aspx.cs" Inherits="trainee.WebFormEnterData" %>

<asp:Content ID="id05" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        
        <asp:Label ID="TID" runat="server" Text="TID"></asp:Label>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="enter id" ForeColor="Red" ValidationGroup="vg" Font-Size="Smaller"></asp:RequiredFieldValidator>
        <br />
        <asp:TextBox ID="idno" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="TNAME" runat="server" Text="TNAME"></asp:Label>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="enter name" ForeColor="Red" Font-Size="Smaller"></asp:RequiredFieldValidator>
        <br />
        <asp:TextBox ID="name" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="LOCATION" runat="server" Text="LOCATION"></asp:Label>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="select location" Font-Size="Smaller" ForeColor="Red" ValidationGroup="vg"></asp:RequiredFieldValidator>
        <br />
        <asp:DropDownList ID="locations" runat="server">
            <asp:ListItem>Andhra Pradesh</asp:ListItem>
            <asp:ListItem>Assam</asp:ListItem>
            <asp:ListItem>Bangalore</asp:ListItem>
            <asp:ListItem>Cochin</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="DOMAIN" runat="server" Text="TECH DOMAIN"></asp:Label>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="select domain" Font-Size="Smaller" ForeColor="Red" ValidationGroup="vg"></asp:RequiredFieldValidator>
        <br />
        <asp:DropDownList ID="domains" runat="server">
            <asp:ListItem>c</asp:ListItem>
            <asp:ListItem>c#</asp:ListItem>
            <asp:ListItem>dot net</asp:ListItem>
            <asp:ListItem>selenium</asp:ListItem>
            <asp:ListItem>python</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="DATE" runat="server" Text="START DATE"></asp:Label>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="select date" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <br />
        <asp:Button ID="Button1" runat="server" Text="SUBMIT" OnClick="Button1_Click" />
        </div>
    </asp:Content>


