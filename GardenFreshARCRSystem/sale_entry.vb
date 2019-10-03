
Imports MySql.Data.MySqlClient
Public Class saleentry
    Dim query As String
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim exeread As MySqlDataReader
    Public sales_type As String
    Dim selected_product_entry_code_from_cart As String
    Dim selected_quantity_from_cart As Integer
    Public is_cart_clicked = False

    Public Sub loadfinishedproductrec()
        Dim sql As MySqlCommand = New MySqlCommand("SELECT a.product_entry_code, b.product_name as 'Product Name', b.price as 'Price', c.description as 'Description', a.quantity as 'Quantity' from tbl_product_entry a, tbl_product_reg b, tbl_classification c where a.classification_code = c.classification_code and b.product_code = a.product_code", connection.con)
        da = New MySqlDataAdapter()
        ds = New DataSet

        da.SelectCommand = sql

        da.Fill(ds, "rec")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "rec"
        connection.con.Close()
        DataGridView1.Columns("product_entry_code").Visible = False

    End Sub

    Public Sub loadcart()
        Dim sql As MySqlCommand = New MySqlCommand("Select a.product_entry_code, b.product_name as 'Product', a.quantity as 'Quantity', d.description " &
            "as 'Classification' From tbl_temp a, tbl_product_reg b, tbl_product_entry c, tbl_classification d Where a.product_entry_code " &
            "= c.product_entry_code And c.product_code = b.product_code And c.classification_code = d.classification_code", connection.con)
        da = New MySqlDataAdapter()
        ds = New DataSet

        da.SelectCommand = sql

        da.Fill(ds, "rec")
        DataGridView2.DataSource = ds
        DataGridView2.DataMember = "rec"
        connection.con.Close()

        DataGridView2.Columns(0).Visible = False
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
            txtprodname.Text = row.Cells(1).Value.ToString
            txtclassification.Text = row.Cells(3).Value.ToString
        End If
    End Sub
    Private Sub cmbadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbadd.Click
        Dim current_quantity_product_entry As Integer = 0
        Dim previous_quantity, added_quantity, subtracted_quantity As Integer

        connection.con.Open()
        query = "select quantity from tbl_product_entry where product_entry_code ='" + txtprodentrycode.Text + "'"
        cmd = New MySqlCommand(query, connection.con)

        exeread = cmd.ExecuteReader()

        If exeread.Read Then
            If exeread.GetInt16("quantity") > 0 Then
                current_quantity_product_entry = exeread.GetString("quantity")
            End If
        End If
        connection.con.Close()


        If is_product_added_existed() Then
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
            query = "UPDATE tbl_temp SET quantity = '" & added_quantity.ToString & "' WHERE sales_entry_code = '" & txtsalesntrycode.Text &
                "' AND inv_no = '" & txtsalesinv.Text & "' AND product_entry_code = '" & txtprodentrycode.Text & "'"
            cmd = New MySqlCommand(query, connection.con)
            cmd.ExecuteNonQuery()
            connection.con.Close()

            subtracted_quantity = current_quantity_product_entry - Integer.Parse(txtquan.Text)

            connection.con.Open()
            query = "UPDATE tbl_product_entry SET quantity = '" & subtracted_quantity.ToString & "' WHERE product_entry_code = '" & txtprodentrycode.Text &
                "'"
            cmd = New MySqlCommand(query, connection.con)
            cmd.ExecuteNonQuery()
            connection.con.Close()
        Else


            connection.con.Open()
            query = "INSERT INTO tbl_temp(sales_entry_code, inv_no, product_entry_code, quantity)VALUES('" &
                txtsalesntrycode.Text & "', '" & txtsalesinv.Text & "', '" & txtprodentrycode.Text & "','" & txtquan.Text & "')"
            cmd = New MySqlCommand(query, connection.con)
            cmd.ExecuteNonQuery()
            connection.con.Close()

            subtracted_quantity = current_quantity_product_entry - Integer.Parse(txtquan.Text)

            connection.con.Open()
            query = "UPDATE tbl_product_entry SET quantity = '" & subtracted_quantity.ToString & "' WHERE product_entry_code = '" & txtprodentrycode.Text &
                "'"
            cmd = New MySqlCommand(query, connection.con)
            cmd.ExecuteNonQuery()
            connection.con.Close()
        End If

        loadcart()
        loadfinishedproductrec()
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

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DataGridView2.Rows(e.RowIndex)

            selected_product_entry_code_from_cart = row.Cells(0).Value.ToString
            selected_quantity_from_cart = Integer.Parse(row.Cells(2).Value.ToString)
            is_cart_clicked = True
        End If
    End Sub

    Private Sub cmbremove_Click(sender As Object, e As EventArgs) Handles cmbremove.Click
        If is_cart_clicked Then
            quantity_form.selected_product_entry_code_from_cart = selected_product_entry_code_from_cart
            quantity_form.sales_entry_code = txtsalesntrycode.Text
            quantity_form.invoice_code = txtsalesinv.Text
            quantity_form.selected_quantity_from_cart = selected_quantity_from_cart
            quantity_form.ShowDialog()
        End If
    End Sub
End Class