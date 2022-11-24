Public Class Form1

    Sub switchPanel(ByVal panel As Form)
        Main_panel.Controls.Clear()
        panel.TopLevel = False
        Main_panel.Controls.Add(panel)
        panel.Show()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lbl1.Visible = False
        lbl2.Visible = True
        lbl3.Visible = False
        lbl4.Visible = False
        switchPanel(menu2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lbl1.Visible = True
        lbl2.Visible = False
        lbl3.Visible = False
        lbl4.Visible = False
        switchPanel(menu1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lbl1.Visible = False
        lbl2.Visible = False
        'lbl3.Visible = True
        lbl4.Visible = False
        MsgBox("Masih dalam pengembangan", MsgBoxStyle.Information)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        lbl1.Visible = False
        lbl2.Visible = False
        lbl3.Visible = False
        lbl4.Visible = True
        switchPanel(menu4)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl1.Visible = True
        lbl2.Visible = False
        lbl3.Visible = False
        lbl4.Visible = False
        switchPanel(menu1)
    End Sub


    Private Sub Main_panel_Paint(sender As Object, e As PaintEventArgs) Handles Main_panel.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim konfirmasi As String
        konfirmasi = MsgBox("Anda yakin ingin keluar..?", vbQuestion + vbYesNo, "Konfirmasi")
        If konfirmasi = vbYes Then
            Close()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
