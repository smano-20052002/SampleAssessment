<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SampleAssessment.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="./Style/Login.css" type="text/css"/>
</head>
<body>
   <div class='bold-line'></div>
<div class='container'>
  <div class='window'>
    <div class='overlay'></div>
    <form class='content' runat="server" >
      <div class='welcome'>Hello There!</div>
      <div class='subtitle'>We're almost done. Before using our services you need to create an account.</div>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
      <div class='input-fields'>
          <asp:TextBox ID="TextBox1" class="input input-line full-width" runat="server" TextMode="Email"></asp:TextBox>
          <asp:TextBox ID="TextBox2" class="input input-line full-width" runat="server" TextMode="Password"></asp:TextBox>
          
      </div>
      <a href="Register.aspx" class='spacing'>Not have an<span class='highlight'>Account</span></a>
      <div>
          <asp:Button ID="Button1" class='ghost-round full-width' runat="server" Text="Login" OnClick="Button1_Click" />
      </div>
    </form>
  </div>
</div>
</body>
</html>
