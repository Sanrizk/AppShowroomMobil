Imports System.Data.SqlClient
Public Class FormPengiriman
    Dim harga, jumlah, total As Double
    Sub KlikTambah()
        bUbah.Enabled = False
        bHapus.Enabled = False
        bTambah.Text = "Simpan"
        bTutup.Text = "Batal"
        cbKodeMbl.Enabled = True
        tNamaCab.Enabled = True
        tJumlah.Enabled = True
        tKet.Enabled = True
    End Sub
    Sub KlikBatal()
        bUbah.Enabled = True
        bHapus.Enabled = True
        bTambah.Enabled = True
        bTutup.Text = "Tutup"
        bTambah.Text = "Tambah"
        bUbah.Text = "Ubah"
        tKodeKrm.Enabled = False
        cbKodeMbl.Enabled = False
        tNamaCab.Enabled = False
        tJumlah.Enabled = False
        tKet.Enabled = False
        tKodeKrm.Text = ""
        cbKodeMbl.Text = ""
        tNamaCab.Text = ""
        tJumlah.Text = ""
        tKet.Text = ""
    End Sub
    Sub KlikUbah()
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
        tKodeKrm.Text = ""
        cbKodeMbl.Text = ""
        tNamaCab.Text = ""
        tJumlah.Text = ""
        tKet.Text = ""
    End Sub
    Sub AturGrid()
        DataGridView1.Columns(0).Width = 60
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 70
        DataGridView1.Columns(5).Width = 100

        DataGridView1.Columns(0).HeaderText = "KODE KIRIM"
        DataGridView1.Columns(1).HeaderText = "NAMA MOBIL"
        DataGridView1.Columns(2).HeaderText = "NAMA CABANG"
        DataGridView1.Columns(3).HeaderText = "JUMLAH"
        DataGridView1.Columns(4).HeaderText = "TANGGAL KIRIM"
        DataGridView1.Columns(5).HeaderText = "KETERANGAN"

    End Sub
    Sub TampilPengiriman()
        Call Koneksi()
        da = New SqlDataAdapter("select kode_kirim, nama_mobil, nama_cabang, jumlah, tanggal_kirim, tb_pengiriman.keterangan from tb_pengiriman inner join tb_mobil on tb_pengiriman.kode_mobil = tb_mobil.kode_mobil", konek)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_pengiriman")
        DataGridView1.DataSource = ds.Tables("tb_pengiriman")
        DataGridView1.Refresh()
    End Sub
    Sub TampilMobil()
        cmd = New SqlCommand("SELECT kode_mobil, nama_mobil FROM tb_mobil", konek)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cbKodeMbl.Items.Add(rd.Item("kode_mobil") + "  |  " + rd.Item("nama_mobil"))
        Loop
    End Sub


    Private Sub bTambah_Click(sender As Object, e As EventArgs) Handles bTambah.Click
        If bUbah.Enabled = True And bHapus.Enabled = True Then
            tKodeKrm.Text = ""
            tNamaCab.Text = ""
            tJumlah.Text = ""
            tKet.Text = ""
            cbKodeMbl.Text = ""
        End If
        If tNamaCab.Enabled = False Then
            Call KlikTambah()
            Call Koneksi()
            cmd = New SqlCommand("select * from tb_pengiriman where kode_kirim in (select max(kode_kirim) from tb_pengiriman)", konek)
            Dim UrutanKode As String
            Dim Hitung As Long
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                UrutanKode = "KK" + "001"
            Else
                Hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 3) + 1
                UrutanKode = "KK" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
            End If
            tKodeKrm.Text = UrutanKode
            cbKodeMbl.Focus()
        ElseIf tKodeKrm.Text = "" Or tNamaCab.Text = "" Or cbKodeMbl.Text = "" Or tJumlah.Text = "" Or tKet.Text = "" Then
            MsgBox("Data Belum Lengkap !")
        Else
            Call Koneksi()
            Dim Simpan As String
            Simpan = "INSERT INTO tb_pengiriman VALUES('" & tKodeKrm.Text & "','" & cbKodeMbl.Text.Substring(0, 5) & "','" & tNamaCab.Text & "','" & tJumlah.Text & "','" & Date.Today() & "','" & tKet.Text & "')"
            cmd = New SqlCommand(Simpan, konek)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Terinput", MsgBoxStyle.Information, "information")
            Call KlikBatal()
            Call TampilPengiriman()
            Call Kosong()
            Call AturGrid()
        End If
    End Sub

    Private Sub bUbah_Click(sender As Object, e As EventArgs) Handles bUbah.Click
        Call KlikUbah()
        If tNamaCab.Enabled = False And tKodeKrm.Enabled = False And tKodeKrm.TextLength > 0 Then
            cbKodeMbl.Enabled = True
            tNamaCab.Enabled = True
            tJumlah.Enabled = True
            tKet.Enabled = True
            MsgBox("Silahkan Ubah Identitas Barang")
        ElseIf tNamaCab.Text = "" Or tKodeKrm.Text = "" Then
            tNamaCab.Enabled = False
            MsgBox("Silahkan Klik 2x Salah Satu List Merk Yang ada di List -->")
            Exit Sub
        ElseIf tNamaCab.Enabled = True And bTambah.Enabled = False Then
            Call Koneksi()
            Dim Edit As String
            Edit = "UPDATE tb_pengiriman SET kode_mobil='" & cbKodeMbl.Text.Substring(0, 5) & "', nama_cabang='" & tNamaCab.Text & "', jumlah='" & tJumlah.Text & "', keterangan='" & tKet.Text & "' WHERE kode_kirim='" & tKodeKrm.Text & "'"
            cmd = New SqlCommand(Edit, konek)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Diubah", MsgBoxStyle.Information, "Information")
            cbKodeMbl.Enabled = False
            tNamaCab.Enabled = False
            tJumlah.Enabled = False
            tKet.Enabled = False
            Call TampilPengiriman()
            Call Kosong()
        End If
    End Sub

    Private Sub bHapus_Click(sender As Object, e As EventArgs) Handles bHapus.Click
        Call KlikHapus()
        If tKodeKrm.Text = "" Then
            MsgBox("Silahkan Klik 2x Salah Satu List Merk Yang ada di List -->")
        Else
            Call Koneksi()
            Dim Hapus As String
            Hapus = "DELETE FROM tb_pengiriman WHERE kode_kirim='" & tKodeKrm.Text & "'"
            cmd = New SqlCommand(Hapus, konek)
            Select Case MsgBox("Yakin menghapus ?", MsgBoxStyle.YesNo, "Hapus Data")
                Case MsgBoxResult.Yes
                    tNamaCab.Enabled = False
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Data Berhasil Dihapus")
                Case MsgBoxResult.No
                    tNamaCab.Enabled = False
            End Select
            Call TampilPengiriman()
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

    Private Sub FormPembelian_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Koneksi()
        Call TampilMobil()
        Call TampilPengiriman()
        Call AturGrid()
        ToolStripLabel1.Text = "(PENGIRIMAN)"
        ToolStripLabel2.Text = "(" & FormMenu.ToolStripStatusLabel2.Text & ")"
        ToolStripLabel3.Text = "(" & Date.Today().ToString("dddd, d MMM yyyy") & ")"
        tKodeKrm.Enabled = False
        cbKodeMbl.Enabled = False
        tNamaCab.Enabled = False
        tJumlah.Enabled = False
        tKet.Enabled = False
    End Sub

    Private Sub cbKodeBrgB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbKodeMbl.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub tJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tJumlah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        If bUbah.Enabled = False And bHapus.Enabled = False Then
            MsgBox("Silahkan Isi Field Form")
        End If
        Call Koneksi()
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        cmd = New SqlCommand("SELECT kode_kirim, tb_pengiriman.kode_mobil, nama_mobil, nama_cabang, jumlah, tb_pengiriman.tanggal_kirim, tb_pengiriman.keterangan FROM tb_pengiriman INNER JOIN tb_mobil on tb_pengiriman.kode_mobil = tb_mobil.kode_mobil WHERE kode_kirim='" & DataGridView1.Item(0, i).Value & "'", konek)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            tNamaCab.Focus()
        Else
            tKodeKrm.Text = rd.Item("kode_kirim")
            cbKodeMbl.Text = rd.Item("kode_mobil") + "  |  " + rd.Item("nama_mobil")
            tNamaCab.Text = rd.Item("nama_cabang")
            tJumlah.Text = rd.Item("jumlah")
            tKet.Text = rd.Item("keterangan")
            tKodeKrm.Focus()
            If bHapus.Enabled = False Then
                cbKodeMbl.Enabled = True
                tNamaCab.Enabled = True
                tJumlah.Enabled = True
                tKet.Enabled = True
            ElseIf bUbah.Enabled = False Then
                cbKodeMbl.Enabled = False
                tNamaCab.Enabled = False
                tJumlah.Enabled = False
                tKet.Enabled = False
            End If

        End If

    End Sub

    Private Sub tSearch_TextChanged(sender As Object, e As EventArgs) Handles tSearch.TextChanged
        Call Koneksi()
        cmd = New SqlCommand("select kode_kirim, nama_mobil, nama_cabang, jumlah, tanggal_kirim, tb_pengiriman.keterangan from tb_pengiriman inner join tb_mobil on tb_pengiriman.kode_mobil = tb_mobil.kode_mobil WHERE kode_kirim LIKE '%" & tSearch.Text & "%' OR nama_mobil LIKE '%" & tSearch.Text & "%' OR nama_cabang LIKE '%" & tSearch.Text & "%'", konek)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Call Koneksi()
            da = New SqlDataAdapter("select kode_kirim, nama_mobil, nama_cabang, jumlah, tanggal_kirim, tb_pengiriman.keterangan from tb_pengiriman inner join tb_mobil on tb_pengiriman.kode_mobil = tb_mobil.kode_mobil WHERE kode_kirim LIKE '%" & tSearch.Text & "%' OR nama_mobil LIKE '%" & tSearch.Text & "%' OR nama_cabang LIKE '%" & tSearch.Text & "%'", konek)
            ds = New DataSet
            da.Fill(ds, "ketemu")
            DataGridView1.DataSource = ds.Tables("ketemu")
            DataGridView1.ReadOnly = True
        Else
            MsgBox("Data Tidak Ditemukan")
        End If

    End Sub
End Class