Public Class menu1
    Dim hitung, a, sb As Integer

    Private Sub cb_daftarkamar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_daftarkamar.SelectedIndexChanged


        If cb_daftarkamar.Text = "Single Bad" Then
            tb_register.Text = "22029" + tb_nik.Text
            sb = 99000
        ElseIf cb_daftarkamar.Text = "Double Bad" Then
            tb_register.Text = "22030" + tb_nik.Text
            sb = 120000
        ElseIf cb_daftarkamar.Text = "Family Bad" Then
            tb_register.Text = "22031" + tb_nik.Text
            sb = 150000
        ElseIf cb_daftarkamar.Text = "Super Bad" Then
            tb_register.Text = "22032" + tb_nik.Text
            sb = 185000
        ElseIf cb_daftarkamar.Text = "King Bad" Then
            tb_register.Text = "22033" + tb_nik.Text
            sb = 210000
        End If



    End Sub

    Private Sub tb_nama_TextChanged(sender As Object, e As EventArgs) Handles tb_nama.TextChanged

    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Dim jk As String

        If RadioButton1.Checked = True Then
            jk = RadioButton1.Text
        Else
            jk = RadioButton2.Text
        End If

        a = jml_angota.Text
        hitung = a * sb
        hitung_v.Text = hitung
        nama_out.Text = tb_nama.Text
        regist_out.Text = tb_register.Text
        tb_nama.Text = " "
        tb_nik.Text = " "
        tb_alamat.Text = " "
        tb_email.Text = " "
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        tb_register.Text = " "
        cb_daftarkamar.SelectedItem = 1

        jml_angota.Text = " "


        menu2.DataGridView1.Rows.Add(1)
        menu2.DataGridView1.Rows(menu2.DataGridView1.RowCount - 2).Cells(0).Value = Label19.Text
        menu2.DataGridView1.Rows(menu2.DataGridView1.RowCount - 2).Cells(1).Value = tb_nama.Text
        menu2.DataGridView1.Rows(menu2.DataGridView1.RowCount - 2).Cells(2).Value = tb_nik.Text
        menu2.DataGridView1.Rows(menu2.DataGridView1.RowCount - 2).Cells(3).Value = tb_email.Text
        menu2.DataGridView1.Rows(menu2.DataGridView1.RowCount - 2).Cells(4).Value = tb_register.Text
        menu2.DataGridView1.Rows(menu2.DataGridView1.RowCount - 2).Cells(5).Value = jk
        menu2.DataGridView1.Rows(menu2.DataGridView1.RowCount - 2).Cells(6).Value = hitung_v.Text
        menu2.DataGridView1.Rows(menu2.DataGridView1.RowCount - 2).Cells(7).Value = tb_alamat.Text
        MsgBox("informasi Telah di Simpan", MsgBoxStyle.Information)

    End Sub


    Private Sub menu1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class