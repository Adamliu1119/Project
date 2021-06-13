<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="terminal.aspx.cs" Inherits="WebApplication1.terminal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style=" overflow-x:hidden;overflow-y:hidden; margin:0;">
    <form id="form1" runat="server" >
        <div style="width:2000px;height:1210px;background-image: url('Resources/background_1.jpg'); background-repeat:no-repeat; text-align:center;">
            <asp:ScriptManager runat="server" />
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                     <div>
                        <asp:ImageButton ID="ImageButton1" runat="server"  Height="200px" Width="140px" ImageUrl="~/Resources/onback.png" OnClick="ImageButton1_Click" />
                        <asp:ImageButton ID="ImageButton2" runat="server"   ImageUrl="~/Resources/onback.png" Height="200px" Width="140px" OnClick="ImageButton2_Click"/>
                        <asp:ImageButton ID="ImageButton3" runat="server"  ImageUrl="~/Resources/onback.png" Height="200px" Width="140px" OnClick="ImageButton3_Click"/>
                        <asp:ImageButton ID="ImageButton4" runat="server"  ImageUrl="~/Resources/onback.png" Height="200px" Width="140px" OnClick="ImageButton4_Click"/>
                    </div>
                    <div>
                        <asp:ImageButton ID="ImageButton5" runat="server"  ImageUrl="~/Resources/onback.png" Height="200px" Width="140px" OnClick="ImageButton5_Click"/>
                        <asp:ImageButton ID="ImageButton6" runat="server"  ImageUrl="~/Resources/onback.png" Height="200px" Width="140px" OnClick="ImageButton6_Click"/>
                        <asp:ImageButton ID="ImageButton7" runat="server"  ImageUrl="~/Resources/onback.png" Height="200px" Width="140px" OnClick="ImageButton7_Click"/>
                        <asp:ImageButton ID="ImageButton8" runat="server"  ImageUrl="~/Resources/onback.png" Height="200px" Width="140px" OnClick="ImageButton8_Click"/>
                    </div>
                    <div>
                        <asp:ImageButton ID="ImageButton9" runat="server"  ImageUrl="~/Resources/onback.png" Height="200px" Width="140px" OnClick="ImageButton9_Click"/>
                        <asp:ImageButton ID="ImageButton10" runat="server"  ImageUrl="~/Resources/onback.png" Height="200px" Width="140px" OnClick="ImageButton10_Click"/>
                        <asp:ImageButton ID="ImageButton11" runat="server"  ImageUrl="~/Resources/onback.png" Height="200px" Width="140px" OnClick="ImageButton11_Click"/>
                        <asp:ImageButton ID="ImageButton12" runat="server"  ImageUrl="~/Resources/onback.png" Height="200px" Width="140px" OnClick="ImageButton12_Click"/>
                    </div>
                    <div style="margin-bottom:10px;">
                        <asp:ImageButton ID="ImageButton13" runat="server"  ImageUrl="~/Resources/onback.png" Height="200px" Width="140px" OnClick="ImageButton13_Click"/>
                        <asp:ImageButton ID="ImageButton14" runat="server"  ImageUrl="~/Resources/onback.png" Height="200px" Width="140px" OnClick="ImageButton14_Click"/>
                        <asp:ImageButton ID="ImageButton15" runat="server"  ImageUrl="~/Resources/onback.png" Height="200px" Width="140px" OnClick="ImageButton15_Click"/>
                        <asp:ImageButton ID="ImageButton16" runat="server"  ImageUrl="~/Resources/onback.png" Height="200px" Width="140px" OnClick="ImageButton16_Click"/>
                    </div>
                    <asp:Button ID="btn_Ran" runat="server" Text="開始" OnClick="btn_Ran_Click" Height="50px" Width="100px" BackColor="#000099" ForeColor="White" /><br/>
                    <asp:Timer ID="Timer1" runat="server" OnTick="Timer1_Tick" Enabled="False" Interval="1000"></asp:Timer>
                    <asp:Label ID="Label1" runat="server" Text="0" ForeColor="White" Font-Size="30px"></asp:Label>
                    <asp:Label ID="Label2" runat="server" Text="  Length:" Font-Size="30px" ForeColor="White"></asp:Label>
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
