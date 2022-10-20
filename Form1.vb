Imports System.Data
Imports System.Data.SqlClient


Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblUserName.Click

    End Sub



    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        '  Dim mypass As Password = New Password


        Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-53UNUI6G;Initial Catalog=FMA;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("SELECT sec_user_name, 
                                sec_password FROM security 
                                WHERE sec_user_name='" + txtUserName.Text + "' AND sec_password='" + Decrypt(txtPassword.Text) + "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        '   MessageBox.Show(Decrypt(txtPassword.Text), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        sda.Fill(dt)

        If (dt.Rows.Count > 0) Then
            MessageBox.Show("Login Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form2.Show()


        Else
            MessageBox.Show("Error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Public Function Encrypt(ByVal CodeString As String) As String
        Dim perchar As String
        Dim ascii As String
        Dim pass As String

        For x = 0 To Len(CodeString) - 1
            perchar = CodeString.Chars(x)
            ascii = Asc(perchar) + 2
            pass += Chr(ascii)


        Next
        Encrypt = pass
    End Function

    Public Function Decrypt(ByVal CodeString As String) As String
        Dim perchar As String ' weds pass encrypt ygfu
        Dim ascii As String
        Dim pass As String

        For x = 0 To Len(CodeString) - 1
            perchar = CodeString.Chars(x)
            ascii = Asc(perchar) + 2
            pass += Chr(ascii)


        Next
        Decrypt = pass
    End Function

End Class
