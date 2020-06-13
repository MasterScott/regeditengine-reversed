Imports System
Imports System.Windows.Forms

' Token: 0x02000009 RID: 9
Public Class Settings
    Dim Form1 As New Form1()
    ' Token: 0x060000B6 RID: 182 RVA: 0x00008990 File Offset: 0x00006B90
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If Me.ColorDialog1.ShowDialog() = DialogResult.OK Then
            Form1.BackColor = Me.ColorDialog1.Color
        End If
    End Sub

    ' Token: 0x060000B7 RID: 183 RVA: 0x000089CD File Offset: 0x00006BCD
    Private Sub TrackBar1_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles TrackBar1.Scroll
        Form1.Opacity = CDbl(Me.TrackBar1.Value) / 100.0
    End Sub
End Class
