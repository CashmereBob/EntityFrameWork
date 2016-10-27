<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="papers.aspx.cs" Inherits="Labb4._4Web.papers" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Papers</h2>
  <div class="row">
      <div class="col-xs-3">
             <div class="input-group text-left">
                <asp:TextBox ID="txtName" runat="server" CssClass="form-control" placeholder="Name" /> 
                 <span class="input-group-btn text-left">
                 <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="Insert" CssClass="btn btn-success"/>
            </span>
           </div>
        </div>
    </div>
    <hr />
    <asp:Label ID="exceptionLable" runat="server"></asp:Label>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataKeyNames="Id"
        OnRowDataBound="OnRowDataBound" OnRowEditing="OnRowEditing" OnRowCancelingEdit="OnRowCancelingEdit"
        OnRowUpdating="OnRowUpdating" OnRowDeleting="OnRowDeleting" EmptyDataText="No records has been added." CssClass="table-striped table">

        <Columns>
            <asp:TemplateField HeaderText="ID">
                <ItemTemplate>
                    <asp:Label ID="lblId" runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Name">
                <ItemTemplate>
                    <asp:Label ID="lblName" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtName" CssClass="form-control" runat="server" Text='<%# Eval("Name") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true"  />
        </Columns>

    </asp:GridView>

</asp:Content>