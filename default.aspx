<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="movie_tracker_wf2._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Movie Tracker</title>
    <link href="style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <h1>Movie Tracker</h1>
    <div class="container">
        <asp:Label ID="Label1" runat="server" Text="Title" CssClass="column1"></asp:Label>
        <asp:TextBox ID="titleTextBox" runat="server" CssClass="column2"></asp:TextBox>
        <asp:RequiredFieldValidator 
            ID="RequiredFieldValidator1" 
            runat="server" 
            ErrorMessage="Title is required" 
            ControlToValidate="titleTextBox" 
            CssClass="column3" 
            SetFocusOnError="True" 
            Text="Required">
        </asp:RequiredFieldValidator>

        <asp:Label ID="Label2" runat="server" Text="Date" CssClass="column1"></asp:Label>
        <asp:TextBox ID="dateTextBox" runat="server" TextMode="Date" CssClass="column2"></asp:TextBox>
        <asp:RequiredFieldValidator 
            ID="RequiredFieldValidator2" 
            runat="server" 
            ErrorMessage="Date is required" 
            Text="<img src='images/error.png' alt='Date is required.' title='Required.' />" 
            CssClass="column3" 
            SetFocusOnError="True" 
            ControlToValidate="dateTextBox">
        </asp:RequiredFieldValidator>

        <asp:Label ID="Label3" runat="server" Text="Genre" CssClass="column1"></asp:Label>
        <asp:DropDownList ID="genreDropDownList" runat="server">
            <asp:ListItem Value ="none">Please select a genre</asp:ListItem>
            <asp:ListItem>Action</asp:ListItem>
            <asp:ListItem>Comedy</asp:ListItem>
            <asp:ListItem>Drama</asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator 
            ID="RequiredFieldValidator3" 
            runat="server" 
            ErrorMessage="Select a Genre" 
            ControlToValidate="genreDropDownList" 
            CssClass="column3" 
            SetFocusOnError="True" 
            Text="Required."
            InitialValue="none">
        </asp:RequiredFieldValidator>

        <asp:Label ID="Label4" runat="server" Text="Rating" CssClass="column1"></asp:Label>
        <asp:TextBox ID="ratingTextBox" runat="server" placeholder="1 to 10" CssClass="column2"></asp:TextBox>
        <asp:RangeValidator 
            ID="RangeValidator1" 
            runat="server" 
            ErrorMessage="RangeValidator" 
            MaximumValue="10" 
            MinimumValue="1" 
            SetFocusOnError="True" 
            ControlToValidate="ratingTextBox" 
            Type="Integer" 
            Text="Must be from 1 to 10."
            CssClass="column3"
            Display="Dynamic">
        </asp:RangeValidator>

        <asp:Button ID="addButton" runat="server" Text="Add" OnClick="addButton_Click" CssClass="column1"/>
        <asp:Button ID="Button1" runat="server" Text="Cancel" CssClass="column2" CausesValidation="False" />
    </div>
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        <asp:Literal ID="outputLiteral" runat="server"></asp:Literal>
    </form>
</body>
</html>
