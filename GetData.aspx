<%@ Page Language="C#" Title="GetData" AutoEventWireup="true" CodeBehind="GetData.aspx.cs" MasterPageFile="~/Site.Master" Inherits="SampleAssessment.GetData" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">


        <div class="container bg-light">
            <!-- Start Header form -->
            <div class="text-center pt-1">
                <img src="https://i.ibb.co/8cDgdFX/Logo.png" alt="network-logo" width="72" height="72" />
                <h2>Meeting Room Booking Form</h2>
                <p>
                    Below is an example form built entirely with Bootstrap's form controls.
                </p>
                 <asp:Label ID="Label1" runat="server" Text="" class="text-bg-danger"></asp:Label>
            </div>
            <!-- End Header form -->

            <!-- Start Card -->
            <div class="card">
                <!-- Start Card Body -->
                <div class="card-body">
                    <!-- Start Form -->
                    <form id="bookingForm" action="#" method="" class="needs-validation" novalidate autocomplete="off">
                        <!-- Start Input Name -->
                        <%--<div class="form-group">
                            <label for="inputName">Name</label>
                            <asp:TextBox ID="TextBox1" runat="server" class="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please fill your name" ControlToValidate="TextBox1" class="form-text text-muted text-bg-danger"></asp:RequiredFieldValidator>



                        </div>--%>
                        <!-- End Input Name -->

                        <!-- Start Input Email -->
                        <div class="form-group">
                            <label for="inputEmail">Email</label>
                            <asp:TextBox ID="TextBox2" runat="server" class="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please fill your name" ControlToValidate="TextBox2" class="form-text text-muted text-bg-danger"></asp:RequiredFieldValidator>

                        </div>

                        <div class="form-group">
                            <label for="inputPhone">Phone</label>
                            <asp:TextBox ID="TextBox3" runat="server" class="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please fill your name" ControlToValidate="TextBox3" class="form-text text-muted text-bg-danger"></asp:RequiredFieldValidator>

                        </div>
                        <div class="form-group">
                            <label for="inputPhone">Phone</label>
                            <asp:TextBox ID="TextBox4" runat="server" class="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please fill your name" ControlToValidate="TextBox4" class="form-text text-muted text-bg-danger"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label for="inputPhone">Phone</label>
                            <asp:TextBox ID="TextBox5" runat="server" class="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please fill your name" ControlToValidate="TextBox5" class="form-text text-muted text-bg-danger"></asp:RequiredFieldValidator>


                        </div>



                        <asp:Button ID="Button1" runat="server" Text="Add" class="btn btn-primary btn-block col-lg-2" OnClick="Button1_Click" />
                        <!-- End Submit Button -->
                    </form>
                    <!-- End Form -->
                </div>
                <!-- End Card Body -->
            </div>
            <!-- End Card -->
            <footer>
                <div class="my-4 text-muted text-center">
                    <p>© My Company</p>
                </div>
            </footer>

            <!-- Optional JavaScript -->
            <!-- jQuery first, then Popper.js, then Bootstrap JS -->

            <!-- Start Scritp for Form -->

            <!-- End Scritp for Form -->

        </div>

    </main>
</asp:Content>


