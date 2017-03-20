Public Class pubTable
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub pubTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ContactsDataSet.Publishers' table. You can move, or remove it, as needed.
        Me.PublishersTableAdapter.Fill(Me.ContactsDataSet.Publishers)

    End Sub
End Class
