<%@ Page Language="C#" Title="ReadData" AutoEventWireup="true" CodeBehind="ReadData.aspx.cs" MasterPageFile="~/Site.Master" Inherits="SampleAssessment.ReadData" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="background: -webkit-linear-gradient(left, #25c481, #25b7c4);
  background: linear-gradient(to right, #25c481, #25b7c4);width:100%;height:100vh" class="container-fluid" >
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" class="btn btn-success" OnClick="Button1_Click"/>
                  <div style="position:absolute;top:50%;left:50%;transform:translate(-50%,-50%)">
           <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="Movie_Id" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" >
               <AlternatingRowStyle BackColor="PaleGoldenrod" />
    <Columns>

        <asp:BoundField DataField="Movie_Name" HeaderText="Movie_Name" />
        <asp:BoundField DataField="Movie_Type" HeaderText="Movie_Type" />
        <asp:BoundField DataField="Movie_Language" HeaderText="Movie_Language" />
        <asp:BoundField DataField="Movie_Durations" HeaderText="Movie_Durations" />
        <asp:TemplateField HeaderText="Action">
            <ItemTemplate>
                <asp:LinkButton ID="lnkUpdate" runat="server" CommandArgument='<%# Eval("Movie_Id") %>' OnClick="lnkUpdate_Click" CssClass="btn btn-primary">Update</asp:LinkButton>
                <asp:LinkButton ID="lnkDelete" runat="server" CommandArgument='<%# Eval("Movie_Id") %>' OnClick="lnkDelete_Click" CssClass="btn btn-primary">Delete</asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>

    </Columns>
               <FooterStyle BackColor="Tan" />
               <HeaderStyle BackColor="Tan" Font-Bold="True" />
               <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
               <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
               <SortedAscendingCellStyle BackColor="#FAFAE7" />
               <SortedAscendingHeaderStyle BackColor="#DAC09E" />
               <SortedDescendingCellStyle BackColor="#E1DB9C" />
               <SortedDescendingHeaderStyle BackColor="#C2A47B" />
</asp:GridView>
      </div>
        </div>
      

    </div>
    </main>
</asp:Content>
