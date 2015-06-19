<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReturnBook.aspx.cs" Inherits="LibraryManagementSystemWebApp.ReturnBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../style.css" rel="stylesheet" />
    <link href="../reset.css" rel="stylesheet" />
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
            <td><asp:Label runat="server" ID="label1">Enter Member no.</asp:Label></td>
            
            <td>  <asp:TextBox runat="server" ID="memberNoTextBox" Width="220"/></td>
           
              
        </tr>
        <tr>
            <td>
                 
            </td>
           
            <td>
                 <asp:Button runat="server" ID="showBorrowedBooksList" OnClick="showBorrowedBooksList_OnClick" Text="Show Borrowed Books" Width="220"></asp:Button>
            </td>
                     
        </tr>
        
            
        
       
        <tr>
         <td>
                 <asp:Label runat="server" ID="label3">Borrowed booklist</asp:Label>
            </td>
           
            <td>
                 <asp:DropDownList runat="server" ID="borrowedbooklist" AutoPostBack="True" Width="220"></asp:DropDownList>
            </td>
            </tr>
        
        <tr>
            <td></td>
            <td><asp:Button runat="server" ID="returnBookButton" Text="Return" OnClick="returnBookButton_OnClick"  Width="80" style="height: 26px"  /></td>
        </tr>
          
    </table>
                 <asp:Label runat="server" ID="label4"/>
    </div>

        </div>
    </form>
</body>
</html>
