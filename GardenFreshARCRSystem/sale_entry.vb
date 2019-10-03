
Imports MySql.Data.MySqlClient
Public Class saleentry
    Dim query As String
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim exeread As MySqlDataReader
    Public sales_type As String

    Private Sub loadfinishedproductrec()
        Dim sql As MySqlCommand = New MySqlCommand("SELECT a.product_entry_code as 'Product Code', b.product_name, b.price, c.description, a.quantity, a.date from tbl_product_entry a, tbl_product_reg b, tbl_classification c where a.classification_code = c.classification_code and b.product_code = a.product_code", connection.con)
        da = New MySqlDataAdapter()
        ds = New DataSet

        da.SelectCommand = sql

        da.Fill(ds, "rec")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "rec"
        connection.con.Close()
        DataGridView1.Columns("Product Code").Visible = False

    End Sub

    Private Sub loadcart()
        Dim sql As MySqlCommand = New MySqlCommand("select sales_entry_code, inv_no," & _
            " product_entry_code, quantity from tbl_temp", connection.con)
        da = New MySqlDataAdapter()
        ds = New DataSet

        da.SelectCommand = sql

        da.Fill(ds, "rec")
        DataGridView2.DataSource = ds
        DataGridView2.DataMember = "rec"
        connection.con.Close()
    End Sub

    Private Sub sale_entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadfinishedproductrec()

        txtsalesntrycode.Text = DateTime.Now.ToString("ddMM-yyyy-HHmmss")
        txtsalesinv.Text = DateTime.Now.ToString("ddMM-yyyy-HHmmss") & "-GGG"
        txtsalestype.Text = sales_type
        reset_add_to_cart()
    End Sub

    Sub reset_add_to_cart()
        connection.con.Open()
        query = "DELETE FROM tbl_temp"
        cmd = New MySqlCommand(query, connection.con)

        cmd.ExecuteNonQuery()

        connection.con.Close()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Function is_product_added_existed()
        Dim success As Boolean = False

        connection.con.Open()
        query = "select count(*) from tbl_temp where sales_entry_code ='" + txtsalesntrycode.Text + "' AND inv_no = '" & txtsalesinv.Text & "' AND product_entry_code = '" & txtprodentrycode.Text & "'"
        cmd = New MySqlCommand(query, connection.con)

        exeread = cmd.ExecuteReader()

        If exeread.Read Then
            If exeread.GetString("count(*)") > 0 Then
                success = True
            End If
        End If
        connection.con.Close()

        Return success
    End Function

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)


            txtprodentrycode.Text = row.Cells(0).Value.ToString
            txtprodname.Text = row.Cells("product_name").Value.ToString
            txtclassification.Text = row.Cells("description").Value.ToString
        End If
    End Sub
    Private Sub cmbadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbadd.Click
        If is_product_added_existed() Then
            Dim previous_quantity, added_quantity As Integer

            connection.con.Open()
            query = "select quantity from tbl_temp where sales_entry_code ='" + txtsalesntrycode.Text + "' AND inv_no = '" & txtsalesinv.Text & "' AND product_entry_code = '" & txtprodentrycode.Text & "'"
            cmd = New MySqlCommand(query, connection.con)

            exeread = cmd.ExecuteReader()

            If exeread.Read Then
                If exeread.GetString("quantity") > 0 Then
                    previous_quantity = exeread.GetString("quantity")
                Else
                    previous_quantity = 0
                End If
            End If
            connection.con.Close()

            added_quantity = previous_quantity + Integer.Parse(txtquan.Text)

            connection.con.Open()

            query = "UPDATE tbl_temp SET quantity = '" & added_quantity.ToString & "' WHERE sales_entry_code = '" & txtsalesntrycode.Text & _
                "' AND inv_no = '" & txtsalesinv.Text & "' AND product_entry_code = '" & txtprodentrycode.Text & "'"


            cmd = New MySqlCommand(query, connection.con)

            cmd.ExecuteNonQuery()
            'MsgBox("Successful!", MsgBoxStyle.Information)


            connection.con.Close()
        Else
            connection.con.Open()


            query = "INSERT INTO tbl_temp(sales_entry_code, inv_no, product_entry_code, quantity)VALUES('" & _
                txtsalesntrycode.Text & "', '" & txtsalesinv.Text & "', '" & txtprodentrycode.Text & "','" & txtquan.Text & "')"


            cmd = New MySqlCommand(query, connection.con)

            cmd.ExecuteNonQuery()
            'MsgBox("Successful!", MsgBoxStyle.Information)


            connection.con.Close()

        End If

        loadcart()

    End Sub

    Private Sub cmbremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbremove.Click

    End Sub

    Private Sub cmbconfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbconfirm.Click
        connection.con.Open()


        query = "INSERT INTO tbl_sales_entry(sales_entry_code, inv_no, product_entry_code, quantity) SELECT sales_entry_code, inv_no, product_entry_code, quantity from tbl_temp where inv_no = '" & txtsalesinv.Text & "'"

        cmd = New MySqlCommand(query, connection.con)

        cmd.ExecuteNonQuery()
        'MsgBox("Successful!", MsgBoxStyle.Information)


        connection.con.Close()

        reset_add_to_cart()
        loadcart()
        MsgBox("Added!")
    End Sub
End Class