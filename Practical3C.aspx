<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical3C.aspx.cs" Inherits="C__Practical.Practical3C" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TreeView ID="TreeView1" runat="server" DataSourceID="XmlDataSource1">
                <DataBindings>
                    <asp:TreeNodeBinding DataMember="SID" ValueField="#InnerText" />
                    <asp:TreeNodeBinding DataMember="SName" ValueField="#InnerText" />
                    <asp:TreeNodeBinding DataMember="SClass" ValueField="#InnerText" />
                </DataBindings>
            </asp:TreeView>
            <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/Treeview(3C).xml"></asp:XmlDataSource>
        </div>
    </form>
</body>
</html>
