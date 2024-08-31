<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="WebApplicationTEST.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
    <div class="card text-center">
  <div class="card-header">
    Your Information
  </div>

  <div class="card-body">
            <br />
      <asp:Label ID="Label1" runat="server" Text="" class="card-title"></asp:Label>
            <br />
            <br />
      <asp:Label ID="Label2" runat="server" Text="" class="card-text"></asp:Label>
            <br />
            <br />

      <asp:Button ID="Back" runat="server" Text="Back" OnClick="Back_Click" />
  </div>

</div>
        </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>
