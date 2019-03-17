

Public Class frmViewer

    'ActiveReportのTextBox.DataFieldと同じ名前で構造体を作成
    Structure LabelList
        Public Delivery1 As String
        Public Delivery2 As String
        Public ItemNo As String
        Public BackNo As String
        Public ItemName As String
        Public Comment As String
        Public CapaNum As String
        Public LR As String
        Public KanriNo As String
        Public QRCode As Double
    End Structure

    ''' <summary>
    ''' フォームロード
    ''' </summary>
    Private Sub frmViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'ActiveReportを生成
        Dim rpt As New LabelData

        '構造体にデータを格納する
        Dim Kanban As List(Of LabelList) = New List(Of LabelList)
        Kanban.Add(New LabelList With {.Delivery1 = "ｼｰﾙS/A", .Delivery2 = "不織紫", .ItemNo = "G414", .BackNo = "ＪＺＦＸ", .ItemName = "ｶﾊﾞｰ Ｌ　　070", .Comment = "コメント", .CapaNum = "4", .LR = "Ｌ", .KanriNo = "1111111111", .QRCode = 1234567890})
        Kanban.Add(New LabelList With {.Delivery1 = "ｼｰﾙS/A", .Delivery2 = "不織紫", .ItemNo = "A555", .BackNo = "ＡＢＣＤ", .ItemName = "ｶﾊﾞｰ Ｒ　　090", .Comment = "コメント", .CapaNum = "10", .LR = "Ｒ", .KanriNo = "1111111112", .QRCode = 9999999999})
        Kanban.Add(New LabelList With {.Delivery1 = "ｼｰﾙS/B", .Delivery2 = "不織青", .ItemNo = "B666", .BackNo = "ＢＥＲＧ", .ItemName = "ｶﾊﾞｰ Ｌ　　050", .Comment = "コメント", .CapaNum = "15", .LR = "Ｌ", .KanriNo = "1111111113", .QRCode = 5555555555})

        '作成したデータをデータセットに保存
        Dim data = From p In Kanban _
           Select Delivery1 = p.Delivery1, _
                  Delivery2 = p.Delivery2, _
                  ItemNo = p.ItemNo, _
                  BackNo = p.BackNo, _
                  ItemName = p.ItemName, _
                  Comment = p.Comment, _
                  CapaNum = p.CapaNum, _
                  LR = p.LR, _
                  KanriNo = p.KanriNo, _
                  QRCode = p.QRCode

        'ActiveReport.DataSourceに同じ形で渡すと、名前が一致するTextBox.DataFieldに印字されます。
        'DBからの場合も、列名を同じにして、そのままデータセットを渡せば良い。
        rpt.DataSource = data.ToList()
        rpt.Run()
        Me.arvMain.Document = rpt.Document

        '※余白の設定は、ActiveReportデザイナ画面のレポートメニュー-レポートの設定から行います。
    End Sub

End Class
