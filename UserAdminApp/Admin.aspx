<%@ Page Language="C#" AutoEventWireup="true"   CodeBehind="Admin.aspx.cs" Inherits="UserAdminApp.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-+0n0xVW2eSR5OomGNYDnhzAbDsOXxcvSN1TPprVMTNDbiYZCxYbOOl7+AMvyTG2x" crossorigin="anonymous">
</head>
<body>
    <div class="container">
        <form  runat="server">
        <div class="row">
            <div class="col-md46">
                <h1>Add New Formation</h1>
                
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="Name :"></asp:Label>

                            </td>
                            <td>
                                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="Prix :"></asp:Label>

                            </td>
                            <td>
                                <asp:TextBox ID="txtPrix" runat="server"></asp:TextBox>
                            </td>
                        </tr>
        
                        <tr>
                            <td></td>
                            <td>
                                <asp:Button ID="btnAddFormation" runat="server" Text="Add Formation" OnClick="btnAddFormation_Click" class="btn btn-primary m-3"/>
                            </td>
                        </tr>

                    </table>
               
            </div>

            <div class="col-md-4">
                <h1>Add New User</h1>
               
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="Name :"></asp:Label>

                            </td>
                            <td>
                                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label5" runat="server" Text="Email :"></asp:Label>

                            </td>
                            <td>
                                <asp:TextBox ID="txtUserEmail" runat="server" TextMode="Email"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td>
                                <asp:Label ID="Label4" runat="server" Text="Password :"></asp:Label>

                            </td>
                            <td>
                                <asp:TextBox ID="txtUserPass" runat="server"></asp:TextBox>
                            </td>
                        </tr>

                         <tr>
                            <td>
                                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                    <asp:ListItem Value="1">Admin</asp:ListItem>
                                    <asp:ListItem Value="2">User</asp:ListItem>

                                </asp:RadioButtonList>
                            </td>
                            <td>
                            </td>
                        </tr>
        
                        <tr>
                            <td></td>
                            <td>
                                <asp:Button ID="btnAddUser" runat="server" Text="Add User" class="btn btn-primary" OnClick="btnAddUser_Click"/>
                            </td>
                        </tr>

                    </table>
                <asp:Label ID="txtRes" runat="server" Text="Label"></asp:Label>
            </div>
        </div>

             <h1>Users List</h1>
    <asp:GridView ID="dgvUsers" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <%--<Columns>
            <asp:BoundField HeaderText="Id" />
            <asp:BoundField HeaderText="Name" />
            <asp:BoundField HeaderText="Email" />
        </Columns>--%>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>

    <h1>Formation List</h1>
    <asp:GridView ID="dgvFormation" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <%--<Columns>
            <asp:BoundField HeaderText="Id" />
            <asp:BoundField HeaderText="Name" />
            <asp:BoundField HeaderText="Prix" />
        </Columns>--%>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>

    </div>
    </form>

   
    
</body>
</html>

