<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Question2.aspx.cs" Inherits="Question2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">

    <h2>Question 2</h2>

    
    <h3>Load your XML File</h3>

    <!-- BEGIN FORM Q2 -->
    <div class="form-group">
        <label for="exampleInputFile">File input</label>
        <asp:FileUpload ID="fluXml" runat="server" />
    </div>
    <div class="form-group">
        <asp:Button ID="btnValidation" CssClass="btn btn-success" runat="server" Text="Validate" OnClick="btnValidation_Click" />
    </div>
    <!-- END FORM Q2 -->

    <strong>
        <asp:Label ID="lblStatus" runat="server"></asp:Label>
    </strong>


    <h3>REFERENCE LIST</h3>
    <asp:GridView ID="gvRef" CssClass="table table-striped" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Key" HeaderText="Key" />
            <asp:BoundField DataField="Value" HeaderText="Value" />
        </Columns>
        <RowStyle CssClass="table table-striped" />
    </asp:GridView>
</asp:Content>

