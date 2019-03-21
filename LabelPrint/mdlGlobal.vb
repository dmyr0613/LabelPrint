Module mdlGlobal

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

    Public Structure strcGlocalLabelList
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
    Public strcLabelList As strcGlocalLabelList

End Module
