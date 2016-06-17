<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToHomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoicesDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpFAQToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grbUserInfor = New System.Windows.Forms.GroupBox()
        Me.chkChangePassword = New System.Windows.Forms.CheckBox()
        Me.btnSaveChange = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grbManage = New System.Windows.Forms.GroupBox()
        Me.btnCategories = New System.Windows.Forms.Button()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnInvoicesDetail = New System.Windows.Forms.Button()
        Me.btnInvoices = New System.Windows.Forms.Button()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.errPro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.grbUserInfor.SuspendLayout()
        Me.grbManage.SuspendLayout()
        CType(Me.errPro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.ManageToolStripMenuItem, Me.HelpToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(600, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToHomeToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'BackToHomeToolStripMenuItem
        '
        Me.BackToHomeToolStripMenuItem.Name = "BackToHomeToolStripMenuItem"
        Me.BackToHomeToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.BackToHomeToolStripMenuItem.Text = "Back to home"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ManageToolStripMenuItem
        '
        Me.ManageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomersToolStripMenuItem, Me.InvoicesToolStripMenuItem, Me.InvoicesDetailToolStripMenuItem, Me.ProductsToolStripMenuItem, Me.CategoriesToolStripMenuItem, Me.UsersToolStripMenuItem})
        Me.ManageToolStripMenuItem.Name = "ManageToolStripMenuItem"
        Me.ManageToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.ManageToolStripMenuItem.Text = "Manage"
        '
        'CustomersToolStripMenuItem
        '
        Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.CustomersToolStripMenuItem.Text = "Customers"
        '
        'InvoicesToolStripMenuItem
        '
        Me.InvoicesToolStripMenuItem.Name = "InvoicesToolStripMenuItem"
        Me.InvoicesToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.InvoicesToolStripMenuItem.Text = "Invoices"
        '
        'InvoicesDetailToolStripMenuItem
        '
        Me.InvoicesDetailToolStripMenuItem.Name = "InvoicesDetailToolStripMenuItem"
        Me.InvoicesDetailToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.InvoicesDetailToolStripMenuItem.Text = "Invoices Detail"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ProductsToolStripMenuItem.Text = "Products"
        '
        'CategoriesToolStripMenuItem
        '
        Me.CategoriesToolStripMenuItem.Name = "CategoriesToolStripMenuItem"
        Me.CategoriesToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.CategoriesToolStripMenuItem.Text = "Categories"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpFAQToolStripMenuItem, Me.ContactUsToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HelpFAQToolStripMenuItem
        '
        Me.HelpFAQToolStripMenuItem.Name = "HelpFAQToolStripMenuItem"
        Me.HelpFAQToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.HelpFAQToolStripMenuItem.Text = "Help/FAQ"
        '
        'ContactUsToolStripMenuItem
        '
        Me.ContactUsToolStripMenuItem.Name = "ContactUsToolStripMenuItem"
        Me.ContactUsToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.ContactUsToolStripMenuItem.Text = "Contact Us"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'grbUserInfor
        '
        Me.grbUserInfor.Controls.Add(Me.chkChangePassword)
        Me.grbUserInfor.Controls.Add(Me.btnSaveChange)
        Me.grbUserInfor.Controls.Add(Me.lblUsername)
        Me.grbUserInfor.Controls.Add(Me.txtPassword)
        Me.grbUserInfor.Controls.Add(Me.Label2)
        Me.grbUserInfor.Controls.Add(Me.Label1)
        Me.grbUserInfor.Location = New System.Drawing.Point(12, 27)
        Me.grbUserInfor.Name = "grbUserInfor"
        Me.grbUserInfor.Size = New System.Drawing.Size(206, 194)
        Me.grbUserInfor.TabIndex = 1
        Me.grbUserInfor.TabStop = False
        Me.grbUserInfor.Text = "User Infomation"
        '
        'chkChangePassword
        '
        Me.chkChangePassword.AutoSize = True
        Me.chkChangePassword.Location = New System.Drawing.Point(6, 114)
        Me.chkChangePassword.Name = "chkChangePassword"
        Me.chkChangePassword.Size = New System.Drawing.Size(136, 21)
        Me.chkChangePassword.TabIndex = 4
        Me.chkChangePassword.Text = "Change password."
        Me.chkChangePassword.UseVisualStyleBackColor = True
        '
        'btnSaveChange
        '
        Me.btnSaveChange.Location = New System.Drawing.Point(6, 141)
        Me.btnSaveChange.Name = "btnSaveChange"
        Me.btnSaveChange.Size = New System.Drawing.Size(177, 33)
        Me.btnSaveChange.TabIndex = 3
        Me.btnSaveChange.Text = "Save Change"
        Me.btnSaveChange.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.Location = New System.Drawing.Point(84, 34)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(99, 21)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Admin"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(6, 83)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(177, 25)
        Me.txtPassword.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'grbManage
        '
        Me.grbManage.Controls.Add(Me.btnCategories)
        Me.grbManage.Controls.Add(Me.btnProducts)
        Me.grbManage.Controls.Add(Me.btnUsers)
        Me.grbManage.Controls.Add(Me.btnInvoicesDetail)
        Me.grbManage.Controls.Add(Me.btnInvoices)
        Me.grbManage.Controls.Add(Me.btnCustomers)
        Me.grbManage.Location = New System.Drawing.Point(224, 65)
        Me.grbManage.Name = "grbManage"
        Me.grbManage.Size = New System.Drawing.Size(364, 156)
        Me.grbManage.TabIndex = 2
        Me.grbManage.TabStop = False
        Me.grbManage.Text = "Manage"
        '
        'btnCategories
        '
        Me.btnCategories.Location = New System.Drawing.Point(120, 86)
        Me.btnCategories.Name = "btnCategories"
        Me.btnCategories.Size = New System.Drawing.Size(108, 56)
        Me.btnCategories.TabIndex = 0
        Me.btnCategories.Text = "Categories"
        Me.btnCategories.UseVisualStyleBackColor = True
        '
        'btnProducts
        '
        Me.btnProducts.Location = New System.Drawing.Point(6, 86)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(108, 56)
        Me.btnProducts.TabIndex = 0
        Me.btnProducts.Text = "Products"
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'btnUsers
        '
        Me.btnUsers.Location = New System.Drawing.Point(234, 86)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(108, 56)
        Me.btnUsers.TabIndex = 0
        Me.btnUsers.Text = "Users"
        Me.btnUsers.UseVisualStyleBackColor = True
        '
        'btnInvoicesDetail
        '
        Me.btnInvoicesDetail.Location = New System.Drawing.Point(234, 24)
        Me.btnInvoicesDetail.Name = "btnInvoicesDetail"
        Me.btnInvoicesDetail.Size = New System.Drawing.Size(108, 56)
        Me.btnInvoicesDetail.TabIndex = 0
        Me.btnInvoicesDetail.Text = "Invoices Detail"
        Me.btnInvoicesDetail.UseVisualStyleBackColor = True
        '
        'btnInvoices
        '
        Me.btnInvoices.Location = New System.Drawing.Point(120, 24)
        Me.btnInvoices.Name = "btnInvoices"
        Me.btnInvoices.Size = New System.Drawing.Size(108, 56)
        Me.btnInvoices.TabIndex = 0
        Me.btnInvoices.Text = "Invoices"
        Me.btnInvoices.UseVisualStyleBackColor = True
        '
        'btnCustomers
        '
        Me.btnCustomers.Location = New System.Drawing.Point(6, 24)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(108, 56)
        Me.btnCustomers.TabIndex = 0
        Me.btnCustomers.Text = "Customers"
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'errPro
        '
        Me.errPro.ContainerControl = Me
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblWelcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWelcome.Location = New System.Drawing.Point(224, 36)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(364, 26)
        Me.lblWelcome.TabIndex = 3
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 232)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.grbManage)
        Me.Controls.Add(Me.grbUserInfor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grbUserInfor.ResumeLayout(False)
        Me.grbUserInfor.PerformLayout()
        Me.grbManage.ResumeLayout(False)
        CType(Me.errPro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvoicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvoicesDetailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpFAQToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grbUserInfor As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grbManage As GroupBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkChangePassword As CheckBox
    Friend WithEvents btnSaveChange As Button
    Friend WithEvents btnCategories As Button
    Friend WithEvents btnProducts As Button
    Friend WithEvents btnInvoicesDetail As Button
    Friend WithEvents btnInvoices As Button
    Friend WithEvents btnCustomers As Button
    Friend WithEvents errPro As ErrorProvider
    Friend WithEvents btnUsers As Button
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblWelcome As Label
    Friend WithEvents BackToHomeToolStripMenuItem As ToolStripMenuItem
End Class
