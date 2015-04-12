<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.QLSanPhamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QLKhachhangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.stsStatus = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ptbMain = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.stsStatus.SuspendLayout()
        CType(Me.ptbMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.PowderBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QLSanPhamToolStripMenuItem, Me.QLKhachhangToolStripMenuItem, Me.QLToolStripMenuItem, Me.ThoátToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(417, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'QLSanPhamToolStripMenuItem
        '
        Me.QLSanPhamToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.QLSanPhamToolStripMenuItem.ForeColor = System.Drawing.Color.Orange
        Me.QLSanPhamToolStripMenuItem.Name = "QLSanPhamToolStripMenuItem"
        Me.QLSanPhamToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.QLSanPhamToolStripMenuItem.Text = "QL Sản phẩm"
        '
        'QLKhachhangToolStripMenuItem
        '
        Me.QLKhachhangToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.QLKhachhangToolStripMenuItem.ForeColor = System.Drawing.Color.Orange
        Me.QLKhachhangToolStripMenuItem.Name = "QLKhachhangToolStripMenuItem"
        Me.QLKhachhangToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.QLKhachhangToolStripMenuItem.Text = "QL Khách hàng"
        '
        'QLToolStripMenuItem
        '
        Me.QLToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.QLToolStripMenuItem.ForeColor = System.Drawing.Color.Orange
        Me.QLToolStripMenuItem.Name = "QLToolStripMenuItem"
        Me.QLToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.QLToolStripMenuItem.Text = " Về Login"
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ThoátToolStripMenuItem.ForeColor = System.Drawing.Color.Orange
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ThoátToolStripMenuItem.Text = " Thoát"
        '
        'stsStatus
        '
        Me.stsStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.stsStatus.Location = New System.Drawing.Point(0, 251)
        Me.stsStatus.Name = "stsStatus"
        Me.stsStatus.Size = New System.Drawing.Size(417, 22)
        Me.stsStatus.TabIndex = 2
        Me.stsStatus.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(204, 17)
        Me.ToolStripStatusLabel2.Text = "Sinh viên Phạm Nguyễn Vương - ps01977"
        '
        'ptbMain
        '
        Me.ptbMain.Image = Global.PS01977.My.Resources.Resources.ps01977
        Me.ptbMain.Location = New System.Drawing.Point(0, 22)
        Me.ptbMain.Name = "ptbMain"
        Me.ptbMain.Size = New System.Drawing.Size(417, 228)
        Me.ptbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbMain.TabIndex = 3
        Me.ptbMain.TabStop = False
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ClientSize = New System.Drawing.Size(417, 273)
        Me.Controls.Add(Me.ptbMain)
        Me.Controls.Add(Me.stsStatus)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmmain"
        Me.Text = "Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.stsStatus.ResumeLayout(False)
        Me.stsStatus.PerformLayout()
        CType(Me.ptbMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents QLSanPhamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QLKhachhangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents stsStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ptbMain As System.Windows.Forms.PictureBox
End Class
