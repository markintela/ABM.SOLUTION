<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Question1.aspx.cs" Inherits="Question1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    
    <h2>Question 1</h2>

    <!-- BEGIN FORM Q1 -->
    <asp:TextBox ID="txtMessage" runat="server" CssClass="form-control" TextMode="Multiline" Height="200" Width="700" Wrap="true" />
    <br />
    <asp:Button ID="btnSend" CssClass="btn btn-success" runat="server" Text="Get Array" OnClick="btnSend_Click" />
     <!-- END FORM Q1 -->
   
    <h3>LIST LOC ELEMENTS</h3>

   <!-- GRIDVIEW -->
   <asp:GridView ID="gvLoc" runat="server" AutoGenerateColumns="true">  
   </asp:GridView>

</asp:Content>

