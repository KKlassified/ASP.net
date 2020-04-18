<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateInfo.aspx.cs" Inherits="PracticemakesPerfect.UpdateInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <asp:Label ID ="lblfn" AssociatedControlID="txt_fname" Text="First Name:" runat="server"></asp:Label>
         <asp:TextBox ID="txt_fname" runat="server"></asp:TextBox><br/><br/>
         <asp:Label ID ="lblln" AssociatedControlID="txt_lname" Text="Last Name:" runat="server"></asp:Label>
         <asp:TextBox ID="txt_lname" runat="server"></asp:TextBox><br/><br/>
         <asp:Label ID ="lblun" AssociatedControlID="txt_uname" Text="Username:" runat="server"></asp:Label>
         <asp:TextBox ID="txt_uname" runat="server"></asp:TextBox><br/><br/>
         <asp:Label ID ="lblpw" AssociatedControlID="txt_pword" Text="Password:" runat="server"></asp:Label>
         <asp:TextBox ID="txt_pword" runat="server"></asp:TextBox><br/><br/>
         <asp:Label ID ="lbl_adrs" AssociatedControlID="txt_address" Text="Address:" runat="server"></asp:Label>
         <asp:TextBox ID="txt_address" runat="server"></asp:TextBox><br/><br/>
         <asp:Label ID ="lbleml" AssociatedControlID="txt_email" Text="E-mail:" runat="server"></asp:Label>
         <asp:TextBox ID="txt_email" runat="server"></asp:TextBox><br/><br/>
         <asp:Label ID ="lblpnum" AssociatedControlID="txt_pnumber" Text="Phone Number:" runat="server"></asp:Label>
         <asp:TextBox ID="txt_pnumber" runat="server"></asp:TextBox><br/><br/>
         <asp:Button ID ="submitButton" runat="server" Text="Submit"  Onclick="submitButton_Click"/>
        
    </div>
    </form>
</body>
</html>
