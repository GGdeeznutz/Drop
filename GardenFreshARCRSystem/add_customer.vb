Imports MySql.Data.MySqlClient
Public Class add_customer
    Dim query As String
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim ds As DataSet

    Private Sub cmbaddcustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbaddcustomer.Click
        cmd = New MySqlCommand(query, connection.con)
        connection.con.Open()

        query = "INSERT INTO tbl_customer(id_no,fname,lname,address,contact_no)VALUES('"
        query = query + txtcustid.Text + "','" + txtcustfname.Text + "','" + txtcustlname.Text + "','" + txtcustadd.Text + "','" + txtcustcontact.Text + "')"

        cmd = New MySqlCommand(query, connection.con)

        Dim i As Integer = cmd.ExecuteNonQuery()
        MsgBox("Successful!", MsgBoxStyle.Information)
        connection.con.Close()

        txtcustid.Text = ""
        txtcustfname.Text = ""
        txtcustlname.Text = ""
        txtcustadd.Text = ""
        txtcustcontact.Text = ""
    End Sub
    Private Sub loadcustomerrec()
        Dim sql As MySqlCommand = New MySqlCommand("SELECT * from tbl_customer", connection.con)
        da = New MySqlDataAdapter()
        ds = New DataSet

        da.SelectCommand = sql

        da.Fill(ds, "rec")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "rec"
        connection.con.Close()
    End Sub

    Private Sub add_customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadcustomerrec()

        txtcustid.Text = DateTime.Now.ToString("ddMM-yyyy-HHmmss")
    End Sub
End Class