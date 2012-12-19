<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VælgSpørgeskema.aspx.cs" Inherits="Website.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">

        .style3
        {
            width: 625px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Vælg et spørgeskema</h2>
    <p>
        <table>
            <tr>
                <td>
                    <asp:DropDownList ID="DDSpørgeskema" runat="server" Width="192px">
                        <asp:ListItem>Spørgeskema 1</asp:ListItem>
                        <asp:ListItem>Spørgeskema 2</asp:ListItem>
                        <asp:ListItem>Spørgeskema 3</asp:ListItem>
                        <asp:ListItem>Spørgeskema 4</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnVælgSpørgeskema" runat="server" 
                        onclick="btnVælgSpørgeskema_Click" style="margin-left: 56px" 
                        Text="Vælg Spørgeskema" Width="137px" />
                </td>
            </tr>
        </table>
    </p>
    <h3>
        Skema:
    </h3>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Spørgsmål 1" Visible="False"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="txt1" runat="server" Height="80px" 
                    style="margin-left: 98px; margin-bottom: 0px" TextMode="MultiLine" 
                    Visible="False" Width="353px"></asp:TextBox>
                <asp:DropDownList ID="DropDownList1" runat="server" Height="35px" 
                    style="margin-left: 98px" Visible="False" Width="207px">
                    <asp:ListItem>Svar 1</asp:ListItem>
                    <asp:ListItem>Svar 2</asp:ListItem>
                    <asp:ListItem>Svar 3</asp:ListItem>
                </asp:DropDownList>
                <asp:CheckBoxList ID="CheckBoxList1" runat="server" style="margin-left: 98px" 
                    Visible="False">
                    <asp:ListItem>Svar 1</asp:ListItem>
                    <asp:ListItem>Svar 2</asp:ListItem>
                    <asp:ListItem>Svar 3</asp:ListItem>
                    <asp:ListItem>Svar 4</asp:ListItem>
                    <asp:ListItem>Svar 5</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Spørgsmål 2" Visible="False"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="txt2" runat="server" Height="80px" 
                    style="margin-left: 98px; margin-bottom: 0px" TextMode="MultiLine" 
                    Visible="False" Width="353px"></asp:TextBox>
                <asp:DropDownList ID="DropDownList2" runat="server" Height="35px" 
                    style="margin-left: 98px" Visible="False" Width="207px">
                    <asp:ListItem>Svar 1</asp:ListItem>
                    <asp:ListItem>Svar 2</asp:ListItem>
                    <asp:ListItem>Svar 3</asp:ListItem>
                </asp:DropDownList>
                <asp:CheckBoxList ID="CheckBoxList2" runat="server" style="margin-left: 98px" 
                    Visible="False">
                    <asp:ListItem>Svar 1</asp:ListItem>
                    <asp:ListItem>Svar 2</asp:ListItem>
                    <asp:ListItem>Svar 3</asp:ListItem>
                    <asp:ListItem>Svar 4</asp:ListItem>
                    <asp:ListItem>Svar 5</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Spørgsmål 3" Visible="False"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="txt3" runat="server" Height="80px" 
                    style="margin-left: 98px; margin-bottom: 0px" TextMode="MultiLine" 
                    Visible="False" Width="353px"></asp:TextBox>
                <asp:DropDownList ID="DropDownList3" runat="server" Height="35px" 
                    style="margin-left: 98px" Visible="False" Width="207px">
                    <asp:ListItem>Svar 1</asp:ListItem>
                    <asp:ListItem>Svar 2</asp:ListItem>
                    <asp:ListItem>Svar 3</asp:ListItem>
                </asp:DropDownList>
                <asp:CheckBoxList ID="CheckBoxList3" runat="server" style="margin-left: 98px" 
                    Visible="False">
                    <asp:ListItem>Svar 1</asp:ListItem>
                    <asp:ListItem>Svar 2</asp:ListItem>
                    <asp:ListItem>Svar 3</asp:ListItem>
                    <asp:ListItem>Svar 4</asp:ListItem>
                    <asp:ListItem>Svar 5</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Spørgsmål 4" Visible="False"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="txt4" runat="server" Height="80px" 
                    style="margin-left: 98px; margin-bottom: 0px" TextMode="MultiLine" 
                    Visible="False" Width="353px"></asp:TextBox>
                <asp:DropDownList ID="DropDownList4" runat="server" Height="35px" 
                    style="margin-left: 98px" Visible="False" Width="207px">
                    <asp:ListItem>Svar 1</asp:ListItem>
                    <asp:ListItem>Svar 2</asp:ListItem>
                    <asp:ListItem>Svar 3</asp:ListItem>
                </asp:DropDownList>
                <asp:CheckBoxList ID="CheckBoxList4" runat="server" style="margin-left: 98px" 
                    Visible="False">
                    <asp:ListItem>Svar 1</asp:ListItem>
                    <asp:ListItem>Svar 2</asp:ListItem>
                    <asp:ListItem>Svar 3</asp:ListItem>
                    <asp:ListItem>Svar 4</asp:ListItem>
                    <asp:ListItem>Svar 5</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Spørgsmål 5" Visible="False"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="txt5" runat="server" Height="80px" 
                    style="margin-left: 98px; margin-bottom: 0px" TextMode="MultiLine" 
                    Visible="False" Width="353px"></asp:TextBox>
                <asp:DropDownList ID="DropDownList5" runat="server" Height="35px" 
                    style="margin-left: 98px" Visible="False" Width="207px">
                    <asp:ListItem>Svar 1</asp:ListItem>
                    <asp:ListItem>Svar 2</asp:ListItem>
                    <asp:ListItem>Svar 3</asp:ListItem>
                </asp:DropDownList>
                <asp:CheckBoxList ID="CheckBoxList5" runat="server" style="margin-left: 98px" 
                    Visible="False">
                    <asp:ListItem>Svar 1</asp:ListItem>
                    <asp:ListItem>Svar 2</asp:ListItem>
                    <asp:ListItem>Svar 3</asp:ListItem>
                    <asp:ListItem>Svar 4</asp:ListItem>
                    <asp:ListItem>Svar 5</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Spørgsmål 6" Visible="False"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="txt6" runat="server" Height="80px" 
                    style="margin-left: 98px; margin-bottom: 0px" TextMode="MultiLine" 
                    Visible="False" Width="353px"></asp:TextBox>
                <asp:DropDownList ID="DropDownList6" runat="server" Height="35px" 
                    style="margin-left: 98px" Visible="False" Width="207px">
                    <asp:ListItem>Svar 1</asp:ListItem>
                    <asp:ListItem>Svar 2</asp:ListItem>
                    <asp:ListItem>Svar 3</asp:ListItem>
                </asp:DropDownList>
                <asp:CheckBoxList ID="CheckBoxList6" runat="server" style="margin-left: 98px" 
                    Visible="False">
                    <asp:ListItem>Svar 1</asp:ListItem>
                    <asp:ListItem>Svar 2</asp:ListItem>
                    <asp:ListItem>Svar 3</asp:ListItem>
                    <asp:ListItem>Svar 4</asp:ListItem>
                    <asp:ListItem>Svar 5</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Spørgsmål 7" Visible="False"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="txt7" runat="server" Height="80px" 
                    style="margin-left: 98px; margin-bottom: 0px" TextMode="MultiLine" 
                    Visible="False" Width="353px"></asp:TextBox>
                <asp:DropDownList ID="DropDownList7" runat="server" Height="35px" 
                    style="margin-left: 98px" Visible="False" Width="207px">
                    <asp:ListItem>Svar 1</asp:ListItem>
                    <asp:ListItem>Svar 2</asp:ListItem>
                    <asp:ListItem>Svar 3</asp:ListItem>
                </asp:DropDownList>
                <asp:CheckBoxList ID="CheckBoxList7" runat="server" style="margin-left: 98px" 
                    Visible="False">
                    <asp:ListItem>Svar 1</asp:ListItem>
                    <asp:ListItem>Svar 2</asp:ListItem>
                    <asp:ListItem>Svar 3</asp:ListItem>
                    <asp:ListItem>Svar 4</asp:ListItem>
                    <asp:ListItem>Svar 5</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Spørgsmål 8" Visible="False"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="txt8" runat="server" Height="80px" 
                    style="margin-left: 98px; margin-bottom: 0px" TextMode="MultiLine" 
                    Visible="False" Width="353px"></asp:TextBox>
                <asp:DropDownList ID="DropDownList8" runat="server" Height="35px" 
                    style="margin-left: 98px" Visible="False" Width="207px">
                    <asp:ListItem>Svar 1</asp:ListItem>
                    <asp:ListItem>Svar 2</asp:ListItem>
                    <asp:ListItem>Svar 3</asp:ListItem>
                </asp:DropDownList>
                <asp:CheckBoxList ID="CheckBoxList8" runat="server" style="margin-left: 98px" 
                    Visible="False">
                    <asp:ListItem>Svar 1</asp:ListItem>
                    <asp:ListItem>Svar 2</asp:ListItem>
                    <asp:ListItem>Svar 3</asp:ListItem>
                    <asp:ListItem>Svar 4</asp:ListItem>
                    <asp:ListItem>Svar 5</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Spørgsmål 9" Visible="False"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="txt9" runat="server" Height="80px" 
                    style="margin-left: 98px; margin-bottom: 0px" TextMode="MultiLine" 
                    Visible="False" Width="353px"></asp:TextBox>
                <asp:DropDownList ID="DropDownList9" runat="server" Height="35px" 
                    style="margin-left: 98px" Visible="False" Width="207px">
                    <asp:ListItem>Svar 1</asp:ListItem>
                    <asp:ListItem>Svar 2</asp:ListItem>
                    <asp:ListItem>Svar 3</asp:ListItem>
                </asp:DropDownList>
                <asp:CheckBoxList ID="CheckBoxList9" runat="server" style="margin-left: 98px" 
                    Visible="False">
                    <asp:ListItem>Svar 1</asp:ListItem>
                    <asp:ListItem>Svar 2</asp:ListItem>
                    <asp:ListItem>Svar 3</asp:ListItem>
                    <asp:ListItem>Svar 4</asp:ListItem>
                    <asp:ListItem>Svar 5</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Spørgsmål 10" Visible="False"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="txt10" runat="server" Height="80px" 
                    style="margin-left: 98px; margin-bottom: 0px" TextMode="MultiLine" 
                    Visible="False" Width="353px"></asp:TextBox>
                <asp:DropDownList ID="DropDownList10" runat="server" Height="35px" 
                    style="margin-left: 98px" Visible="False" Width="207px">
                    <asp:ListItem>Svar 1</asp:ListItem>
                    <asp:ListItem>Svar 2</asp:ListItem>
                    <asp:ListItem>Svar 3</asp:ListItem>
                </asp:DropDownList>
                <asp:CheckBoxList ID="CheckBoxList10" runat="server" style="margin-left: 98px" 
                    Visible="False">
                    <asp:ListItem>Svar 1</asp:ListItem>
                    <asp:ListItem>Svar 2</asp:ListItem>
                    <asp:ListItem>Svar 3</asp:ListItem>
                    <asp:ListItem>Svar 4</asp:ListItem>
                    <asp:ListItem>Svar 5</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
    </table>
    <p>
        &nbsp;</p>
</asp:Content>
