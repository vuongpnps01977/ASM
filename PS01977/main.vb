Public Class frmmain

    Private Sub QLSanPhamToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QLSanPhamToolStripMenuItem.Click
        frmQLsanpham.show()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThoátToolStripMenuItem.Click
        End
    End Sub

    Private Sub QLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QLToolStripMenuItem.Click
        Me.Close()
        frmhtbh.Show()
    End Sub

    Private Sub QLLoạiSảnPhẩmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QLKhachhangToolStripMenuItem.Click
        frmQLKH.Show()
    End Sub

    Private Sub frmmain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class