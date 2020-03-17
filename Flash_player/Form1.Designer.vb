Imports System.IO
Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports AxShockwaveFlashObjects
' Token: 0x02000009 RID: 9
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form1
    Inherits Form

    ' Token: 0x06000022 RID: 34 RVA: 0x00002788 File Offset: 0x00000988
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

    ' Token: 0x06000083 RID: 131 RVA: 0x00002E24 File Offset: 0x00001024
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenISODVDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoundsOnoffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolumeControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HighToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NetPlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GamePadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Port1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pad1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pad2ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pad3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultitapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Port2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pad2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pad2ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pad3ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultitapToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SinglePlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OFFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultiPlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ONToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OFFToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResolutionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X768ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X768ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.X768ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.X768ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetDefaultSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportBugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Contactxbox1emulatororgToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Xemu1V361ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullscreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(112, 405)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.CheatsToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem, Me.AboutToolStripMenuItem, Me.FullscreenToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(655, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenISODVDToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenISODVDToolStripMenuItem
        '
        Me.OpenISODVDToolStripMenuItem.Name = "OpenISODVDToolStripMenuItem"
        Me.OpenISODVDToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.OpenISODVDToolStripMenuItem.Text = "Open ISO/DVD..."
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SoundsOnoffToolStripMenuItem, Me.VolumeControlToolStripMenuItem, Me.NetPlayToolStripMenuItem, Me.GamePadToolStripMenuItem, Me.SinglePlayerToolStripMenuItem, Me.MultiPlayerToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'SoundsOnoffToolStripMenuItem
        '
        Me.SoundsOnoffToolStripMenuItem.Name = "SoundsOnoffToolStripMenuItem"
        Me.SoundsOnoffToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.SoundsOnoffToolStripMenuItem.Text = "Bios"
        '
        'VolumeControlToolStripMenuItem
        '
        Me.VolumeControlToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LowToolStripMenuItem, Me.MediumToolStripMenuItem, Me.HighToolStripMenuItem})
        Me.VolumeControlToolStripMenuItem.Name = "VolumeControlToolStripMenuItem"
        Me.VolumeControlToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.VolumeControlToolStripMenuItem.Text = "Volume Control"
        '
        'LowToolStripMenuItem
        '
        Me.LowToolStripMenuItem.Name = "LowToolStripMenuItem"
        Me.LowToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.LowToolStripMenuItem.Text = "Low"
        '
        'MediumToolStripMenuItem
        '
        Me.MediumToolStripMenuItem.Name = "MediumToolStripMenuItem"
        Me.MediumToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.MediumToolStripMenuItem.Text = "Medium"
        '
        'HighToolStripMenuItem
        '
        Me.HighToolStripMenuItem.Name = "HighToolStripMenuItem"
        Me.HighToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.HighToolStripMenuItem.Text = "High"
        '
        'NetPlayToolStripMenuItem
        '
        Me.NetPlayToolStripMenuItem.Name = "NetPlayToolStripMenuItem"
        Me.NetPlayToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.NetPlayToolStripMenuItem.Text = "Net Play"
        '
        'GamePadToolStripMenuItem
        '
        Me.GamePadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Port1ToolStripMenuItem, Me.Port2ToolStripMenuItem})
        Me.GamePadToolStripMenuItem.Name = "GamePadToolStripMenuItem"
        Me.GamePadToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.GamePadToolStripMenuItem.Text = "Game Pad"
        '
        'Port1ToolStripMenuItem
        '
        Me.Port1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Pad1ToolStripMenuItem, Me.Pad2ToolStripMenuItem1, Me.Pad3ToolStripMenuItem, Me.MultitapToolStripMenuItem})
        Me.Port1ToolStripMenuItem.Name = "Port1ToolStripMenuItem"
        Me.Port1ToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.Port1ToolStripMenuItem.Text = "Port 1"
        '
        'Pad1ToolStripMenuItem
        '
        Me.Pad1ToolStripMenuItem.Name = "Pad1ToolStripMenuItem"
        Me.Pad1ToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.Pad1ToolStripMenuItem.Text = "Pad 1"
        '
        'Pad2ToolStripMenuItem1
        '
        Me.Pad2ToolStripMenuItem1.Name = "Pad2ToolStripMenuItem1"
        Me.Pad2ToolStripMenuItem1.Size = New System.Drawing.Size(119, 22)
        Me.Pad2ToolStripMenuItem1.Text = "Pad 2"
        '
        'Pad3ToolStripMenuItem
        '
        Me.Pad3ToolStripMenuItem.Name = "Pad3ToolStripMenuItem"
        Me.Pad3ToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.Pad3ToolStripMenuItem.Text = "Pad 3"
        '
        'MultitapToolStripMenuItem
        '
        Me.MultitapToolStripMenuItem.Name = "MultitapToolStripMenuItem"
        Me.MultitapToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.MultitapToolStripMenuItem.Text = "Multitap"
        '
        'Port2ToolStripMenuItem
        '
        Me.Port2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Pad2ToolStripMenuItem, Me.Pad2ToolStripMenuItem2, Me.Pad3ToolStripMenuItem1, Me.MultitapToolStripMenuItem1})
        Me.Port2ToolStripMenuItem.Name = "Port2ToolStripMenuItem"
        Me.Port2ToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.Port2ToolStripMenuItem.Text = "Port 2"
        '
        'Pad2ToolStripMenuItem
        '
        Me.Pad2ToolStripMenuItem.Name = "Pad2ToolStripMenuItem"
        Me.Pad2ToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.Pad2ToolStripMenuItem.Text = "Pad 1"
        '
        'Pad2ToolStripMenuItem2
        '
        Me.Pad2ToolStripMenuItem2.Name = "Pad2ToolStripMenuItem2"
        Me.Pad2ToolStripMenuItem2.Size = New System.Drawing.Size(119, 22)
        Me.Pad2ToolStripMenuItem2.Text = "Pad 2"
        '
        'Pad3ToolStripMenuItem1
        '
        Me.Pad3ToolStripMenuItem1.Name = "Pad3ToolStripMenuItem1"
        Me.Pad3ToolStripMenuItem1.Size = New System.Drawing.Size(119, 22)
        Me.Pad3ToolStripMenuItem1.Text = "Pad 3"
        '
        'MultitapToolStripMenuItem1
        '
        Me.MultitapToolStripMenuItem1.Name = "MultitapToolStripMenuItem1"
        Me.MultitapToolStripMenuItem1.Size = New System.Drawing.Size(119, 22)
        Me.MultitapToolStripMenuItem1.Text = "Multitap"
        '
        'SinglePlayerToolStripMenuItem
        '
        Me.SinglePlayerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ONToolStripMenuItem, Me.OFFToolStripMenuItem})
        Me.SinglePlayerToolStripMenuItem.Name = "SinglePlayerToolStripMenuItem"
        Me.SinglePlayerToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.SinglePlayerToolStripMenuItem.Text = "Single Player"
        '
        'ONToolStripMenuItem
        '
        Me.ONToolStripMenuItem.Name = "ONToolStripMenuItem"
        Me.ONToolStripMenuItem.Size = New System.Drawing.Size(95, 22)
        Me.ONToolStripMenuItem.Text = "ON"
        '
        'OFFToolStripMenuItem
        '
        Me.OFFToolStripMenuItem.Name = "OFFToolStripMenuItem"
        Me.OFFToolStripMenuItem.Size = New System.Drawing.Size(95, 22)
        Me.OFFToolStripMenuItem.Text = "OFF"
        '
        'MultiPlayerToolStripMenuItem
        '
        Me.MultiPlayerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ONToolStripMenuItem1, Me.OFFToolStripMenuItem1})
        Me.MultiPlayerToolStripMenuItem.Name = "MultiPlayerToolStripMenuItem"
        Me.MultiPlayerToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.MultiPlayerToolStripMenuItem.Text = "Multi Player"
        '
        'ONToolStripMenuItem1
        '
        Me.ONToolStripMenuItem1.Name = "ONToolStripMenuItem1"
        Me.ONToolStripMenuItem1.Size = New System.Drawing.Size(95, 22)
        Me.ONToolStripMenuItem1.Text = "ON"
        '
        'OFFToolStripMenuItem1
        '
        Me.OFFToolStripMenuItem1.Name = "OFFToolStripMenuItem1"
        Me.OFFToolStripMenuItem1.Size = New System.Drawing.Size(95, 22)
        Me.OFFToolStripMenuItem1.Text = "OFF"
        '
        'CheatsToolStripMenuItem
        '
        Me.CheatsToolStripMenuItem.Name = "CheatsToolStripMenuItem"
        Me.CheatsToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.CheatsToolStripMenuItem.Text = "Cheats"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResolutionToolStripMenuItem, Me.ResetDefaultSettingsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'ResolutionToolStripMenuItem
        '
        Me.ResolutionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.X768ToolStripMenuItem, Me.X768ToolStripMenuItem1, Me.X768ToolStripMenuItem2, Me.X768ToolStripMenuItem3, Me.DefaultToolStripMenuItem})
        Me.ResolutionToolStripMenuItem.Name = "ResolutionToolStripMenuItem"
        Me.ResolutionToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ResolutionToolStripMenuItem.Text = "Resolution"
        '
        'X768ToolStripMenuItem
        '
        Me.X768ToolStripMenuItem.Name = "X768ToolStripMenuItem"
        Me.X768ToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.X768ToolStripMenuItem.Text = "1366 x 768"
        '
        'X768ToolStripMenuItem1
        '
        Me.X768ToolStripMenuItem1.Name = "X768ToolStripMenuItem1"
        Me.X768ToolStripMenuItem1.Size = New System.Drawing.Size(128, 22)
        Me.X768ToolStripMenuItem1.Text = "1360 x 768"
        '
        'X768ToolStripMenuItem2
        '
        Me.X768ToolStripMenuItem2.Name = "X768ToolStripMenuItem2"
        Me.X768ToolStripMenuItem2.Size = New System.Drawing.Size(128, 22)
        Me.X768ToolStripMenuItem2.Text = "1280 x 768"
        '
        'X768ToolStripMenuItem3
        '
        Me.X768ToolStripMenuItem3.Name = "X768ToolStripMenuItem3"
        Me.X768ToolStripMenuItem3.Size = New System.Drawing.Size(128, 22)
        Me.X768ToolStripMenuItem3.Text = "1042 x 768"
        '
        'DefaultToolStripMenuItem
        '
        Me.DefaultToolStripMenuItem.Name = "DefaultToolStripMenuItem"
        Me.DefaultToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.DefaultToolStripMenuItem.Text = "Default"
        '
        'ResetDefaultSettingsToolStripMenuItem
        '
        Me.ResetDefaultSettingsToolStripMenuItem.Name = "ResetDefaultSettingsToolStripMenuItem"
        Me.ResetDefaultSettingsToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ResetDefaultSettingsToolStripMenuItem.Text = "Reset Default Settings"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportBugToolStripMenuItem, Me.Contactxbox1emulatororgToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ReportBugToolStripMenuItem
        '
        Me.ReportBugToolStripMenuItem.Name = "ReportBugToolStripMenuItem"
        Me.ReportBugToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.ReportBugToolStripMenuItem.Text = "Report Bug"
        '
        'Contactxbox1emulatororgToolStripMenuItem
        '
        Me.Contactxbox1emulatororgToolStripMenuItem.Name = "Contactxbox1emulatororgToolStripMenuItem"
        Me.Contactxbox1emulatororgToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.Contactxbox1emulatororgToolStripMenuItem.Text = "contact@ps3emulator.net"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Xemu1V361ToolStripMenuItem, Me.CheckUpdatesToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Xemu1V361ToolStripMenuItem
        '
        Me.Xemu1V361ToolStripMenuItem.Name = "Xemu1V361ToolStripMenuItem"
        Me.Xemu1V361ToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.Xemu1V361ToolStripMenuItem.Text = "Pes3E v.602.0"
        '
        'CheckUpdatesToolStripMenuItem
        '
        Me.CheckUpdatesToolStripMenuItem.Name = "CheckUpdatesToolStripMenuItem"
        Me.CheckUpdatesToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.CheckUpdatesToolStripMenuItem.Text = "Check Updates"
        '
        'FullscreenToolStripMenuItem
        '
        Me.FullscreenToolStripMenuItem.Name = "FullscreenToolStripMenuItem"
        Me.FullscreenToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.FullscreenToolStripMenuItem.Text = "Fullscreen"
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(0, 24)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(655, 378)
        Me.AxShockwaveFlash1.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(655, 402)
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = Global.Flash_player.My.Resources.Resources.favicon
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pes3E                                                        ps3emulator.net"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheatsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Contactxbox1emulatororgToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DefaultToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FullscreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GamePadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HighToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MediumToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MultiPlayerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MultitapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MultitapToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NetPlayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OFFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OFFToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ONToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenISODVDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Pad1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Pad2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Pad2ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Pad2ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Pad3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Pad3ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Port1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Port2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportBugToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetDefaultSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResolutionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SinglePlayerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SoundsOnoffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolumeControlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents X768ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents X768ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents X768ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents X768ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents Xemu1V361ToolStripMenuItem As ToolStripMenuItem
    ' Token: 0x0400000C RID: 12
    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
End Class