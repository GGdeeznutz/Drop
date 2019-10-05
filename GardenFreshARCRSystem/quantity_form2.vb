Imports MySql.Data.MySqlClient
Public Class quantity_form2
    Dim query As String
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim exeread As MySqlDataReader
    Public selected_product_entry_code_from_cart, sales_entry_code, invoice_code As String
    Public selected_quantity_from_cart As Integer
    Dim current_quantity_product_entry, current_quantity_cart As Integer
    Dim added_quantity, subtracted_quantity_cart As Integer

    Private Sub bn_cancel_Click(sender As Object, e As EventArgs) Handles bn_cancel.Click
        selected_product_entry_code_from_cart = ""
        sales_entry_code = ""
        invoice_code = ""
        selected_quantity_from_cart = 0

        saleentry.is_cart_clicked = False

        Close()

    End Sub

    Private Sub quantity_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_quantity.Text = selected_quantity_from_cart
    End Sub

    Private Sub btn_execute_process_Click(sender As Object, e As EventArgs) Handles btn_execute_process.Click
        connection.con.Open()
        query = "select quantity from tbl_temp WHERE sales_entry_code = '" & sales_entry_code &
                    "' AND inv_no = '" & invoice_code & "' AND product_entry_code = '" & selected_product_entry_code_from_cart & "'"
        cmd = New MySqlCommand(query, connection.con)

        exeread = cmd.ExecuteReader()

        If exeread.Read Then
            current_quantity_cart = exeread.GetString("quantity")
        End If
        connection.con.Close()

        connection.con.Open()
        query = "select quantity from tbl_product_entry where product_entry_code ='" + selected_product_entry_code_from_cart + "'"
        cmd = New MySqlCommand(query, connection.con)

        exeread = cmd.ExecuteReader()

        If exeread.Read Then
            current_quantity_product_entry = exeread.GetString("quantity")
        End If
        connection.con.Close()

        added_quantity = Integer.Parse(tb_quantity.Text) + current_quantity_product_entry

        connection.con.Open()
        query = "UPDATE tbl_product_entry SET quantity = '" & added_quantity.ToString & "' WHERE product_entry_code = '" & selected_product_entry_code_from_cart &
            "'"
        cmd = New MySqlCommand(query, connection.con)
        cmd.ExecuteNonQuery()
        connection.con.Close()

        subtracted_quantity_cart = current_quantity_cart - Integer.Parse(tb_quantity.Text)

        If current_quantity_cart <= Integer.Parse(tb_quantity.Text) Then
            connection.con.Open()
            query = "DELETE FROM tbl_temp WHERE sales_entry_code = '" & sales_entry_code &
                    "' AND inv_no = '" & invoice_code & "' AND product_entry_code = '" & selected_product_entry_code_from_cart & "'"
            cmd = New MySqlCommand(query, connection.con)

            cmd.ExecuteNonQuery()

            connection.con.Close()
        Else
            connection.con.Open()
            query = "UPDATE tbl_temp SET quantity = '" & subtracted_quantity_cart.ToString & "' WHERE sales_entry_code = '" & sales_entry_code &
                    "' AND inv_no = '" & invoice_code & "' AND product_entry_code = '" & selected_product_entry_code_from_cart & "'"
            cmd = New MySqlCommand(query, connection.con)
            cmd.ExecuteNonQuery()
            connection.con.Close()
        End If

        saleentry.is_cart_clicked = False
        Close()

        saleentry.loadfinishedproductrec()
        saleentry.loadcart()
        saleentry.computeTotal()
    End Sub
End Class