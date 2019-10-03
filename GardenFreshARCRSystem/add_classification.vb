Imports MySql.Data.MySqlClient

Public Class add_classification
    Dim query As String
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Private Sub cmdaddclass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaddclass.Click
        cmd = New MySqlCommand(query, connection.con)
        connection.con.Open()

        query = "INSERT INTO tbl_classification(classification_code,description)VALUES('"
        query = query + txtclasscode.Text + "','" + txtclassdesc.Text + "')"

        cmd = New MySqlCommand(query, connection.con)

        Dim i As Integer = cmd.ExecuteNonQuery()
        MsgBox("Successful!", MsgBoxStyle.Information)
        connection.con.Close()

        txtclasscode.Text = ""
        txtclassdesc.Text = ""

        loadclassrec()
    End Sub
    Private Sub loadclassrec()
        Dim sql As MySqlCommand = New MySqlCommand("SELECT * from tbl_classification", connection.con)
        da = New MySqlDataAdapter()
        ds = New DataSet

        da.SelectCommand = sql

        da.Fill(ds, "rec")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "rec"
        connection.con.Close()
    End Sub

    Private Sub add_classification_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadclassrec()

        txtclasscode.Text = DateTime.Now.ToString("ddMM-yyyy-HHmmss")
    End Sub
End Class