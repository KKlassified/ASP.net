<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="confirmUser.aspx.cs" Inherits="PracticemakesPerfect.Secondpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Submission</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <asp:Label ID ="lblfn" AssociatedControlID="lbl_fname" Text="First Name:" runat="server"></asp:Label>
            <asp:Label ID="lbl_fname" runat="server"></asp:Label><br/><br/>
            <asp:Label ID ="lblln" AssociatedControlID="lbl_lname" Text="Last Name:" runat="server"></asp:Label>
            <asp:Label ID="lbl_lname" runat="server"></asp:Label><br/><br/>
            <asp:Label ID ="lblun" AssociatedControlID="lbl_uname" Text="Username:" runat="server"></asp:Label>
            <asp:Label ID="lbl_uname" runat="server"></asp:Label><br/><br/>
            <asp:Label ID ="lblpw" AssociatedControlID="lbl_pword" Text="Password:" runat="server"></asp:Label>
            <asp:Label ID="lbl_pword" runat="server"></asp:Label><br/><br/>
            <asp:Label ID ="lbl_adrs" AssociatedControlID="lbl_address" Text="Address:" runat="server"></asp:Label>
            <asp:Label ID="lbl_address" runat="server"></asp:Label><br/><br/>
            <asp:Label ID ="lbleml" AssociatedControlID="lbl_email" Text="E-mail:" runat="server"></asp:Label>
            <asp:Label ID="lbl_email" runat="server"></asp:Label><br/><br/>
            <asp:Label ID ="lblpnum" AssociatedControlID="lbl_pnumber" Text="Phone Number:" runat="server"></asp:Label>
            <asp:Label ID="lbl_pnumber" runat="server"></asp:Label><br/><br/>
            <asp:Button ID ="updateButton" runat="server" Text="Update Account"  Onclick="updateButton_Click"/><br/><br/>
             <asp:Button ID ="home" runat="server" Text="Home"  Onclick="home_Click"/>
             
            
                       
    </div>
    </form>
</body>
</html>
