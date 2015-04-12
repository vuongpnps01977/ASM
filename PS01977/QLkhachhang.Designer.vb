<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLKH
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
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.viewkh = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGioitinh = New System.Windows.Forms.TextBox()
        Me.txtSodt = New System.Windows.Forms.TextBox()
        Me.txtDiachi = New System.Windows.Forms.TextBox()
        Me.txtTenkh = New System.Windows.Forms.TextBox()
        Me.txtMakh = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ptbKH = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.viewkh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbKH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThoat.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnThoat.Location = New System.Drawing.Point(432, 322)
        Me.btnThoat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(100, 28)
        Me.btnThoat.TabIndex = 31
        Me.btnThoat.Text = "Exit"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnXoa.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnXoa.Location = New System.Drawing.Point(297, 322)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(100, 28)
        Me.btnXoa.TabIndex = 30
        Me.btnXoa.Text = "Delete"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnSua.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnSua.Location = New System.Drawing.Point(165, 322)
        Me.btnSua.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(100, 28)
        Me.btnSua.TabIndex = 29
        Me.btnSua.Text = "Fix"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThem.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnThem.Location = New System.Drawing.Point(29, 322)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(100, 28)
        Me.btnThem.TabIndex = 28
        Me.btnThem.Text = "Add"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'viewkh
        '
        Me.viewkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewkh.Location = New System.Drawing.Point(81, 368)
        Me.viewkh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.viewkh.Name = "viewkh"
        Me.viewkh.Size = New System.Drawing.Size(543, 185)
        Me.viewkh.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 64)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 16)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Mã khách hàng:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 212)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Số nhà:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 158)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 16)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Số điện thoại:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 105)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Tên khách hàng:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 265)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Giới tính:"
        '
        'txtGioitinh
        '
        Me.txtGioitinh.Location = New System.Drawing.Point(189, 261)
        Me.txtGioitinh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtGioitinh.Name = "txtGioitinh"
        Me.txtGioitinh.Size = New System.Drawing.Size(212, 22)
        Me.txtGioitinh.TabIndex = 20
        '
        'txtSodt
        '
        Me.txtSodt.Location = New System.Drawing.Point(189, 155)
        Me.txtSodt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSodt.Name = "txtSodt"
        Me.txtSodt.Size = New System.Drawing.Size(212, 22)
        Me.txtSodt.TabIndex = 18
        '
        'txtDiachi
        '
        Me.txtDiachi.Location = New System.Drawing.Point(189, 208)
        Me.txtDiachi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDiachi.Name = "txtDiachi"
        Me.txtDiachi.Size = New System.Drawing.Size(212, 22)
        Me.txtDiachi.TabIndex = 19
        '
        'txtTenkh
        '
        Me.txtTenkh.Location = New System.Drawing.Point(189, 101)
        Me.txtTenkh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTenkh.Name = "txtTenkh"
        Me.txtTenkh.Size = New System.Drawing.Size(212, 22)
        Me.txtTenkh.TabIndex = 17
        '
        'txtMakh
        '
        Me.txtMakh.Location = New System.Drawing.Point(189, 60)
        Me.txtMakh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMakh.Name = "txtMakh"
        Me.txtMakh.Size = New System.Drawing.Size(212, 22)
        Me.txtMakh.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label6.Location = New System.Drawing.Point(25, 11)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(269, 29)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = " Thông tin khách hàng"
        '
        'ptbKH
        '
        Me.ptbKH.Image = Global.PS01977.My.Resources.Resources.kh
        Me.ptbKH.Location = New System.Drawing.Point(419, 23)
        Me.ptbKH.Name = "ptbKH"
        Me.ptbKH.Size = New System.Drawing.Size(280, 280)
        Me.ptbKH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbKH.TabIndex = 33
        Me.ptbKH.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnBack.Location = New System.Drawing.Point(573, 322)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 28)
        Me.btnBack.TabIndex = 34
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmQLKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ClientSize = New System.Drawing.Size(729, 566)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.ptbKH)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.viewkh)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGioitinh)
        Me.Controls.Add(Me.txtSodt)
        Me.Controls.Add(Me.txtDiachi)
        Me.Controls.Add(Me.txtTenkh)
        Me.Controls.Add(Me.txtMakh)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmQLKH"
        Me.Text = "QL Khách hàng"
        CType(Me.viewkh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbKH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents viewkh As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtGioitinh As System.Windows.Forms.TextBox
    Friend WithEvents txtSodt As System.Windows.Forms.TextBox
    Friend WithEvents txtDiachi As System.Windows.Forms.TextBox
    Friend WithEvents txtTenkh As System.Windows.Forms.TextBox
    Friend WithEvents txtMakh As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ptbKH As System.Windows.Forms.PictureBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
