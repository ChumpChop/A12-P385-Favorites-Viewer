<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Viewer
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Viewer))
        Me.lvwFavorites = New System.Windows.Forms.ListView()
        Me.hdrName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hdrUrl = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lnkUrl = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'lvwFavorites
        '
        Me.lvwFavorites.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwFavorites.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.hdrName, Me.hdrUrl})
        Me.lvwFavorites.FullRowSelect = True
        Me.lvwFavorites.HideSelection = False
        Me.lvwFavorites.Location = New System.Drawing.Point(0, 0)
        Me.lvwFavorites.Name = "lvwFavorites"
        Me.lvwFavorites.Size = New System.Drawing.Size(453, 236)
        Me.lvwFavorites.TabIndex = 0
        Me.lvwFavorites.UseCompatibleStateImageBehavior = False
        Me.lvwFavorites.View = System.Windows.Forms.View.Details
        '
        'hdrName
        '
        Me.hdrName.Text = "Name"
        Me.hdrName.Width = 220
        '
        'hdrUrl
        '
        Me.hdrUrl.Text = "URL"
        Me.hdrUrl.Width = 220
        '
        'lnkUrl
        '
        Me.lnkUrl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkUrl.AutoSize = True
        Me.lnkUrl.Location = New System.Drawing.Point(0, 243)
        Me.lnkUrl.Name = "lnkUrl"
        Me.lnkUrl.Size = New System.Drawing.Size(61, 13)
        Me.lnkUrl.TabIndex = 1
        Me.lnkUrl.TabStop = True
        Me.lnkUrl.Text = "LinkLabel1"
        Me.lnkUrl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 265)
        Me.Controls.Add(Me.lnkUrl)
        Me.Controls.Add(Me.lvwFavorites)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Viewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Favorites"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvwFavorites As System.Windows.Forms.ListView
    Friend WithEvents hdrName As System.Windows.Forms.ColumnHeader
    Friend WithEvents hdrUrl As System.Windows.Forms.ColumnHeader
    Friend WithEvents lnkUrl As System.Windows.Forms.LinkLabel

End Class
