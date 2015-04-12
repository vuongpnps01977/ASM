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
        ' Chỉnh sửa thêm vào 1 số thứ kiểm tra viêc chia sẽ github (ps01977)
    End Sub
End Class