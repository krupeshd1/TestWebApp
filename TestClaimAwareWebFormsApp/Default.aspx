<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="TestClaimAwareWebFormsApp._Default" %>  

<!DOCTYPE html>  

<html>  
<head id="Head1" runat="server">  
    <title></title>  
</head>  
<body> 
    <p>test claims</p>
    <h1><asp:label ID="signedIn" runat="server" /></h1>  
    <asp:label ID="claimType" runat="server" />  
    <asp:label ID="claimValue" runat="server" />  
    <asp:label ID="claimValueType" runat="server" />  
    <asp:label ID="claimSubjectName" runat="server" />  
    <asp:label ID="claimIssuer" runat="server" />  

</body>  
</html>   
