Imports MySql.Data.MySqlClient
Public Class dashboard
    Dim query As String

    Private Sub ProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductToolStripMenuItem.Click
        add_product.Show()

    End Sub

    Private Sub ClassificationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassificationToolStripMenuItem.Click
        add_classification.Show()
    End Sub

    Private Sub AccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountToolStripMenuItem.Click
        add_account.Show()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        add_customer.Show()
    End Sub

    Private Sub TransactionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionToolStripMenuItem.Click
        product_entry.Show()
    End Sub

    Private Sub CreditToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditToolStripMenuItem1.Click
        credit.Show()

    End Sub

    Private Sub CashSalesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashSalesToolStripMenuItem1.Click
        saleentry.txtsalesinv.Text = DateTime.Now.ToString("ddMM-yyyy-HHmmss") & "-AAA"
        saleentry.sales_type = "cash"
        saleentry.Label8.Visible = False
        saleentry.txtcustomername.Visible = False
        saleentry.Label7.Visible = False
        saleentry.txtcredno.Visible = False
        saleentry.Show()

    End Sub

    Private Sub BillingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillingToolStripMenuItem1.Click

    End Sub
End Class
