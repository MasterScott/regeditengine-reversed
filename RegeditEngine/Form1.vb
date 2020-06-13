Imports System
'Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
'Imports System.RuntiCompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
'Imports Microsoft.VisualBasic.CompilerServices

Public Class Form1

    ' Token: 0x06000016 RID: 22 RVA: 0x00002358 File Offset: 0x00000558
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        RichTextBox1.SelectionColor = Color.Purple
        RichTextBox1.AppendText("REGEDIT." + TextBox2.Text)
        GroupBox1.Enabled = False
        GroupBox2.Enabled = True
    End Sub

    ' Token: 0x06000017 RID: 23 RVA: 0x000023B4 File Offset: 0x000005B4
    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer2.Tick
        If TextBox1.Text = Nothing Then
            Button2.Enabled = False
        Else
            Button2.Enabled = True
        End If
    End Sub

    ' Token: 0x06000018 RID: 24 RVA: 0x00002400 File Offset: 0x00000600
    Private Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.SelectionColor = Color.Red
            RichTextBox1.AppendText("[HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters]")
            RichTextBox1.SelectionColor = Color.Black
            RichTextBox1.AppendText(vbCrLf)
            Dim obj As Object = """"
            RichTextBox1.AppendText(obj & "TcpNoDelay" & obj & "=dword:0000000" & NumericUpDown1.Value)
            RichTextBox1.AppendText(vbCrLf)
        End If
    End Sub

    ' Token: 0x06000019 RID: 25 RVA: 0x000024D0 File Offset: 0x000006D0
    Private Sub CheckBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.SelectionColor = Color.Red
            RichTextBox1.AppendText("[HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces]")
            RichTextBox1.SelectionColor = Color.Black
            RichTextBox1.AppendText(vbCrLf)
            Dim obj As Object = """"
            RichTextBox1.AppendText(obj & "TcpAckFrequency" & obj & "=dword:0000000" & NumericUpDown2.Value)
            RichTextBox1.AppendText(vbCrLf)
        End If
    End Sub

    ' Token: 0x0600001A RID: 26 RVA: 0x000025A0 File Offset: 0x000007A0
    Private Sub CheckBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.SelectionColor = Color.Red
            RichTextBox1.AppendText("[HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces]")
            RichTextBox1.SelectionColor = Color.Black
            RichTextBox1.AppendText(vbCrLf)
            Dim obj As Object = """"
            RichTextBox1.AppendText(obj & "TcpDelAckTicks" & obj & "=dword:0000000" & NumericUpDown3.Value)
            RichTextBox1.AppendText(vbCrLf)
        End If
    End Sub

    ' Token: 0x0600001B RID: 27 RVA: 0x00002670 File Offset: 0x00000870
    Private Sub CheckBox4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.SelectionColor = Color.Red
            RichTextBox1.AppendText("[HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces]")
            RichTextBox1.SelectionColor = Color.Black
            RichTextBox1.AppendText(vbCrLf)
            Dim obj As Object = """"
            RichTextBox1.AppendText(obj & "MouseSpeed" & obj & "=" & obj & "0" & obj)
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "MouseThreshold1" & obj & "=" & obj & "0" & obj)
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "MouseThreshold2" & obj & "=" & obj & "0" & obj)
            RichTextBox1.AppendText(vbCrLf)
        End If
    End Sub

    ' Token: 0x0600001C RID: 28 RVA: 0x000027E8 File Offset: 0x000009E8
    Private Sub CheckBox5_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked Then
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.SelectionColor = Color.Red
            RichTextBox1.AppendText("[HKEY_CURRENT_USER\Control Panel\Accessibility\Keyboard Response]")
            RichTextBox1.SelectionColor = Color.Black
            RichTextBox1.AppendText(vbCrLf)
            Dim obj As Object = """"
            RichTextBox1.AppendText(obj & "AutoRepeatDelay" & obj & "=" & obj & "200" & obj)
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "AutoRepeatRate" & obj & "=" & obj & "15" & obj)
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "BounceTime" & obj & "=" & obj & "0" & obj)
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "DelayBeforeAcceptance" & obj & "=" & obj & "0" & obj)
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "Flags" & obj & "=" & obj & "59" & obj)
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "Last BounceKey Setting" & obj & "=dword:00000000")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "Last Valid Repeat" & obj & "=dword:00000000")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "Last Valid Wait" & obj & "=dword:000003e8")
            RichTextBox1.AppendText(vbCrLf)
        End If
    End Sub

    ' Token: 0x0600001D RID: 29 RVA: 0x00002ABC File Offset: 0x00000CBC
    Private Sub CheckBox6_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked Then
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.SelectionColor = Color.Red
            RichTextBox1.AppendText("[HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Psched]")
            RichTextBox1.SelectionColor = Color.Black
            RichTextBox1.AppendText(vbCrLf)
            Dim obj As Object = """"
            RichTextBox1.AppendText(obj & "NonBestEffortLimit" & obj & "=dword:00000000")
            RichTextBox1.AppendText(vbCrLf)
        End If
    End Sub

    ' Token: 0x0600001E RID: 30 RVA: 0x00002B78 File Offset: 0x00000D78
    Private Sub CheckBox7_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked Then
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.SelectionColor = Color.Red
            RichTextBox1.AppendText("[HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters]")
            RichTextBox1.SelectionColor = Color.Black
            RichTextBox1.AppendText(vbCrLf)
            Dim obj As Object = """"
            RichTextBox1.AppendText(obj & "TcpNoDelay" & obj & "=dword:1288fff")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TCPDelAckTicks" & obj & "=dword:1288fff")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TcpMaxDataRetransmissions" & obj & "=dword:00000003")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "SackOpts" & obj & "=dword:00000001")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TcpWindowSize" & obj & "=dword:0005ae4c")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "Tcp1323Opts" & obj & "=dword:00000003")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "DefaultTTL" & obj & "=dword:7fff")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "EnablePMTUBHDetect" & obj & "=dword:00000000")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "EnablePMTUDiscovery" & obj & "=dword:00000001")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "GlobalMaxTcpWindowSize" & obj & "=dword:0005ae4c")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TcpTimedWaitDelay" & obj & " dword:30")
            RichTextBox1.AppendText(vbCrLf)
        End If
    End Sub

    ' Token: 0x0600001F RID: 31 RVA: 0x00002E94 File Offset: 0x00001094
    Private Sub CheckBox8_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked Then
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.SelectionColor = Color.Red
            RichTextBox1.AppendText("[HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters]")
            RichTextBox1.SelectionColor = Color.Black
            RichTextBox1.AppendText(vbCrLf)
            Dim obj As Object = """"
            RichTextBox1.AppendText(obj & "TcpAckFrequency" & obj & "=dword:650")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TcpNoDelay" & obj & "=dword:650")
            RichTextBox1.AppendText(vbCrLf)
        End If
    End Sub

    ' Token: 0x06000020 RID: 32 RVA: 0x00002F8C File Offset: 0x0000118C
    Private Sub CheckBox9_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked Then
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.SelectionColor = Color.Red
            RichTextBox1.AppendText("[HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters]")
            RichTextBox1.SelectionColor = Color.Black
            RichTextBox1.AppendText(vbCrLf)
            Dim obj As Object = """"
            RichTextBox1.AppendText(obj & "TcpNoDelay" & obj & "=dword:-1")
            RichTextBox1.AppendText(vbCrLf)
        End If
    End Sub

    ' Token: 0x06000021 RID: 33 RVA: 0x00003048 File Offset: 0x00001248
    Private Sub CheckBox10_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked Then
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.SelectionColor = Color.Red
            RichTextBox1.AppendText("[HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters]")
            RichTextBox1.SelectionColor = Color.Black
            RichTextBox1.AppendText(vbCrLf)
            Dim obj As Object = """"
            RichTextBox1.AppendText(obj & "TcpNoDelay" & obj & "=dword:75")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TcpAckFrequency" & obj & "=dword:75")
            RichTextBox1.AppendText(vbCrLf)
        End If
    End Sub

    ' Token: 0x06000022 RID: 34 RVA: 0x00003140 File Offset: 0x00001340
    Private Sub CheckBox11_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked Then
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.SelectionColor = Color.Red
            RichTextBox1.AppendText("[HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters]")
            RichTextBox1.SelectionColor = Color.Black
            RichTextBox1.AppendText(vbCrLf)
            Dim obj As Object = """"
            RichTextBox1.AppendText(obj & "TcpNoDelay" & obj & "=dword:-1")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TcpAckFrequency" & obj & "=dword:1")
            RichTextBox1.AppendText(vbCrLf)
        End If
    End Sub

    ' Token: 0x06000023 RID: 35 RVA: 0x00003238 File Offset: 0x00001438
    Private Sub CheckBox12_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.Checked Then
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.SelectionColor = Color.Red
            RichTextBox1.AppendText("[HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\PriorityControl]")
            RichTextBox1.SelectionColor = Color.Black
            RichTextBox1.AppendText(vbCrLf)
            Dim obj As Object = """"
            RichTextBox1.AppendText(obj & "Win32PrioritySeparation" & obj & "=dword:00000026")
            RichTextBox1.AppendText(vbCrLf)
        End If
    End Sub

    ' Token: 0x06000024 RID: 36 RVA: 0x000032F4 File Offset: 0x000014F4
    Private Sub CheckBox13_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox13.CheckedChanged
        If CheckBox13.Checked Then
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.SelectionColor = Color.Red
            RichTextBox1.AppendText("[HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters]")
            RichTextBox1.SelectionColor = Color.Black
            RichTextBox1.AppendText(vbCrLf)
            Dim obj As Object = """"
            RichTextBox1.AppendText(obj & "TcpNoDelay" & obj & "=dword:7fff")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TcpAckFrequency" & obj & "=dword:1")
            RichTextBox1.AppendText(vbCrLf)
        End If
    End Sub

    ' Token: 0x06000025 RID: 37 RVA: 0x000033EC File Offset: 0x000015EC
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim streamWriter As StreamWriter = New StreamWriter(SaveFileDialog1.FileName)
            streamWriter.Write(TextBox3.Text)
            streamWriter.Close()
        End If
    End Sub

    ' Token: 0x06000026 RID: 38 RVA: 0x00003438 File Offset: 0x00001638
    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        GroupBox2.Enabled = False
        TextBox3.Text = RichTextBox1.Text
        Button1.Enabled = True
    End Sub

    ' Token: 0x06000027 RID: 39 RVA: 0x0000346C File Offset: 0x0000166C
    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        RichTextBox1.Clear()
        GroupBox1.Enabled = True
        GroupBox2.Enabled = False
    End Sub

    ' Token: 0x06000028 RID: 40 RVA: 0x00003498 File Offset: 0x00001698
    Private Sub CheckBox14_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox14.CheckedChanged
        If CheckBox14.Checked Then
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.SelectionColor = Color.Red
            RichTextBox1.AppendText("[HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters]")
            RichTextBox1.SelectionColor = Color.Black
            RichTextBox1.AppendText(vbCrLf)
            Dim obj As Object = """"
            RichTextBox1.AppendText(obj & "EnablePMTUBHDetect" & obj & "=dword:00000000")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "EnablePMTUDiscovery" & obj & "=dword:00000000")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TcpMaxDupAcks" & obj & "=dword:00000003")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "GlobalMaxTcpWindowSize" & obj & "=dword:0036005f")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "MTU" & obj & "=dword:000005dc")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "MSS" & obj & "=dword:000005b4")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "MaxUserPort" & obj & "=dword:00065534")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "MaxHashTableSize" & obj & "=dword:00001000")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TcpTimedWaitDelay" & obj & "=dword:0000001e")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "DisableTaskOffload" & obj & "=dword:00000001")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "EnableWsd" & obj & "=dword:00000000")
            RichTextBox1.AppendText(vbCrLf)
        End If
    End Sub

    ' Token: 0x06000029 RID: 41 RVA: 0x000037B4 File Offset: 0x000019B4
    Private Sub CheckBox15_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox15.CheckedChanged
        If CheckBox15.Checked Then
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.SelectionColor = Color.Red
            RichTextBox1.AppendText("[HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\AFD\Parameters]")
            RichTextBox1.SelectionColor = Color.Black
            RichTextBox1.AppendText(vbCrLf)
            Dim obj As Object = """"
            RichTextBox1.AppendText(obj & "DefaultReceiveWindow" & obj & "=dword:0036005f")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "DefaultSendWindow" & obj & "=dword:00000001")
            RichTextBox1.AppendText(vbCrLf)
        End If
    End Sub

    ' Token: 0x0600002A RID: 42 RVA: 0x000038AC File Offset: 0x00001AAC
    Private Sub CheckBox16_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox16.CheckedChanged
        If CheckBox16.Checked Then
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.SelectionColor = Color.Red
            RichTextBox1.AppendText("[HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters]")
            RichTextBox1.SelectionColor = Color.Black
            RichTextBox1.AppendText(vbCrLf)
            Dim obj As Object = """"
            RichTextBox1.AppendText(obj & "TcpMaxDataRetransmissions" & obj & "=dword:00000003")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "SackOpts" & obj & "=dword:00000001")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TcpWindowSize" & obj & "=dword:0005ae4c")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "Tcp1323Opts" & obj & "=dword:00000003")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "DefaultTTL" & obj & "=dword:7fff")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "EnablePMTUBHDetect" & obj & "=dword:00000000")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "EnablePMTUDiscovery" & obj & "=dword:00000001")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "GlobalMaxTcpWindowSize" & obj & "=dword-:0005ae4c")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TcpTimedWaitDelay" & obj & " dword:30")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TcpNumConnections" & obj & " dword:7fff")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TcpMaxDupAcks" & obj & " dword:2")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TcpWindowSize" & obj & " dword:7fff")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "WorldMaxTcpWindowsSize" & obj & " dword:7")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TCPInitialRtt" & obj & " dword:7fff")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "IRPStackSize" & obj & " dword:50")
            RichTextBox1.AppendText(vbCrLf)
        End If
    End Sub

    ' Token: 0x0600002B RID: 43 RVA: 0x00003CBC File Offset: 0x00001EBC
    Private Sub CheckBox17_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox17.CheckedChanged
        If CheckBox17.Checked Then
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.SelectionColor = Color.Red
            RichTextBox1.AppendText("[HKEY_LOCAL_MACHINE\SOFTWARE\OfficialHawk\Minecraft]")
            RichTextBox1.SelectionColor = Color.Black
            RichTextBox1.AppendText(vbCrLf)
            Dim obj As Object = """"
            RichTextBox1.AppendText(obj & "Version" & obj & "=" & obj & "1.7.10" & obj)
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "Path" & obj & "=" & obj & "C:\\USER\\AppData\\Roaming\\.minecraft\\versions\\" & obj)
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TcpAckFrequency" & obj & "=dword:00000000")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "MTU" & obj & "=dword:00001457")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "MSS" & obj & "=dword:00000539")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "DefaultTTL" & obj & "=dword:00000064")
            RichTextBox1.AppendText(vbCrLf)
        End If
    End Sub

    ' Token: 0x0600002C RID: 44 RVA: 0x00003ED4 File Offset: 0x000020D4
    Private Sub CheckBox18_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox18.CheckedChanged
        If CheckBox18.Checked Then
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.SelectionColor = Color.Red
            RichTextBox1.AppendText("[HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters]")
            RichTextBox1.SelectionColor = Color.Black
            RichTextBox1.AppendText(vbCrLf)
            Dim obj As Object = """"
            RichTextBox1.AppendText(obj & "MaxConnectionsPerServer" & obj & "=dword:00000010")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "MaxConnectionsPer1_0Server" & obj & "=dword:00000010")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "IRPStackSize" & obj & "=dword:00000040")
            RichTextBox1.AppendText(vbCrLf)
        End If
    End Sub

    ' Token: 0x0600002D RID: 45 RVA: 0x00004008 File Offset: 0x00002208
    Private Sub CheckBox19_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox19.CheckedChanged
        If CheckBox19.Checked Then
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.SelectionColor = Color.Red
            RichTextBox1.AppendText("[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games]")
            RichTextBox1.SelectionColor = Color.Black
            RichTextBox1.AppendText(vbCrLf)
            Dim obj As Object = """"
            RichTextBox1.AppendText(obj & "Affinity" & obj & "=dword:00000000")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "Background Only" & obj & "=" & obj & "False" & obj)
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "Clock Rate" & obj & "=dword:00002710")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "GPU Priority" & obj & "=dword:00000008")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "Priority" & obj & "=dword:00000002")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "Scheduling Category" & obj & "=" & obj & "High" & obj)
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "SFIO Priority" & obj & "=" & obj & "High" & obj)
            RichTextBox1.AppendText(vbCrLf)
        End If
    End Sub

    ' Token: 0x0600002E RID: 46 RVA: 0x00004274 File Offset: 0x00002474
    Private Sub CheckBox20_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox20.CheckedChanged
        If CheckBox20.Checked Then
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.SelectionColor = Color.Red
            RichTextBox1.AppendText("[HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\LanmanServer\Parameters]")
            RichTextBox1.SelectionColor = Color.Black
            RichTextBox1.AppendText(vbCrLf)
            Dim obj As Object = """"
            RichTextBox1.AppendText(obj & "IRPStackSize" & obj & "=dword:00000032")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "SizReqBuf" & obj & "=dword:00017424")
            RichTextBox1.AppendText(vbCrLf)
        End If
    End Sub

    ' Token: 0x0600002F RID: 47 RVA: 0x0000436B File Offset: 0x0000256B
    Private Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
        Dim Settings As New Settings()
        Settings.Show()
    End Sub

    ' Token: 0x06000030 RID: 48 RVA: 0x00004380 File Offset: 0x00002580
    Private Sub CheckBox21_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox21.CheckedChanged
        If CheckBox21.Checked Then
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.SelectionColor = Color.Red
            RichTextBox1.AppendText("[HKEY_LOCAL_MACHINE\SOFTWARE\OfficialHawk\Minecraft]")
            RichTextBox1.SelectionColor = Color.Black
            RichTextBox1.AppendText(vbCrLf)
            Dim obj As Object = """"
            RichTextBox1.AppendText(obj & "Version" & obj & "=" & obj & "1.9.4" & obj)
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "Path" & obj & "=" & obj & "C:\Users\Owner\AppData\Roaming\.minecraft\" & obj)
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "Tcp1323Opts" & obj & "=dword:00000003")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "MaxFreeTcbs" & obj & "=dword:00065536")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "MaxUserPort" & obj & "=dword:00065534")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "DefaultTTL" & obj & "=dword:00000064")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "GlobalMaxTcpWindowSize" & obj & "=dword:00017520")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TCPNoDelay" & obj & "=dword:00000001")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TCPDelAckTicks" & obj & "=dword:00000000")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "DefaultRCVWindow" & obj & "=dword:00017032")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "MaxConnectionsPerServer" & obj & "=dword:00000016")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "MaxConnectionsPer1_0Server" & obj & "=dword:00000016")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "Version" & obj & "=" & obj & "1.9.4" & obj)
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "Path" & obj & "=" & obj & "C:\Users\Owner\AppData\Roaming\.minecraft\" & obj)
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "Tcp1323Opts" & obj & "=dword:00000003")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "MaxFreeTcbs" & obj & "=dword:00065536")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "MaxUserPort" & obj & "=dword:00065534")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "DefaultTTL" & obj & "=dword:00000064")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "GlobalMaxTcpWindowSize" & obj & "=dword:00065535")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TCPNoDelay" & obj & "=dword:00000001")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TCPDelAckTicks" & obj & "=dword:00000000")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "DefaultRCVWindow" & obj & "=dword:00017032")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "MaxConnectionsPerServer" & obj & "=dword:00000006")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "MaxConnectionsPer1_0Server" & obj & "=dword:00000006")
            RichTextBox1.AppendText(vbCrLf)
        End If
    End Sub

    ' Token: 0x06000031 RID: 49 RVA: 0x00004A10 File Offset: 0x00002C10
    Private Sub CheckBox22_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox22.CheckedChanged
        If CheckBox22.Checked Then
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.SelectionColor = Color.Red
            RichTextBox1.AppendText("[HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters]")
            RichTextBox1.SelectionColor = Color.Black
            RichTextBox1.AppendText(vbCrLf)
            Dim obj As Object = """"
            RichTextBox1.AppendText(obj & "TcpNoDelay" & obj & "=dword:00000040")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TcpDelAckTicks" & obj & "=dword:00000000")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TcpAckFrequency" & obj & "=dword:00000012")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "MaxConnectionsPerServer" & obj & "=dword:00000010")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "MaxConnectionsPer1_0Server" & obj & "=dword:00000010")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "DisableTaskOffload" & obj & "=dword:00000000")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "DnsPriority" & obj & "=dword:000005bd")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "HostsPriority" & obj & "=dword:0000023c")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "LocalPriority" & obj & "=dword:0000005b")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "NetbtPriority" & obj & "=dword:0000002d")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "QualifyingDestinationThreshold" & obj & "=dword:00000003")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "DisableTaskOffload" & obj & "=dword:00000001")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "IPEnableRouter" & obj & "=dword:00000000")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "EnableICMPRedirect" & obj & "=dword:00000001")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "KeepAliveTime" & obj & "=dword:006ddd00")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "KeepAliveInterval" & obj & "=dword:000003e8")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TcpMaxDupAcks" & obj & "=dword:00000002")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "DefaultTTL" & obj & "=dword:00000064")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "DeadGWDetectDefault" & obj & "=dword:00000001")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "DontAddDefaultGatewayDefault" & obj & "=dword:00000000")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "Tcp1323Opts" & obj & "=dword:00000003")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "EnableTCPA" & obj & "=dword:00000001")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TCPMaxDataRetransmissions" & obj & "=dword:00000007")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "SynAttackProtect" & obj & "=dword:00000001")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "EnableDCA" & obj & "=dword:00000001")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TcpWindowSize" & obj & "=dword:00000001")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "MTU" & obj & "=dword:1464")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "MSS" & obj & "=dword:1424")
            RichTextBox1.AppendText(vbCrLf)
        End If
    End Sub

    ' Token: 0x06000032 RID: 50 RVA: 0x0000513C File Offset: 0x0000333C
    Private Sub CheckBox23_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox23.CheckedChanged
        If CheckBox23.Checked Then
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.SelectionColor = Color.Red
            RichTextBox1.AppendText("[HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Dnscache\Parameters]")
            RichTextBox1.SelectionColor = Color.Black
            RichTextBox1.AppendText(vbCrLf)
            Dim obj As Object = """"
            RichTextBox1.AppendText(obj & "CacheHashTableBucketSize" & obj & "=dword:00000001")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "CacheHashTableSize" & obj & "=dword:00000180")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "MaxCacheEntryTtlLimit" & obj & "=dword:0000fa00")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "MaxSOACacheEntryTtlLimit" & obj & "=dword:0000012d")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "NegativeCacheTime" & obj & "=dword:00000000")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "NetFailureCacheTime" & obj & "=dword:00000000")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "NegativeSOACacheTime" & obj & "=dword:00000000")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.SelectionColor = Color.Red
            RichTextBox1.AppendText("[HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters]")
            RichTextBox1.SelectionColor = Color.Black
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TcpNoDelay" & obj & "=dword:000250ff")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TCPDelAckTicks" & obj & "=dword:00000000")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TcpMaxDataRetransmissions" & obj & "=dword:00000003")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "SackOpts" & obj & "=dword:00000001")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "TcpWindowSize" & obj & "=dword:0005ae4c")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "Tcp1323Opts" & obj & "=dword:00000003")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "DefaultTTL" & obj & "=dword:00000040")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "EnablePMTUBHDetect" & obj & "=dword:00000000")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "EnablePMTUDiscovery" & obj & "=dword:00000001")
            RichTextBox1.AppendText(vbCrLf)
            RichTextBox1.AppendText(obj & "GlobalMaxTcpWindowSize" & obj & "=dword-:0005ae4c")
            RichTextBox1.AppendText(vbCrLf)
        End If
    End Sub

    ' Token: 0x06000033 RID: 51 RVA: 0x0000561B File Offset: 0x0000381B
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Interaction.MsgBox("RegeditEngine - Premium Version !", MsgBoxStyle.OkOnly, Nothing)
    End Sub
End Class