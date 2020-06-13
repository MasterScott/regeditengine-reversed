Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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

    ' Token: 0x060000A8 RID: 168 RVA: 0x00008478 File Offset: 0x00006678
    <Global.System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New Global.System.Windows.Forms.CheckBox()
        Me.ColorDialog1 = New Global.System.Windows.Forms.ColorDialog()
        Me.Button1 = New Global.System.Windows.Forms.Button()
        Me.TrackBar1 = New Global.System.Windows.Forms.TrackBar()
        Me.Label1 = New Global.System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        'CType(Me.TrackBar1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
        MyBase.SuspendLayout()
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TrackBar1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New Global.System.Drawing.Point(5, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New Global.System.Drawing.Size(249, 114)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New Global.System.Drawing.Point(7, 13)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New Global.System.Drawing.Size(62, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Overlay"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.Button1.Location = New Global.System.Drawing.Point(7, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New Global.System.Drawing.Size(236, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Couleur"
        Me.Button1.UseVisualStyleBackColor = True
        Me.TrackBar1.Location = New Global.System.Drawing.Point(74, 31)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New Global.System.Drawing.Size(169, 45)
        Me.TrackBar1.TabIndex = 2
        Me.TrackBar1.TickStyle = Global.System.Windows.Forms.TickStyle.Both
        Me.TrackBar1.Value = 100
        Me.Label1.AutoSize = True
        Me.Label1.Location = New Global.System.Drawing.Point(19, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Global.System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Opacity :"
        MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6.0F, 13.0F)
        MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.System.Drawing.Color.White
        MyBase.ClientSize = New Global.System.Drawing.Size(266, 127)
        MyBase.Controls.Add(Me.GroupBox1)
        MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.Fixed3D
        'MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
        MyBase.MaximizeBox = False
        MyBase.Name = "Settings"
        MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        'CType(Me.TrackBar1, Global.System.ComponentModel.ISupportInitialize).EndInit()
        MyBase.ResumeLayout(False)
    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Label1 As Label

    ' Token: 0x04000044 RID: 68
    Private components As Global.System.ComponentModel.IContainer
End Class
