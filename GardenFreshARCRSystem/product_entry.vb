
Imports MySql.Data.MySqlClient
Public Class product_entry
    Dim query, classification_code As String
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim exeread As MySqlDataReader

    Private Sub loadprodtype()
        Try

            connection.con.Open()
            Dim quer As String = "select description from tbl_classification"
            Dim cmd As New MySqlCommand(quer, connection.con)

            Dim da2 As MySqlDataAdapter = New MySqlDataAdapter(cmd)

            Dim dt As New DataTable("description")
            da2.Fill(dt)

            If dt.Rows.Count > 0 Then
                cmbprodclass.DataSource = dt
                cmbprodclass.DisplayMember = "description"

            End If
            connection.con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub product_entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadprodtype()

        loadproductrec()

        loadfinishedproductrec()

        txtprodentrycode.Text = DateTime.Now.ToString("ddMM-yyyy-HHmmss")


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
    Private Sub loadfinishedproductrec()
        Dim sql As MySqlCommand = New MySqlCommand("SELECT b.product_name, b.price, c.description, a.quantity, a.date from tbl_product_entry a, tbl_product_reg b, tbl_classification c where a.classification_code = c.classification_code and b.product_code = a.product_code", connection.con)
        da = New MySqlDataAdapter()
        ds = New DataSet

        da.SelectCommand = sql

        da.Fill(ds, "rec")
        DataGridView2.DataSource = ds
        DataGridView2.DataMember = "rec"
        connection.con.Close()
    End Sub
 
    'Private Sub cmdprodentryupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprodentryupdate.Click
    ' connection.con.Open()
    '  query = "select classification_code from tbl_classification where description ='" + cmbprodclass.Text + "'"
    ' cmd = New MySqlCommand(query, connection.con)

    ' exeread = cmd.ExecuteReader()

    '  If exeread.Read Then

    'classification_code = exeread.GetString("classification_code")
    '   End If
    '    connection.con.Close()

    '  connection.con.Open()

    '  query = "UPDATE tbl_product_entry set classification_code = '" + classification_code + "',quantity = '" + txtprodentryquantity.Text + "' where product_entry_code ='" + txtprodentrycode.Text + "'"


    ' cmd = New MySqlCommand(query, connection.con)

    ' Dim i As Integer = cmd.ExecuteNonQuery()
    ' MsgBox("Updated!", MsgBoxStyle.Information)


    '  connection.con.Close()
    ' End Sub

    Private Sub cmbprodentryreg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbprodentryreg.Click
        Dim quantity As Integer

        connection.con.Open()
        query = "select classification_code from tbl_classification where description ='" + cmbprodclass.Text + "'"
        cmd = New MySqlCommand(query, connection.con)

        exeread = cmd.ExecuteReader()

        If exeread.Read Then

            classification_code = exeread.GetString("classification_code")
        End If
        connection.con.Close()

        If isProductEntryExisted() Then
            connection.con.Open()
            query = "select quantity from tbl_product_entry where product_code ='" & txtprodcode.Text & _
                "' AND classification_code = '" & classification_code & "'"
            cmd = New MySqlCommand(query, connection.con)

            exeread = cmd.ExecuteReader()

            If exeread.Read Then

                quantity = exeread.GetInt16("quantity")
            End If
            connection.con.Close()

            connection.con.Open()

            query = "UPDATE tbl_product_entry SET quantity = '" & (quantity + Integer.Parse(txtprodentryquantity.Text)) & _
                "' where product_code ='" & txtprodcode.Text & "' AND classification_code = '" & classification_code & "'"

            cmd = New MySqlCommand(query, connection.con)

            Dim i As Integer = cmd.ExecuteNonQuery()
                MsgBox("Successfully!", MsgBoxStyle.Information)



                connection.con.Close()
            Else
                connection.con.Open()

                query = "INSERT INTO tbl_product_entry(product_entry_code,product_code,date,quantity,classification_code)VALUES('"
                query = query + txtprodentrycode.Text + "','" + txtprodcode.Text + "','" + DateTime.Now.ToString("yyyy/MM/dd") + "','" + txtprodentryquantity.Text + "','" + classification_code + "')"

                cmd = New MySqlCommand(query, connection.con)

                Dim i As Integer = cmd.ExecuteNonQuery()
                MsgBox("Successfully!", MsgBoxStyle.Information)


                connection.con.Close()
            End If
        loadfinishedproductrec()

    End Sub

    Function isProductEntryExisted()
        Dim success As Boolean = False

        connection.con.Open()
        query = "select count(*) from tbl_product_entry where product_code ='" + txtprodcode.Text + "' AND classification_code = '" & classification_code & "'"
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

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)


            txtprodcode.Text = row.Cells("product_code").Value.ToString
            txtprodentryprodname.Text = row.Cells("product_name").Value.ToString

        End If
    End Sub
End Class