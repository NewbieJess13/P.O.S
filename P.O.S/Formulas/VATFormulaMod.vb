Module VATFormulaMod
    Public Function GetVAT(ByVal RetailPrice As String, ByVal TotalSellingPrice As String)
        Dim VAT As Decimal = 0.12
        TotalSellingPrice = 0
        RetailPrice = 0
        Dim VATResult As Decimal
        VATResult = RetailPrice * VAT
        TotalSellingPrice = RetailPrice + VATResult
        Return TotalSellingPrice
    End Function
End Module
