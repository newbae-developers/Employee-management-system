Imports MySql.Data.MySqlClient

Public Class Form1
    Private rdr As Object

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles username11.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Login_btn_Click(sender As Object, e As EventArgs) Handles Login_btn.Click
        Dim constr = "Server=localhost;uid=root;database=user_databasefor_login_form"
        Dim SQL = "Select * FROM login WHERE username1 = @username and password1 =@password"

        Using dbcon As New MySqlConnection(constr)
            Using Cmd As New MySqlCommand(SQL, dbcon)
                dbcon.Open()
                Cmd.Parameters.Add(New MySqlParameter("@username", username11.Text))
                Cmd.Parameters.Add(New MySqlParameter("@password", password11.Text))
                Using rdr = Cmd.ExecuteReader
                    If rdr.HasRows Then
                        MessageBox.Show("Login Successful")
                        Form2.Show()
                    Else
                        MessageBox.Show("Username and password not found")
                    End If

                End Using
                dbcon.Close()
            End Using

        End Using

    End Sub

    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles password11.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBoxclose.Click
        Me.Close()
    End Sub
End Class
