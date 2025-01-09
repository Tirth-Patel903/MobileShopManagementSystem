Public Class Home
    Private Sub InsertMobileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertMobileToolStripMenuItem.Click
        InsertMobile.ShowDialog()
    End Sub

    Private Sub SellMobileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SellMobileToolStripMenuItem.Click
        SellMobile.ShowDialog()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        Search.ShowDialog()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Delete.ShowDialog()
    End Sub

    Private Sub UpdateMobileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateMobileToolStripMenuItem.Click
        UpdatePhone.ShowDialog()
    End Sub
End Class