Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmMain
    Dim connectString As String = "workstation id=FinalASM.mssql.somee.com;packet size=4096;user id=binhdang_SQLLogin_2;pwd=ftkpkj6f94;data source=FinalASM.mssql.somee.com;persist security info=False;initial catalog=FinalASM"
    Dim connect As SqlConnection = New SqlConnection(connectString)

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = frmLogin.txtUsername.Text
        txtPassword.Enabled = False
        txtPassword.Text = frmLogin.txtPassword.Text
        lblWelcome.Text = "WELCOME " + lblUsername.Text.ToUpper + " TO SYSTEM."
        btnUsers.Enabled = False
    End Sub

    Private Sub chkChangePassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkChangePassword.CheckedChanged
        If chkChangePassword.Checked = False Then
            txtPassword.Enabled = False
        ElseIf chkChangePassword.Checked = True Then
            txtPassword.Enabled = True
        End If
    End Sub

    Private Sub btnSaveChange_Click(sender As Object, e As EventArgs) Handles btnSaveChange.Click

        Dim sqlQuery As String = "Update LOGIN set matkhau = @matkhau where taikhoan = @taikhoan"
        Dim command As New SqlCommand(sqlQuery, connect)
        If txtPassword.Text = "" Then
            errPro.SetError(txtPassword, "Please enter new password.")
        Else
            Try
                connect.Open()
                command.Parameters.AddWithValue("@taikhoan", lblUsername.Text)
                command.Parameters.AddWithValue("@matkhau", txtPassword.Text)
                command.ExecuteNonQuery()
                MessageBox.Show("Password changed !")
                connect.Close()
                chkChangePassword.Checked = False
            Catch exception As Exception
                MessageBox.Show("Something go wrong !" + exception.Message)
            End Try
            connect.Close()
        End If
    End Sub

#Region "menuStripEvent"
    Private Sub BackToHomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToHomeToolStripMenuItem.Click
        Me.Refresh()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        If frmCustomers.ShowInTaskbar = True Then
            Me.Hide()
            frmCustomers.Show()
        Else
            Me.Hide()
            frmCustomers.ShowDialog()
        End If
    End Sub

    Private Sub InvoicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoicesToolStripMenuItem.Click
        If frmInvoices.ShowInTaskbar = True Then
            Me.Hide()
            frmInvoices.Show()
        Else
            Me.Hide()
            frmInvoices.ShowDialog()
        End If
    End Sub

    Private Sub InvoicesDetailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoicesDetailToolStripMenuItem.Click
        If frmInvoicesDetail.ShowInTaskbar = True Then
            Me.Hide()
            frmInvoicesDetail.Show()
        Else
            Me.Hide()
            frmInvoicesDetail.ShowDialog()
        End If
    End Sub

    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click
        If frmProducts.ShowInTaskbar = True Then
            Me.Hide()
            frmProducts.Show()
        Else
            Me.Hide()
            frmProducts.ShowDialog()
        End If
    End Sub

    Private Sub CategoriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriesToolStripMenuItem.Click
        If frmCategories.ShowInTaskbar = True Then
            Me.Hide()
            frmCategories.Show()
        Else
            Me.Hide()
            frmCategories.ShowDialog()
        End If
    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        If frmUsers.ShowInTaskbar = True Then
            Me.Hide()
            frmUsers.Show()
        Else
            Me.Hide()
            frmUsers.ShowDialog()
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        If frmLogin.ShowInTaskbar = True Then
            Me.Hide()
            frmLogin.Show()
        Else
            Me.Hide()
            frmLogin.ShowDialog()
        End If
    End Sub
#End Region


#Region "buttonEvent"
    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        If frmCustomers.ShowInTaskbar = True Then
            Me.Hide()
            frmCustomers.Show()
        Else
            Me.Hide()
            frmCustomers.ShowDialog()
        End If
    End Sub

    Private Sub btnInvoices_Click(sender As Object, e As EventArgs) Handles btnInvoices.Click
        If frmInvoices.ShowInTaskbar = True Then
            Me.Hide()
            frmInvoices.Show()
        Else
            Me.Hide()
            frmInvoices.ShowDialog()
        End If
    End Sub

    Private Sub btnInvoicesDetail_Click(sender As Object, e As EventArgs) Handles btnInvoicesDetail.Click
        If frmInvoicesDetail.ShowInTaskbar = True Then
            Me.Hide()
            frmInvoicesDetail.Show()
        Else
            Me.Hide()
            frmInvoicesDetail.ShowDialog()
        End If
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        If frmProducts.ShowInTaskbar = True Then
            Me.Hide()
            frmProducts.Show()
        Else
            Me.Hide()
            frmProducts.ShowDialog()
        End If
    End Sub

    Private Sub btnCategories_Click(sender As Object, e As EventArgs) Handles btnCategories.Click
        If frmCategories.ShowInTaskbar = True Then
            Me.Hide()
            frmCategories.Show()
        Else
            Me.Hide()
            frmCategories.ShowDialog()
        End If
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        If frmUsers.ShowInTaskbar = True Then
            Me.Hide()
            frmUsers.Show()
        Else
            Me.Hide()
            frmUsers.ShowDialog()
        End If
    End Sub
#End Region

End Class