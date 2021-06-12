<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UserAdminApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-+0n0xVW2eSR5OomGNYDnhzAbDsOXxcvSN1TPprVMTNDbiYZCxYbOOl7+AMvyTG2x" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h2>Log in</h2>
        <asp:Label ID="txtError" runat="server" Text="The username or password are not correct" style="color: red"></asp:Label>
        <div class="form-control">
            <asp:Label ID="Label1" runat="server" Text="User Name :"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" TextMode="Email"></asp:TextBox>
        </div>
        <div class="form-control">
            <asp:Label ID="Label2" runat="server" Text="Password :"></asp:Label>
            <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <asp:Button ID="btnLogin" runat="server" Text="Login" class="btn btn-primary" OnClick="btnLogin_Click"/>
        </div>

        <div>
             <h2>Register new user</h2>
            <asp:Label ID="txtRegisterError" runat="server" Text="Please fill all the fields" style="color: red"></asp:Label>
            <div class="form-control">
                <asp:Label ID="Label4" runat="server" Text="User Name :"></asp:Label>
                <asp:TextBox ID="txtName" runat="server" ></asp:TextBox>
            </div>
            <div class="form-control">
                <asp:Label ID="Label6" runat="server" Text="User Email :"></asp:Label>
                <asp:TextBox ID="txtRegisterEmail" runat="server" ></asp:TextBox>
            </div>
            <div class="form-control">
                <asp:Label ID="Label5" runat="server" Text="Password :"></asp:Label>
                <asp:TextBox ID="txtRegisterPass" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div class="form-control">
                <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
            </div>
        </div>
    </form>
</body>
</html>