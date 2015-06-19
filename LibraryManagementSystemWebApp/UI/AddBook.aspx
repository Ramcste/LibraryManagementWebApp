<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="LibraryManagementSystemWebApp.AddBook" %>

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
            <td><asp:Label runat="server" ID="label1">Title</asp:Label></td>
            
            <td>  <asp:TextBox runat="server" ID="titleNameTextBox" Width="220"/></td>
           
              
        </tr>
        <tr>
            <td>
                 <asp:Label runat="server" ID="label2">Author</asp:Label>
            </td>
           
            <td>
                 <asp:TextBox runat="server" ID="authorNameTextBox" Width="220"></asp:TextBox>
            </td>
                     
        </tr>
         <td>
                 <asp:Label runat="server" ID="label3">Publisher</asp:Label>
            </td>
           
            <td>
                 <asp:TextBox runat="server" ID="publisherNameTextBox" Width="220"></asp:TextBox>
            </td>
        
        <tr>
            <td></td>
            <td><asp:Button runat="server" ID="saveBookButton" Text="Save" OnClick="saveBookButton_OnClick" Width="80"  /></td>
        </tr>
          
    </table>
                 <asp:Label runat="server" ID="label4"/>
    </div>

        </div>

   
    </form>
</body>
</html>
