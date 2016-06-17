Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmLogin
    Dim connectString As String = "workstation id=FinalASM.mssql.somee.com;packet size=4096;user id=binhdang_SQLLogin_2;pwd=ftkpkj6f94;data source=FinalASM.mssql.somee.com;persist security info=False;initial catalog=FinalASM"
    Dim connect As SqlConnection = New SqlConnection(connectString)

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmWelcome.ShowDialog()
    End Sub

    Private Sub currentTime_Tick(sender As Object, e As EventArgs) Handles currentTime.Tick
        lblcurrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim DB As New DataTable
        Dim LoginsqlAdapter As New SqlDataAdapter("Select taikhoan, matkhau from LOGIN where taikhoan='" & txtUsername.Text & "' and matkhau='" & txtPassword.Text & "' ", connect)
        If txtUsername.Text.Trim = "" Then
            errPro.SetError(txtUsername, "Please enter Username.")
        ElseIf txtPassword.Text.Trim = "" Then
            errPro.SetError(txtPassword, "Please enter Password.")
        Else
            Try
                connect.Open()
                LoginsqlAdapter.Fill(DB)
                If DB.Rows.Count > 0 Then
                    MessageBox.Show("Login successfull ! Welcome !")
                    Me.Hide()
                    frmMain.ShowDialog()
                Else
                    MessageBox.Show("Wrong Username Or Password ! Make sure your Login Information is correct !", "Login Fail !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                connect.Close()
            Catch exception As Exception
                MessageBox.Show("Login Fail ! " + exception.Message, "Login Fail !", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            connect.Close()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class