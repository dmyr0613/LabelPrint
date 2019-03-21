<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbLR = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDelivery1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtItemNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBackNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCapaNum = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtQRCode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtKanriNo = New System.Windows.Forms.TextBox()
        Me.txtDelivery2 = New System.Windows.Forms.TextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 44)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 24)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "左右"
        '
        'cmbLR
        '
        Me.cmbLR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLR.FormattingEnabled = True
        Me.cmbLR.Items.AddRange(New Object() {"L", "R"})
        Me.cmbLR.Location = New System.Drawing.Point(133, 41)
        Me.cmbLR.Name = "cmbLR"
        Me.cmbLR.Size = New System.Drawing.Size(72, 32)
        Me.cmbLR.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 82)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 24)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "出荷荷姿"
        '
        'txtDelivery1
        '
        Me.txtDelivery1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txtDelivery1.Location = New System.Drawing.Point(133, 79)
        Me.txtDelivery1.Name = "txtDelivery1"
        Me.txtDelivery1.Size = New System.Drawing.Size(295, 31)
        Me.txtDelivery1.TabIndex = 65
        Me.txtDelivery1.Text = "ｼｰﾙS/A"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 156)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 24)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "作番"
        '
        'txtItemNo
        '
        Me.txtItemNo.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txtItemNo.Location = New System.Drawing.Point(133, 153)
        Me.txtItemNo.Name = "txtItemNo"
        Me.txtItemNo.Size = New System.Drawing.Size(295, 31)
        Me.txtItemNo.TabIndex = 67
        Me.txtItemNo.Text = "G414"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 193)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 24)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "背番号"
        '
        'txtBackNo
        '
        Me.txtBackNo.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txtBackNo.Location = New System.Drawing.Point(133, 190)
        Me.txtBackNo.Name = "txtBackNo"
        Me.txtBackNo.Size = New System.Drawing.Size(295, 31)
        Me.txtBackNo.TabIndex = 69
        Me.txtBackNo.Text = "ＪＺＦＸ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 230)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 24)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "品名"
        '
        'txtItemName
        '
        Me.txtItemName.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txtItemName.Location = New System.Drawing.Point(133, 227)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(295, 31)
        Me.txtItemName.TabIndex = 71
        Me.txtItemName.Text = "ｶﾊﾞｰ Ｌ　　070"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 267)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 24)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "収容数"
        '
        'txtCapaNum
        '
        Me.txtCapaNum.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtCapaNum.Location = New System.Drawing.Point(133, 264)
        Me.txtCapaNum.Name = "txtCapaNum"
        Me.txtCapaNum.Size = New System.Drawing.Size(295, 31)
        Me.txtCapaNum.TabIndex = 73
        Me.txtCapaNum.Text = "4"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 304)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 24)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "QRコード"
        '
        'txtQRCode
        '
        Me.txtQRCode.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtQRCode.Location = New System.Drawing.Point(133, 301)
        Me.txtQRCode.Name = "txtQRCode"
        Me.txtQRCode.Size = New System.Drawing.Size(295, 31)
        Me.txtQRCode.TabIndex = 75
        Me.txtQRCode.Text = "1234567890"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(46, 341)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 24)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "管理番号"
        '
        'txtKanriNo
        '
        Me.txtKanriNo.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtKanriNo.Location = New System.Drawing.Point(133, 338)
        Me.txtKanriNo.Name = "txtKanriNo"
        Me.txtKanriNo.Size = New System.Drawing.Size(295, 31)
        Me.txtKanriNo.TabIndex = 77
        Me.txtKanriNo.Text = "1111111111"
        '
        'txtDelivery2
        '
        Me.txtDelivery2.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txtDelivery2.Location = New System.Drawing.Point(133, 116)
        Me.txtDelivery2.Name = "txtDelivery2"
        Me.txtDelivery2.Size = New System.Drawing.Size(295, 31)
        Me.txtDelivery2.TabIndex = 79
        Me.txtDelivery2.Text = "不織紫"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Lavender
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Location = New System.Drawing.Point(206, 435)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(112, 49)
        Me.btnPrint.TabIndex = 81
        Me.btnPrint.Text = "ラベル印刷"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Lavender
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(337, 435)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(112, 49)
        Me.btnClose.TabIndex = 80
        Me.btnClose.Text = "閉じる"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(46, 378)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 24)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "コメント"
        '
        'txtComment
        '
        Me.txtComment.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txtComment.Location = New System.Drawing.Point(133, 375)
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(295, 31)
        Me.txtComment.TabIndex = 82
        Me.txtComment.Text = "コメント"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 511)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtDelivery2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtKanriNo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtQRCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCapaNum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBackNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtItemNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDelivery1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbLR)
        Me.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMain"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbLR As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDelivery1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtItemNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBackNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCapaNum As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtQRCode As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtKanriNo As System.Windows.Forms.TextBox
    Friend WithEvents txtDelivery2 As System.Windows.Forms.TextBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
End Class
