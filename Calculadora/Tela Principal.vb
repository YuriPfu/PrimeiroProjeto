Public Class Calculadora
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub Btm_Somar_Click(sender As Object, e As EventArgs) Handles Btm_Somar.Click
        If Txt_PrimeiroNumero.Text = Nothing AndAlso Txt_SegundoNumero.Text = Nothing Then
            MsgBox("Favor inserir um número válido")
            Exit Sub
        End If
        Dim Primeiro As Decimal = Txt_PrimeiroNumero.Text
        Dim Segundo As Decimal = Txt_SegundoNumero.Text
        Dim valor As Decimal = Primeiro + Segundo
        Txt_Resultado.Text = (valor)
    End Sub

    Private Sub Btm_Subtrair_Click(sender As Object, e As EventArgs) Handles Btm_Subtrair.Click
        If Txt_PrimeiroNumero.Text = Nothing AndAlso Txt_SegundoNumero.Text = Nothing Then
            MsgBox("Favor inserir um número válido")
            Exit Sub
        End If
        Dim Primeiro As Decimal = Txt_PrimeiroNumero.Text
        Dim Segundo As Decimal = Txt_SegundoNumero.Text
        Dim valor As Decimal = Primeiro - Segundo
        Txt_Resultado.Text = (valor)
    End Sub

    Private Sub Btm_Multiplicar_Click(sender As Object, e As EventArgs) Handles Btm_Multiplicar.Click
        If Txt_PrimeiroNumero.Text = Nothing AndAlso Txt_SegundoNumero.Text = Nothing Then
            MsgBox("Favor inserir um número válido")
            Exit Sub
        End If
        Dim Primeiro As Decimal = Txt_PrimeiroNumero.Text
        Dim Segundo As Decimal = Txt_SegundoNumero.Text
        Dim valor As Decimal = Primeiro * Segundo
        Txt_Resultado.Text = (valor)
    End Sub

    Private Sub Btm_Dividir_Click(sender As Object, e As EventArgs) Handles Btm_Dividir.Click
        If Txt_PrimeiroNumero.Text = Nothing AndAlso Txt_SegundoNumero.Text = Nothing Then
            MsgBox("Favor inserir um número válido")
            Exit Sub
        End If
        Dim Primeiro As Decimal = Txt_PrimeiroNumero.Text
        Dim Segundo As Decimal = Txt_SegundoNumero.Text
        Dim valor As Decimal = Primeiro / Segundo
        Txt_Resultado.Text = (valor)
    End Sub

End Class
