
Imports MySql.Data.MySqlClient
   
    Public Class credit
    Dim query As String
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim exeread As MySqlDataReader
    Public sales_type As String
        Private Sub cmdaddcustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaddcustomer.Click
        saleentry.txtsalesinv.Text = DateTime.Now.ToString("ddMM-yyyy-HHmmss") & "-EEE"
        saleentry.txtcredno.Text = txtcreditno.Text
        saleentry.txtcustomername.Text = txtcustomer.Text
        saleentry.txtcustomerid.Text = txtcustomerid.Text
        saleentry.sales_type = "credit"
        saleentry.Label7.Visible = True
        saleentry.txtcredno.Visible = True
        saleentry.Label8.Visible = True
        saleentry.txtcustomername.Visible = True
        saleentry.Show()

        'connection.con.Open()

        'query = "INSERT INTO tbl_credit(credit_no,inv_no,id_no,date)VALUES('"
        'query = query + txtcreditno.Text + "','" + txtsaleinv.Text + "','" + "','" + txtcustomerid.Text + "','" + DateTime.Now.ToString("ddMM-yyyy-HHmmss") + "')"

        'cmd = New MySqlCommand(query, connection.con)

        'Dim i As Integer = cmd.ExecuteNonQuery()
        'MsgBox("Successfully!", MsgBoxStyle.Information)


        'connection.con.Close()
        End Sub

    Private Sub cmdgotocustomerreg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        add_customer.Show()
    End Sub

        Private Sub credit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtcreditno.Text = DateTime.Now.ToString("ddMM-yyyy-HHmmss")

        loadcustomer()


        End Sub
        Sub loadcustomer()
        Dim sql As MySqlCommand = New MySqlCommand("SELECT * from tbl_customer", connection.con)
            da = New MySqlDataAdapter()
            ds = New DataSet

            da.SelectCommand = sql

            da.Fill(ds, "rec")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "rec"
            connection.con.Close()
        End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)


            txtcustomer.Text = row.Cells(1).Value.ToString
            txtcustomerid.Text = row.Cells(0).Value.ToString
        End If
    End Sub
End Class