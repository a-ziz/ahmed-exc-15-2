Public Class CustomerInvoiceDisplay

    Private Sub CustomerInvoiceDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = txtCustomerID.Control

    End Sub

    Private Sub FillByCustomerIDToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByCustomerIDToolStripButton.Click
        Try
            Me.CustomersTableAdapter.FillByCustomerID(Me.MMABooksDataSet.Customers, CType(txtCustomerID.Text, Integer))
            Me.InvoicesTableAdapter.FillByCustomerID(Me.MMABooksDataSet.Invoices, CType(txtCustomerID.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class
