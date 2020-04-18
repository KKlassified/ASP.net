<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="PracticemakesPerfect.index1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <header id="header">
            <img src="images1/carbanner.jpeg" alt="not here" />
        </header>
            <nav id="navigation">
               <ul> 
                    <li><asp:HyperLink id="hyperlink1"   NavigateUrl="productManagement/newProduct.aspx"  Text="Add Product" runat="server" /></li>
                    <li><asp:HyperLink id="hyperlink2"   NavigateUrl="userManagement/UpdateInfo.aspx"  Text="Update User" runat="server" /></li>
                    <li><asp:HyperLink id="hyperlink3"   NavigateUrl="shopping/shopping.aspx"  Text="Shopping" runat="server" /></li>
                    <li><asp:HyperLink id="hyperlink4"   NavigateUrl="#"  Text="News" runat="server" /></li>
                    <li><asp:HyperLink id="hyperlink5"   NavigateUrl="#"  Text="Contact Us" runat="server" /></li>
                </ul>
             </nav>
        <hr/>
            <div id="login">
                 <asp:TextBox ID="txt_uname" runat="server" placeholder="Username"></asp:TextBox><br/><br/>
                 <asp:TextBox ID="txt_pword" runat="server" placeholder="Password"></asp:TextBox><br/><br/>
                 <asp:Button ID ="submitButton" runat="server" Text="Submit"  Onclick="submitButton_Click"/><br/><br/>
            </div>
            <div id="button">
                 <asp:Button ID ="signUp" runat="server" Text="Sign-up"  Onclick="signUp_Click"/><br/>
            </div>
            <div id="prompt">
                 <asp:Label ID="lbl_fname" runat="server"></asp:Label><br/><br/>
            </div>
 
           
        <hr/>


        <footer id="footer">
                Contact us at Cool Cars Company
        </footer>
    
    </div>
    </form>
</body>
</html>
