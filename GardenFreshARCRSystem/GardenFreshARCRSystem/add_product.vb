Imports MySql.Data.MySqlClient

Public Class add_product
    Dim query As String
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim ds As DataSet


    Private Sub cmdprodreg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprodreg.Click

        cmd = New MySqlCommand(query, connection.con)
        connection.con.Open()

        query = "INSERT INTO tbl_product_reg(product_code,product_name,price)VALUES('"
        query = query + txtprodid.Text + "','" + txtprodname.Text + "','" + txtprodprice.Text + "')"

        cmd = New MySqlCommand(query, connection.con)

        Dim i As Integer = cmd.ExecuteNonQuery()
        MsgBox("Successful!", MsgBoxStyle.Information)
        connection.con.Close()

        txtprodid.Text = ""
        txtprodname.Text = ""
        txtprodprice.Text = ""

        loadproductrec()
    End Sub
    Private Sub loadproductrec()
        Dim sql As MySqlCommand = New MySqlCommand("SELECT * from tbl_product_reg", connection.con)
        da = New MySqlDataAdapter()
        ds = New DataSet

        da.SelectCommand = sql

        da.Fill(ds, "rec")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "rec"
        connection.con.Close()
    End Sub
    Private Sub add_product_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadproductrec()

        txtprodid.Text = DateTime.Now.ToString("ddMM-yyyy-HHmmss")
    End Sub
End Class