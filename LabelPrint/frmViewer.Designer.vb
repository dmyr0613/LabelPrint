<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewer
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewer))
        Me.arvMain = New GrapeCity.ActiveReports.Viewer.Win.Viewer()
        Me.SuspendLayout()
        '
        'arvMain
        '
        Me.arvMain.BackColor = System.Drawing.SystemColors.Control
        Me.arvMain.CurrentPage = 0
        Me.arvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.arvMain.Location = New System.Drawing.Point(0, 0)
        Me.arvMain.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.arvMain.Name = "arvMain"
        Me.arvMain.PreviewPages = 0
        '
        '
        '
        '
        '
        '
        Me.arvMain.Sidebar.ParametersPanel.ContextMenu = Nothing
        Me.arvMain.Sidebar.ParametersPanel.Width = 180
        '
        '
        '
        Me.arvMain.Sidebar.SearchPanel.ContextMenu = Nothing
        Me.arvMain.Sidebar.SearchPanel.Width = 180
        '
        '
        '
        Me.arvMain.Sidebar.ThumbnailsPanel.ContextMenu = Nothing
        Me.arvMain.Sidebar.ThumbnailsPanel.Width = 180
        '
        '
        '
        Me.arvMain.Sidebar.TocPanel.ContextMenu = Nothing
        Me.arvMain.Sidebar.TocPanel.Width = 180
        Me.arvMain.Sidebar.Width = 180
        Me.arvMain.Size = New System.Drawing.Size(913, 644)
        Me.arvMain.TabIndex = 2
        '
        'frmViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 644)
        Me.Controls.Add(Me.arvMain)
        Me.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "frmViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ラベル印刷"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents arvMain As GrapeCity.ActiveReports.Viewer.Win.Viewer

End Class
