Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmInvoicesDetail
    Dim connectString As String = "workstation id=FinalASM.mssql.somee.com;packet size=4096;user id=binhdang_SQLLogin_2;pwd=ftkpkj6f94;data source=FinalASM.mssql.somee.com;persist security info=False;initial catalog=FinalASM"
    Dim connect As SqlConnection = New SqlConnection(connectString)
    Dim DB As New DataTable

    Private Sub frmInvoicesDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB.Clear()
        Dim sqlQuery As SqlDataAdapter = New SqlDataAdapter("select * from chitiethoadon", connect)
        connect.Open()
        sqlQuery.Fill(DB)
        dgvData.DataSource = DB.DefaultView
        connect.Close()
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim sqlQuery As New SqlDataAdapter("Select * from chitiethoadon where MaHD='" & txtInvoiceID.Text & "' ", connect)
        Dim DB As New DataTable
        connect.Open()
        sqlQuery.Fill(DB)
        dgvData.DataSource = DB.DefaultView
        connect.Close()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim sqlQuery As String = "insert into chitiethoadon values (@MaHD,@MaSP)"
        Dim sqlCommand As New SqlCommand(sqlQuery, connect)

        If txtInvoiceID.Text = "" Then
            errPro.SetError(txtInvoiceID, "Please enter Invoice ID !")
        ElseIf txtProductId.Text = "" Then
            errPro.SetError(txtProductId, "Please enter Product ID !")
        Else
            Try
                connect.Open()
                sqlCommand.Parameters.AddWithValue("@MaHD", txtInvoiceID.Text)
                sqlCommand.Parameters.AddWithValue("@MaSp", txtProductId.Text)
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
        Dim sqlQuery As String = "Update chitiethoadon set MaSP = @MaSP where MaHD = @MaHD"
        Dim sqlCommand As New SqlCommand(sqlQuery, connect)

        If txtInvoiceID.Text = "" Then
            errPro.SetError(txtInvoiceID, "Please enter Invoice ID !")
        ElseIf txtProductId.Text = "" Then
            errPro.SetError(txtProductId, "Please enter Product ID !")
        Else
            Try
                connect.Open()
                sqlCommand.Parameters.AddWithValue("@MaHD", txtInvoiceID.Text)
                sqlCommand.Parameters.AddWithValue("@MaSP", txtProductId.Text)
                sqlCommand.ExecuteNonQuery()
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
        Dim sqlQuery As String = "Delete from chitiethoadon Where MaHD = @MaHD"
        Dim command As New SqlCommand(sqlQuery, connect)
        If (txtInvoiceID.Text = "") Then
            errPro.SetError(txtInvoiceID, "Error ! Invoice ID can't be Null !")
        Else
            Try
                connect.Open()
                command.Parameters.AddWithValue("@MaHD", txtInvoiceID.Text)
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
        Dim RefeshDB As SqlDataAdapter = New SqlDataAdapter("select * from chitiethoadon", connect)
        connect.Open()
        RefeshDB.Fill(DB)
        dgvData.DataSource = DB.DefaultView
        connect.Close()
    End Sub

    Private Sub infoClear()
        txtInvoiceID.Clear()
        txtProductId.Clear()
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
        Me.Refresh()
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