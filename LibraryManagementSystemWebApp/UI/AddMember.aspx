<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddMember.aspx.cs" Inherits="LibraryManagementSystemWebApp.AddMember" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../reset.css" rel="stylesheet" />
    <link href="../style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        
        <div class="wrapper">
            
             <nav>
            <ul>
                <li><a href="AddBook.aspx">Add Book</a></li>
                <li><a href="AddMember.aspx">Add Member</a></li>
                <li><a href="BorrowBook.aspx">Borrow Book</a></li>
                <li><a href="ReturnBook.aspx">Return Book</a></li>
            </ul>
      
        </nav>
             <div class="container">
    <table>
        <tr>
            <td><asp:Label runat="server" ID="label1">Member</asp:Label></td>
            
            <td>  <asp:TextBox runat="server" ID="memberIdTextBox"/></td>
           
              
        </tr>
        <tr>
            <td>
                 <asp:Label runat="server" ID="label2">Name</asp:Label>
            </td>
           
            <td>
                <asp:TextBox runat="server" ID="nameTextBox"/>
            </td>
                     
        </tr>
        <tr>
            <td></td>
            <td><asp:Button runat="server" ID="saveMemberButton" Text="Save" OnClick="saveMemberButton_OnClick"  Width="80"  /></td>
        </tr>
          
    </table>
                 
                 <asp:Label runat="server" ID="label3"/>
    </div>

        </div>

   
    </form>
</body>
</html>
