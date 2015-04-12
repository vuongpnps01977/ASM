<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLsanpham
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
        Me.txtMasp = New System.Windows.Forms.TextBox()
        Me.txtTensp = New System.Windows.Forms.TextBox()
        Me.txtChitietsp = New System.Windows.Forms.TextBox()
        Me.txtSoluong = New System.Windows.Forms.TextBox()
        Me.txtDongia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.viewsp = New System.Windows.Forms.DataGridView()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMaloai = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ptbSP = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.viewsp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMasp
        '
        Me.txtMasp.Location = New System.Drawing.Point(159, 56)
        Me.txtMasp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMasp.Name = "txtMasp"
        Me.txtMasp.Size = New System.Drawing.Size(212, 22)
        Me.txtMasp.TabIndex = 0
        '
        'txtTensp
        '
        Me.txtTensp.Location = New System.Drawing.Point(159, 109)
        Me.txtTensp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTensp.Name = "txtTensp"
        Me.txtTensp.Size = New System.Drawing.Size(212, 22)
        Me.txtTensp.TabIndex = 1
        '
        'txtChitietsp
        '
        Me.txtChitietsp.Location = New System.Drawing.Point(159, 209)
        Me.txtChitietsp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtChitietsp.Name = "txtChitietsp"
        Me.txtChitietsp.Size = New System.Drawing.Size(212, 22)
        Me.txtChitietsp.TabIndex = 3
        '
        'txtSoluong
        '
        Me.txtSoluong.Location = New System.Drawing.Point(159, 160)
        Me.txtSoluong.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSoluong.Name = "txtSoluong"
        Me.txtSoluong.Size = New System.Drawing.Size(212, 22)
        Me.txtSoluong.TabIndex = 2
        '
        'txtDongia
        '
        Me.txtDongia.Location = New System.Drawing.Point(159, 256)
        Me.txtDongia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDongia.Name = "txtDongia"
        Me.txtDongia.Size = New System.Drawing.Size(212, 22)
        Me.txtDongia.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 262)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Giá (/1sp):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 115)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Tên sản phẩm:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 166)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Số lượng:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 215)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Chi tiết SP:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 62)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Mã sản phẩm:"
        '
        'viewsp
        '
        Me.viewsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewsp.Location = New System.Drawing.Point(54, 382)
        Me.viewsp.Margin = New System.Windows.Forms.Padding(4)
        Me.viewsp.Name = "viewsp"
        Me.viewsp.Size = New System.Drawing.Size(631, 185)
        Me.viewsp.TabIndex = 10
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThem.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnThem.Location = New System.Drawing.Point(23, 346)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(4)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(100, 28)
        Me.btnThem.TabIndex = 11
        Me.btnThem.Text = "Add"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnSua.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnSua.Location = New System.Drawing.Point(159, 346)
        Me.btnSua.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(100, 28)
        Me.btnSua.TabIndex = 12
        Me.btnSua.Text = "Fix"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnXoa.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnXoa.Location = New System.Drawing.Point(291, 346)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(4)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(100, 28)
        Me.btnXoa.TabIndex = 13
        Me.btnXoa.Text = "Delete"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThoat.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnThoat.Location = New System.Drawing.Point(426, 346)
        Me.btnThoat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(100, 28)
        Me.btnThoat.TabIndex = 14
        Me.btnThoat.Text = "Exit"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 305)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Mã loại:"
        '
        'txtMaloai
        '
        Me.txtMaloai.Location = New System.Drawing.Point(159, 302)
        Me.txtMaloai.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaloai.Name = "txtMaloai"
        Me.txtMaloai.Size = New System.Drawing.Size(212, 22)
        Me.txtMaloai.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label7.Location = New System.Drawing.Point(49, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(242, 29)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Thông tin sản phẩm"
        '
        'ptbSP
        '
        Me.ptbSP.Image = Global.PS01977.My.Resources.Resources.SP
        Me.ptbSP.Location = New System.Drawing.Point(416, 44)
        Me.ptbSP.Name = "ptbSP"
        Me.ptbSP.Size = New System.Drawing.Size(280, 280)
        Me.ptbSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbSP.TabIndex = 17
        Me.ptbSP.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnBack.Location = New System.Drawing.Point(563, 346)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 28)
        Me.btnBack.TabIndex = 18
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmQLsanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ClientSize = New System.Drawing.Size(736, 580)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.ptbSP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMaloai)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.viewsp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDongia)
        Me.Controls.Add(Me.txtSoluong)
        Me.Controls.Add(Me.txtChitietsp)
        Me.Controls.Add(Me.txtTensp)
        Me.Controls.Add(Me.txtMasp)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmQLsanpham"
        Me.Text = "QL Sản phẩm"
        CType(Me.viewsp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMasp As System.Windows.Forms.TextBox
    Friend WithEvents txtTensp As System.Windows.Forms.TextBox
    Friend WithEvents txtChitietsp As System.Windows.Forms.TextBox
    Friend WithEvents txtSoluong As System.Windows.Forms.TextBox
    Friend WithEvents txtDongia As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents viewsp As System.Windows.Forms.DataGridView
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMaloai As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ptbSP As System.Windows.Forms.PictureBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
