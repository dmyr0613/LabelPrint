Public Class frmMain

    ''' <summary>
    ''' フォームロード
    ''' </summary>
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '初期化
        cmbLR.SelectedIndex = 0
    End Sub

    ''' <summary>
    ''' 閉じるボタン
    ''' </summary>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' 印刷ボタン
    ''' </summary>
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        With strcLabelList
            .Delivery1 = txtDelivery1.Text
            .Delivery2 = txtDelivery2.Text
            .ItemNo = txtItemNo.Text
            .BackNo = txtBackNo.Text
            .ItemName = txtItemName.Text
            .Comment = txtComment.Text
            .CapaNum = txtCapaNum.Text
            .LR = cmbLR.Text
            .KanriNo = txtKanriNo.Text
            .QRCode = txtQRCode.Text
        End With
        frmViewer.Show()

    End Sub

End Class