<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Info.aspx.cs" Inherits="WebApplicationTEST.Info" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">

  <div class="mb-3">
 
      <asp:Label ID="Label1" runat="server" Text="Name" class="form-label"></asp:Label>
   
      <asp:TextBox ID="name" class="form-control" runat="server" Width="289px"></asp:TextBox>
    </div>

  <div class="mb-3">
       <asp:Label ID="Label2" runat="server" Text="Id" class="form-label"></asp:Label>
       <asp:TextBox ID="Id" class="form-control" runat="server" Width="287px"></asp:TextBox>
  </div>

        <asp:Button ID="Button1" runat="server" Text="Enter " class="btn btn-primary" OnClick="Button1_Click"/>
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="Go " class="btn btn-primary" OnClick="Button_Click"/>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>
