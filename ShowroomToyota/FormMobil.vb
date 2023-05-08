Imports System.Data.SqlClient
Public Class FormMobil
    Sub KlikTambah()
        bUbah.Enabled = False
        bHapus.Enabled = False
        bTambah.Text = "Simpan"
        bTutup.Text = "Batal"
        cbTipeMbl.Enabled = True
        tNamaMbl.Enabled = True
        cbJnsMbl.Enabled = True
        cbCcMbl.Enabled = True
        tKet.Enabled = True
        tHarga.Enabled = True
    End Sub
    Sub KlikBatal()
        bUbah.Enabled = True
        bHapus.Enabled = True
        bTambah.Enabled = True
        bTutup.Text = "Tutup"
        bTambah.Text = "Tambah"
        bUbah.Text = "Ubah"
        tKodeMbl.Text = ""
        tNamaMbl.Text = ""
        tKet.Text = ""
        tHarga.Text = ""
        cbTipeMbl.Text = ""
        cbJnsMbl.Text = ""
        cbCcMbl.Text = ""
        cbTipeMbl.Enabled = False
        tNamaMbl.Enabled = False
        cbJnsMbl.Enabled = False
        cbCcMbl.Enabled = False
        tKet.Enabled = False
        tHarga.Enabled = False
    End Sub
    Sub KlikUbah()
        tKodeMbl.Enabled = False
        bTambah.Enabled = False
        bHapus.Enabled = False
        bTutup.Text = "Batal"
        bUbah.Text = "Simpan"
    End Sub
    Sub KlikHapus()
        bTambah.Enabled = False
        bUbah.Enabled = False
        bTutup.Text = "Batal"
    End Sub
    Sub Kosong()
        Me.Show()
        tKodeMbl.Clear()
        cbTipeMbl.SelectedIndex = -1
        tNamaMbl.Clear()
        cbJnsMbl.SelectedIndex = -1
        cbCcMbl.SelectedIndex = -1
        tKet.Clear()
        tHarga.Clear()
    End Sub
    Sub AturGrid()
        DataGridView1.Columns(0).Width = 60
        DataGridView1.Columns(1).Width = 60
        DataGridView1.Columns(2).Width = 140
        DataGridView1.Columns(3).Width = 60
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 100
        DataGridView1.Columns(6).Width = 100
        DataGridView1.Columns(7).Width = 100

        DataGridView1.Columns(0).HeaderText = "KODE MOBIL"
        DataGridView1.Columns(1).HeaderText = "TIPE"
        DataGridView1.Columns(2).HeaderText = "NAMA MOBIL"
        DataGridView1.Columns(3).HeaderText = "JENIS"
        DataGridView1.Columns(4).HeaderText = "CC"
        DataGridView1.Columns(5).HeaderText = "HARGA"
        DataGridView1.Columns(5).DefaultCellStyle.Format = "Rp #,###"
        DataGridView1.Columns(6).HeaderText = "TANGGAL INPUT"
        DataGridView1.Columns(7).HeaderText = "KETERANGAN"

    End Sub
    Sub TampilMbl()
        Call Koneksi()
        da = New SqlDataAdapter("SELECT * FROM tb_mobil", konek)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_hp")
        DataGridView1.DataSource = ds.Tables("tb_hp")
        DataGridView1.Refresh()
    End Sub

    Private Sub bTambah_Click(sender As Object, e As EventArgs) Handles bTambah.Click
        If bUbah.Enabled = True And bHapus.Enabled = True Then
            tKodeMbl.Text = ""
            tNamaMbl.Text = ""
            tKet.Text = ""
            tHarga.Text = ""
            cbTipeMbl.Text = ""
            cbJnsMbl.Text = ""
            cbCcMbl.Text = ""
        End If
        If tNamaMbl.Enabled = False Then
            Call KlikTambah()
            Call Koneksi()
            cmd = New SqlCommand("select * from tb_mobil where kode_mobil in (select max(kode_mobil) from tb_mobil)", konek)
            Dim UrutanKode As String
            Dim Hitung As Long
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                UrutanKode = "KM" + "001"
            Else
                Hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 3) + 1
                UrutanKode = "KM" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
            End If
            tKodeMbl.Text = UrutanKode
            tNamaMbl.Focus()
        ElseIf tKodeMbl.Text = "" Or tNamaMbl.Text = "" Or tKet.Text = "" Or tHarga.Text = "" Or cbTipeMbl.Text = "" Or cbJnsMbl.Text = "" Or cbCcMbl.Text = "" Then
            MsgBox("Data Belum Lengkap !")
        Else
            Call Koneksi()
            Dim Simpan As String
            Simpan = "INSERT INTO tb_mobil VALUES('" & tKodeMbl.Text & "','" & cbTipeMbl.Text & "','" & tNamaMbl.Text & "','" & cbJnsMbl.Text & "','" & cbCcMbl.Text & "','" & tHarga.Text & "','" & Date.Today() & "','" & tKet.Text & "')"
            cmd = New SqlCommand(Simpan, konek)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Terinput", MsgBoxStyle.Information, "information")
            Call KlikBatal()
            Call TampilMbl()
            Call Kosong()
            Call AturGrid()
        End If
    End Sub

    Private Sub bUbah_Click(sender As Object, e As EventArgs) Handles bUbah.Click
        Call KlikUbah()
        If tNamaMbl.Enabled = False And tKodeMbl.Enabled = False And tKodeMbl.TextLength > 0 Then
            tNamaMbl.Enabled = True
            tKet.Enabled = True
            tHarga.Enabled = True
            cbTipeMbl.Enabled = True
            cbJnsMbl.Enabled = True
            cbCcMbl.Enabled = True
            MsgBox("Silahkan Ubah Identitas Barang")
        ElseIf tNamaMbl.Text = "" Or tKodeMbl.Text = "" Then
            tNamaMbl.Enabled = False
            MsgBox("Silahkan Klik 2x Salah Satu List Merk Yang ada di List -->")
            Exit Sub
        ElseIf tNamaMbl.Enabled = True And bTambah.Enabled = False Then
            Call Koneksi()
            Dim Edit As String
            Edit = "UPDATE tb_mobil SET tipe_mobil='" & cbTipeMbl.Text & "', nama_mobil='" & tNamaMbl.Text & "', jenis_mobil='" & cbJnsMbl.Text & "', cc_mobil='" & cbCcMbl.Text & "', keterangan='" & tKet.Text & "', harga='" & tHarga.Text & "' WHERE kode_mobil='" & tKodeMbl.Text & "'"
            cmd = New SqlCommand(Edit, konek)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Diubah", MsgBoxStyle.Information, "Information")
            tNamaMbl.Enabled = False
            tKet.Enabled = False
            tHarga.Enabled = False
            cbTipeMbl.Enabled = False
            cbJnsMbl.Enabled = False
            cbCcMbl.Enabled = False
            Call TampilMbl()
            Call Kosong()
        End If

    End Sub

    Private Sub bHapus_Click(sender As Object, e As EventArgs) Handles bHapus.Click
        Call KlikHapus()
        If tKodeMbl.Text = "" Then
            MsgBox("Silahkan Klik 2x Salah Satu List Merk Yang ada di List -->")
        Else
            Call Koneksi()
            Dim Hapus As String
            Hapus = "DELETE FROM tb_mobil WHERE kode_mobil='" & tKodeMbl.Text & "'"
            cmd = New SqlCommand(Hapus, konek)
            Select Case MsgBox("Yakin menghapus ?", MsgBoxStyle.YesNo, "Hapus Data")
                Case MsgBoxResult.Yes
                    tNamaMbl.Enabled = False
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Data Berhasil Dihapus")
                Case MsgBoxResult.No
                    tNamaMbl.Enabled = False
            End Select
            Call TampilMbl()
            Call Kosong()
        End If
    End Sub

    Private Sub bTutup_Click(sender As Object, e As EventArgs) Handles bTutup.Click
        If bTambah.Enabled = False Or bUbah.Enabled = False Or bHapus.Enabled = False Then
            Call KlikBatal()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub FormHp_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Koneksi()
        Call TampilMbl()
        Call Kosong()
        Call AturGrid()
        ToolStripLabel1.Text = "(MOBIL)"
        ToolStripLabel2.Text = "(" & FormMenu.ToolStripStatusLabel2.Text & ")"
        ToolStripLabel3.Text = "(" & Date.Today().ToString("dddd, d MMM yyyy") & ")"
        tKodeMbl.Enabled = False
        cbTipeMbl.Enabled = False
        tNamaMbl.Enabled = False
        cbJnsMbl.Enabled = False
        cbCcMbl.Enabled = False
        tKet.Enabled = False
        tHarga.Enabled = False
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        If bUbah.Enabled = False And bHapus.Enabled = False Then
            MsgBox("Silahkan Isi Field Form")
        End If
        Call Koneksi()
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        cmd = New SqlCommand("SELECT * FROM tb_mobil WHERE kode_mobil='" & DataGridView1.Item(0, i).Value & "'", konek)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            tNamaMbl.Focus()
        Else
            tKodeMbl.Text = rd.Item("kode_mobil")
            tNamaMbl.Text = rd.Item("nama_mobil")
            tKet.Text = rd.Item("keterangan")
            tHarga.Text = rd.Item("harga")
            cbTipeMbl.Text = rd.Item("tipe_mobil")
            cbJnsMbl.Text = rd.Item("jenis_mobil")
            cbCcMbl.Text = rd.Item("cc_mobil")
            tNamaMbl.Focus()
            If bHapus.Enabled = False Then
                tNamaMbl.Enabled = True
                tKet.Enabled = True
                tHarga.Enabled = True
                cbTipeMbl.Enabled = True
                cbJnsMbl.Enabled = True
                cbCcMbl.Enabled = True
            ElseIf bUbah.Enabled = False Then
                tNamaMbl.Enabled = False
                tKet.Enabled = False
                tHarga.Enabled = False
                cbTipeMbl.Enabled = False
                cbJnsMbl.Enabled = False
                cbCcMbl.Enabled = False
            End If

        End If

    End Sub

    Private Sub tSearch_TextChanged(sender As Object, e As EventArgs) Handles tSearch.TextChanged
        Call Koneksi()
        cmd = New SqlCommand("SELECT * FROM tb_mobil WHERE kode_mobil LIKE '%" & tSearch.Text & "%' OR tipe_mobil LIKE '%" & tSearch.Text & "%' OR nama_mobil LIKE '%" & tSearch.Text & "%' OR jenis_mobil LIKE '%" & tSearch.Text & "%'", konek)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Call Koneksi()
            da = New SqlDataAdapter("SELECT * FROM tb_mobil WHERE kode_mobil LIKE '%" & tSearch.Text & "%' OR tipe_mobil LIKE '%" & tSearch.Text & "%' OR nama_mobil LIKE '%" & tSearch.Text & "%' OR jenis_mobil LIKE '%" & tSearch.Text & "%'", konek)
            ds = New DataSet
            da.Fill(ds, "ketemu")
            DataGridView1.DataSource = ds.Tables("ketemu")
            DataGridView1.ReadOnly = True
        Else
            MsgBox("Data Tidak Ditemukan")
        End If

    End Sub

    Private Sub cbKodeMerk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbTipeMbl.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub cbRam_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbJnsMbl.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub cbRom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbCcMbl.KeyPress
        e.KeyChar = Chr(0)
    End Sub
End Class