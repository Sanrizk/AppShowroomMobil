<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMobil
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tKodeMbl = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tNamaMbl = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tKet = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tHarga = New System.Windows.Forms.TextBox()
        Me.cbTipeMbl = New System.Windows.Forms.ComboBox()
        Me.cbJnsMbl = New System.Windows.Forms.ComboBox()
        Me.cbCcMbl = New System.Windows.Forms.ComboBox()
        Me.bTambah = New System.Windows.Forms.Button()
        Me.bUbah = New System.Windows.Forms.Button()
        Me.bHapus = New System.Windows.Forms.Button()
        Me.bTutup = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tSearch = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5)
        Me.Label1.Size = New System.Drawing.Size(88, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Mobil"
        '
        'tKodeMbl
        '
        Me.tKodeMbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tKodeMbl.Location = New System.Drawing.Point(132, 26)
        Me.tKodeMbl.Name = "tKodeMbl"
        Me.tKodeMbl.Size = New System.Drawing.Size(100, 22)
        Me.tKodeMbl.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5)
        Me.Label2.Size = New System.Drawing.Size(84, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tipe Mobil"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(5)
        Me.Label3.Size = New System.Drawing.Size(93, 28)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nama Mobil"
        '
        'tNamaMbl
        '
        Me.tNamaMbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tNamaMbl.Location = New System.Drawing.Point(132, 80)
        Me.tNamaMbl.Name = "tNamaMbl"
        Me.tNamaMbl.Size = New System.Drawing.Size(388, 22)
        Me.tNamaMbl.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(5)
        Me.Label4.Size = New System.Drawing.Size(88, 28)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Jenis Mobil"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(5)
        Me.Label5.Size = New System.Drawing.Size(74, 28)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "CC Mobil"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(5)
        Me.Label6.Size = New System.Drawing.Size(89, 28)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Keterangan"
        '
        'tKet
        '
        Me.tKet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tKet.Location = New System.Drawing.Point(132, 183)
        Me.tKet.Multiline = True
        Me.tKet.Name = "tKet"
        Me.tKet.Size = New System.Drawing.Size(388, 76)
        Me.tKet.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(5)
        Me.Label7.Size = New System.Drawing.Size(58, 28)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Harga"
        '
        'tHarga
        '
        Me.tHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tHarga.Location = New System.Drawing.Point(132, 156)
        Me.tHarga.Name = "tHarga"
        Me.tHarga.Size = New System.Drawing.Size(100, 22)
        Me.tHarga.TabIndex = 7
        '
        'cbTipeMbl
        '
        Me.cbTipeMbl.FormattingEnabled = True
        Me.cbTipeMbl.Items.AddRange(New Object() {"Matic", "Manual"})
        Me.cbTipeMbl.Location = New System.Drawing.Point(132, 55)
        Me.cbTipeMbl.Name = "cbTipeMbl"
        Me.cbTipeMbl.Size = New System.Drawing.Size(162, 21)
        Me.cbTipeMbl.TabIndex = 2
        '
        'cbJnsMbl
        '
        Me.cbJnsMbl.FormattingEnabled = True
        Me.cbJnsMbl.Items.AddRange(New Object() {"Sedan", "Hatchback", "MPV", "SUV", "Station Wagon", "Jeep"})
        Me.cbJnsMbl.Location = New System.Drawing.Point(132, 106)
        Me.cbJnsMbl.Name = "cbJnsMbl"
        Me.cbJnsMbl.Size = New System.Drawing.Size(100, 21)
        Me.cbJnsMbl.TabIndex = 4
        '
        'cbCcMbl
        '
        Me.cbCcMbl.FormattingEnabled = True
        Me.cbCcMbl.Items.AddRange(New Object() {"1000", "1500", "2000"})
        Me.cbCcMbl.Location = New System.Drawing.Point(132, 132)
        Me.cbCcMbl.Name = "cbCcMbl"
        Me.cbCcMbl.Size = New System.Drawing.Size(100, 21)
        Me.cbCcMbl.TabIndex = 5
        '
        'bTambah
        '
        Me.bTambah.Location = New System.Drawing.Point(67, 272)
        Me.bTambah.Name = "bTambah"
        Me.bTambah.Size = New System.Drawing.Size(99, 37)
        Me.bTambah.TabIndex = 8
        Me.bTambah.Text = "Tambah"
        Me.bTambah.UseVisualStyleBackColor = True
        '
        'bUbah
        '
        Me.bUbah.Location = New System.Drawing.Point(172, 272)
        Me.bUbah.Name = "bUbah"
        Me.bUbah.Size = New System.Drawing.Size(99, 37)
        Me.bUbah.TabIndex = 9
        Me.bUbah.Text = "Ubah"
        Me.bUbah.UseVisualStyleBackColor = True
        '
        'bHapus
        '
        Me.bHapus.Location = New System.Drawing.Point(277, 272)
        Me.bHapus.Name = "bHapus"
        Me.bHapus.Size = New System.Drawing.Size(99, 37)
        Me.bHapus.TabIndex = 10
        Me.bHapus.Text = "Hapus"
        Me.bHapus.UseVisualStyleBackColor = True
        '
        'bTutup
        '
        Me.bTutup.Location = New System.Drawing.Point(382, 272)
        Me.bTutup.Name = "bTutup"
        Me.bTutup.Size = New System.Drawing.Size(99, 37)
        Me.bTutup.TabIndex = 11
        Me.bTutup.Text = "Tutup"
        Me.bTutup.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 369)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(836, 227)
        Me.DataGridView1.TabIndex = 0
        '
        'tSearch
        '
        Me.tSearch.Location = New System.Drawing.Point(19, 345)
        Me.tSearch.Name = "tSearch"
        Me.tSearch.Size = New System.Drawing.Size(378, 20)
        Me.tSearch.TabIndex = 12
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2, Me.ToolStripLabel3})
        Me.ToolStrip1.Location = New System.Drawing.Point(9, 608)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(273, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(87, 22)
        Me.ToolStripLabel1.Text = "ToolStripLabel1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(87, 22)
        Me.ToolStripLabel2.Text = "ToolStripLabel2"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(87, 22)
        Me.ToolStripLabel3.Text = "ToolStripLabel3"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(547, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(309, 286)
        Me.Panel1.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(11, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(293, 39)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "PRODUCT MOBIL"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(36, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(251, 45)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "PENDATAAN"
        '
        'FormMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 636)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.bTutup)
        Me.Controls.Add(Me.bHapus)
        Me.Controls.Add(Me.bUbah)
        Me.Controls.Add(Me.bTambah)
        Me.Controls.Add(Me.cbCcMbl)
        Me.Controls.Add(Me.cbJnsMbl)
        Me.Controls.Add(Me.cbTipeMbl)
        Me.Controls.Add(Me.tNamaMbl)
        Me.Controls.Add(Me.tKet)
        Me.Controls.Add(Me.tHarga)
        Me.Controls.Add(Me.tKodeMbl)
        Me.Name = "FormMobil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pendataan Mobil"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tKodeMbl As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tNamaMbl As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tKet As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tHarga As TextBox
    Friend WithEvents cbTipeMbl As ComboBox
    Friend WithEvents cbJnsMbl As ComboBox
    Friend WithEvents cbCcMbl As ComboBox
    Friend WithEvents bTambah As Button
    Friend WithEvents bUbah As Button
    Friend WithEvents bHapus As Button
    Friend WithEvents bTutup As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tSearch As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
