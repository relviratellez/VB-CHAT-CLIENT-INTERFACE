﻿
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModernToolBar
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModernToolBar))
        Me.TxtFriendFinder = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.ImgFinderStatus = New System.Windows.Forms.PictureBox()
        CType(Me.ImgFinderStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtFriendFinder
        '
        Me.TxtFriendFinder.Location = New System.Drawing.Point(40, 7)
        Me.TxtFriendFinder.Name = "TxtFriendFinder"
        Me.TxtFriendFinder.Size = New System.Drawing.Size(125, 20)
        Me.TxtFriendFinder.TabIndex = 2
        Me.TxtFriendFinder.Visible = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackgroundImage = Global.CustomControls.My.Resources.Resources.add
        Me.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAdd.FlatAppearance.BorderSize = 0
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Location = New System.Drawing.Point(10, 4)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(24, 24)
        Me.BtnAdd.TabIndex = 1
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.Color.Transparent
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Location = New System.Drawing.Point(473, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(29, 26)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'ImgFinderStatus
        '
        Me.ImgFinderStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ImgFinderStatus.Image = Global.CustomControls.My.Resources.Resources.cancel
        Me.ImgFinderStatus.Location = New System.Drawing.Point(170, 11)
        Me.ImgFinderStatus.Name = "ImgFinderStatus"
        Me.ImgFinderStatus.Size = New System.Drawing.Size(12, 12)
        Me.ImgFinderStatus.TabIndex = 3
        Me.ImgFinderStatus.TabStop = False
        Me.ImgFinderStatus.Visible = False
        '
        'ModernToolBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Controls.Add(Me.ImgFinderStatus)
        Me.Controls.Add(Me.TxtFriendFinder)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnClose)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ModernToolBar"
        Me.Size = New System.Drawing.Size(502, 40)
        CType(Me.ImgFinderStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents TxtFriendFinder As System.Windows.Forms.TextBox
    Friend WithEvents ImgFinderStatus As System.Windows.Forms.PictureBox

End Class