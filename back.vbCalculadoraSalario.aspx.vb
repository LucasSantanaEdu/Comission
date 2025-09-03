Imports System.Web.Services

Public Class CalculadoraSalario
    Inherits System.Web.UI.Page

    <WebMethod()>
    Public Shared Function CalcularSalario(ByVal vendas As Double) As String
        Dim comissaoBruta As Double = vendas * 0.0225
        Dim comissaoLiquida As Double = comissaoBruta * (1 - 0.123)

        Dim bonus As Double = 0
        If vendas > 35000 Then
            bonus = Math.Floor((vendas - 35000) / 1000) * 10
        End If

        Return $"Comissão líquida (em folha): R${comissaoLiquida:F2} <br/>Bônus extra (em dinheiro): R${bonus:F2}"
    End Function
End Class
