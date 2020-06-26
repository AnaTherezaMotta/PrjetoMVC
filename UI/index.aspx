<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ProjetoMVCB0207.UI.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Checar</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"/>
    <link rel="stylesheet" href="CSS/styleIndex.css"/>
    
</head>
<body>
    <form class="box" id="form1" runat="server">
         
        <div class="container">
                <div class="form-group" >
                    <asp:Label ID="lblCpf" runat="server" Text="CPF:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtCpfB0207" type="number" runat="server"></asp:TextBox>
                </div>
                <div class="form-group" >
                    <asp:Label ID="lblNome" runat="server" Text="Nome Completo"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtNomeB0207" type="text" runat="server"></asp:TextBox>
                </div>
                <div class="form-group" >
                    <asp:Label ID="lblNomeMae" runat="server" Text="Nome da mãe"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtNomeMaeB0207" type="text" runat="server"></asp:TextBox>
                </div>
                <div class="send">
                    <asp:Button ID="btnChecarBeneficio" CssClass="btn btn-success" OnClick="btnChecarBeneficio_Click" Text="ENVIAR" runat="server"/>
                    <asp:Label ID="lblResposta" runat="server" Text="Resultado"></asp:Label>
                </div>
        </div>
    </form>
</body>
</html>
