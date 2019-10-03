Imports MySql.Data.MySqlClient
Public Class add_account
    Dim query As String
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim ds As DataSet


    Private Sub cmdaccreg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaccreg.Click
        cmd = New MySqlCommand(query, connection.con)
        connection.con.Open()

        query = "INSERT INTO tbl_account(account_reg_no,username,password,level)VALUES('"
        query = query + txtacccode.Text + "','" + txtuser.Text + "','" + txtpass.Text + "','" + cmblevel.Text + "')"

        cmd = New MySqlCommand(query, connection.con)

        Dim i As Integer = cmd.ExecuteNonQuery()
        MsgBox("Successful!", MsgBoxStyle.Information)
        connection.con.Close()

        txtacccode.Text = ""
        txtuser.Text = ""
        txtpass.Text = ""
        cmblevel.Text = ""

        loadaccountrec()
    End Sub
    Private Sub loadaccountrec()
        Dim sql As MySqlCommand = New MySqlCommand("SELECT * from tbl_account", connection.con)
        da = New MySqlDataAdapter()
        ds = New DataSet

        da.SelectCommand = sql

        da.Fill(ds, "rec")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "rec"
        connection.con.Close()
    End Sub

    Private Sub add_account_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadaccountrec()
        txtacccode.Text = DateTime.Now.ToString("ddMM-yyyy-HHmmss")
    End Sub
End Class