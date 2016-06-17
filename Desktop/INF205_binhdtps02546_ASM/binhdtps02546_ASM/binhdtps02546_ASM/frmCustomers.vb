Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmCustomers
    Dim connectString As String = "workstation id=FinalASM.mssql.somee.com;packet size=4096;user id=binhdang_SQLLogin_2;pwd=ftkpkj6f94;data source=FinalASM.mssql.somee.com;persist security info=False;initial catalog=FinalASM"
    Dim connect As SqlConnection = New SqlConnection(connectString)
    Dim DB As New DataTable

    Private Sub frmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB.Clear()
        Dim sqlQuery As SqlDataAdapter = New SqlDataAdapter("select * from khachhang", connect)
        connect.Open()
        sqlQuery.Fill(DB)
        dgvData.DataSource = DB.DefaultView
        connect.Close()
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim sqlQuery As New SqlDataAdapter("Select * from khachhang where MaKH='" & txtCusID.Text & "' ", connect)
        Dim DB As New DataTable
        connect.Open()
        sqlQuery.Fill(DB)
        dgvData.DataSource = DB.DefaultView
        connect.Close()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim sqlQuery As String = "insert into khachhang values (@MaKH,@TenKH,@DiaChi,@SoDT,@Email)"
        Dim sqlCommand As New SqlCommand(sqlQuery, connect)

        If txtCusID.Text = "" Then
            errPro.SetError(txtCusID, "Please enter Customer ID !")
        ElseIf txtCusName.Text = "" Then
            errPro.SetError(txtCusName, "Please enter Customer name !")
        ElseIf txtCusAddress.Text = "" Then
            errPro.SetError(txtCusAddress, "Please enter Customer address !")
        ElseIf txtCusPhone.Text = "" Then
            errPro.SetError(txtCusPhone, "Please enter Customer phone !")
        ElseIf txtCusEmail.Text = "" Then
            errPro.SetError(txtCusEmail, "Please enter Customer email !")
        Else
            Try
                connect.Open()
                sqlCommand.Parameters.AddWithValue("@MaKH", txtCusID.Text)
                sqlCommand.Parameters.AddWithValue("@TenKH", txtCusName.Text)
                sqlCommand.Parameters.AddWithValue("@DiaChi", txtCusAddress.Text)
                sqlCommand.Parameters.AddWithValue("@SoDT", txtCusPhone.Text)
                sqlCommand.Parameters.AddWithValue("@Email", txtCusEmail.Text)
                sqlCommand.ExecuteNonQuery()
                connect.Close()
                MessageBox.Show("Add Successful !", "Success !", MessageBoxButtons.OK)
            Catch ex As Exception
                MessageBox.Show("Add Failed !" + ex.Message, "Add Failed !", MessageBoxButtons.OK, MessageBoxIcon.Error)
                connect.Close()
            End Try
        End If
        connect.Close()
        DB.Clear()
        dgvData.DataSource = DB
        Loaddata()
        infoClear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim sqlQuery As String = "Update khachhang set TenKH = @TenKH, DiaChi = @DiaChi, SoDT = @SoDT, Email = @Email where MaKH = @MaKH"
        Dim sqlCommand As New SqlCommand(sqlQuery, connect)

        If txtCusID.Text = "" Then
            errPro.SetError(txtCusID, "Please enter Customer ID !")
        ElseIf txtCusName.Text = "" Then
            errPro.SetError(txtCusName, "Please enter Customer name !")
        ElseIf txtCusAddress.Text = "" Then
            errPro.SetError(txtCusAddress, "Please enter Customer address !")
        ElseIf txtCusPhone.Text = "" Then
            errPro.SetError(txtCusPhone, "Please enter Customer phone !")
        ElseIf txtCusEmail.Text = "" Then
            errPro.SetError(txtCusEmail, "Please enter Customer email !")
        Else
            Try
                connect.Open()
                sqlCommand.Parameters.AddWithValue("@MaKH", txtCusID.Text)
                SqlCommand.Parameters.AddWithValue("@TenKH", txtCusName.Text)
                SqlCommand.Parameters.AddWithValue("@DiaChi", txtCusAddress.Text)
                SqlCommand.Parameters.AddWithValue("@SoDT", txtCusPhone.Text)
                SqlCommand.Parameters.AddWithValue("@Email", txtCusEmail.Text)
                SqlCommand.ExecuteNonQuery()
                connect.Close()
                MessageBox.Show("Update Successful !", "Success !", MessageBoxButtons.OK)
            Catch ex As Exception
                MessageBox.Show("Update Failed !", "Add Failed !", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            connect.Close()
        End If
        DB.Clear()
        dgvData.DataSource = DB
        Loaddata()
        infoClear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim sqlQuery As String = "Delete from khachhang Where MaKH = @MaKH"
        Dim command As New SqlCommand(sqlQuery, connect)
        If (txtCusID.Text = "") Then
            errPro.SetError(txtCusID, "Error ! Customer ID can't be Null !")
        Else
            Try
                connect.Open()
                command.Parameters.AddWithValue("@MaKH", txtCusID.Text)
                command.ExecuteNonQuery()
                connect.Close()
                MessageBox.Show("Delete Successful !", "Success !", MessageBoxButtons.OK)
            Catch ex As Exception
                MessageBox.Show("Can't be Delete!", "Delete Failed !", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            connect.Close()
        End If
        DB.Clear()
        dgvData.DataSource = DB
        dgvData.DataSource = Nothing
        Loaddata()
        infoClear()
    End Sub

    Private Sub Loaddata()
        Dim RefeshDB As SqlDataAdapter = New SqlDataAdapter("select * from khachhang", connect)
        connect.Open()
        RefeshDB.Fill(DB)
        dgvData.DataSource = DB.DefaultView
        connect.Close()
    End Sub

    Private Sub infoClear()
        txtCusID.Clear()
        txtCusName.Clear()
        txtCusAddress.Clear()
        txtCusPhone.Clear()
        txtCusEmail.Clear()
    End Sub

#Region "menuStripEvent"
    Private Sub BackToHomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToHomeToolStripMenuItem.Click
        If frmMain.ShowInTaskbar = True Then
            Me.Hide()
            frmMain.Show()
        Else
            Me.Hide()
            frmMain.ShowDialog()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        Me.Refresh()
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


End Class