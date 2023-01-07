<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculadora
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Lbl_PrimeiroNumero = New System.Windows.Forms.Label()
        Me.Lbl_SegundoNumero = New System.Windows.Forms.Label()
        Me.Btm_Somar = New System.Windows.Forms.Button()
        Me.Btm_Subtrair = New System.Windows.Forms.Button()
        Me.Btm_Multiplicar = New System.Windows.Forms.Button()
        Me.Btm_Dividir = New System.Windows.Forms.Button()
        Me.Lbl_Resultado = New System.Windows.Forms.Label()
        Me.Txt_Resultado = New System.Windows.Forms.TextBox()
        Me.Txt_SegundoNumero = New System.Windows.Forms.TextBox()
        Me.Txt_PrimeiroNumero = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Lbl_PrimeiroNumero
        '
        Me.Lbl_PrimeiroNumero.AutoSize = True
        Me.Lbl_PrimeiroNumero.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_PrimeiroNumero.Name = "Lbl_PrimeiroNumero"
        Me.Lbl_PrimeiroNumero.Size = New System.Drawing.Size(84, 13)
        Me.Lbl_PrimeiroNumero.TabIndex = 2
        Me.Lbl_PrimeiroNumero.Text = "Primeiro Numero"
        '
        'Lbl_SegundoNumero
        '
        Me.Lbl_SegundoNumero.AutoSize = True
        Me.Lbl_SegundoNumero.Location = New System.Drawing.Point(116, 9)
        Me.Lbl_SegundoNumero.Name = "Lbl_SegundoNumero"
        Me.Lbl_SegundoNumero.Size = New System.Drawing.Size(90, 13)
        Me.Lbl_SegundoNumero.TabIndex = 3
        Me.Lbl_SegundoNumero.Text = "Segundo Número"
        '
        'Btm_Somar
        '
        Me.Btm_Somar.Location = New System.Drawing.Point(12, 70)
        Me.Btm_Somar.Name = "Btm_Somar"
        Me.Btm_Somar.Size = New System.Drawing.Size(100, 23)
        Me.Btm_Somar.TabIndex = 4
        Me.Btm_Somar.Text = "+"
        Me.Btm_Somar.UseVisualStyleBackColor = True
        '
        'Btm_Subtrair
        '
        Me.Btm_Subtrair.Location = New System.Drawing.Point(119, 70)
        Me.Btm_Subtrair.Name = "Btm_Subtrair"
        Me.Btm_Subtrair.Size = New System.Drawing.Size(100, 23)
        Me.Btm_Subtrair.TabIndex = 5
        Me.Btm_Subtrair.Text = "-"
        Me.Btm_Subtrair.UseVisualStyleBackColor = True
        '
        'Btm_Multiplicar
        '
        Me.Btm_Multiplicar.Location = New System.Drawing.Point(12, 99)
        Me.Btm_Multiplicar.Name = "Btm_Multiplicar"
        Me.Btm_Multiplicar.Size = New System.Drawing.Size(100, 23)
        Me.Btm_Multiplicar.TabIndex = 6
        Me.Btm_Multiplicar.Text = "*"
        Me.Btm_Multiplicar.UseVisualStyleBackColor = True
        '
        'Btm_Dividir
        '
        Me.Btm_Dividir.Location = New System.Drawing.Point(119, 99)
        Me.Btm_Dividir.Name = "Btm_Dividir"
        Me.Btm_Dividir.Size = New System.Drawing.Size(100, 23)
        Me.Btm_Dividir.TabIndex = 7
        Me.Btm_Dividir.Text = "/"
        Me.Btm_Dividir.UseVisualStyleBackColor = True
        '
        'Lbl_Resultado
        '
        Me.Lbl_Resultado.AutoSize = True
        Me.Lbl_Resultado.Location = New System.Drawing.Point(15, 145)
        Me.Lbl_Resultado.Name = "Lbl_Resultado"
        Me.Lbl_Resultado.Size = New System.Drawing.Size(55, 13)
        Me.Lbl_Resultado.TabIndex = 8
        Me.Lbl_Resultado.Text = "Resultado"
        '
        'Txt_Resultado
        '
        Me.Txt_Resultado.Enabled = False
        Me.Txt_Resultado.Location = New System.Drawing.Point(18, 161)
        Me.Txt_Resultado.Name = "Txt_Resultado"
        Me.Txt_Resultado.Size = New System.Drawing.Size(201, 20)
        Me.Txt_Resultado.TabIndex = 9
        Me.Txt_Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_SegundoNumero
        '
        Me.Txt_SegundoNumero.Location = New System.Drawing.Point(119, 35)
        Me.Txt_SegundoNumero.Name = "Txt_SegundoNumero"
        Me.Txt_SegundoNumero.Size = New System.Drawing.Size(100, 20)
        Me.Txt_SegundoNumero.TabIndex = 1
        Me.Txt_SegundoNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_PrimeiroNumero
        '
        Me.Txt_PrimeiroNumero.Location = New System.Drawing.Point(12, 35)
        Me.Txt_PrimeiroNumero.Name = "Txt_PrimeiroNumero"
        Me.Txt_PrimeiroNumero.Size = New System.Drawing.Size(100, 20)
        Me.Txt_PrimeiroNumero.TabIndex = 0
        Me.Txt_PrimeiroNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(245, 197)
        Me.Controls.Add(Me.Txt_Resultado)
        Me.Controls.Add(Me.Lbl_Resultado)
        Me.Controls.Add(Me.Btm_Dividir)
        Me.Controls.Add(Me.Btm_Multiplicar)
        Me.Controls.Add(Me.Btm_Subtrair)
        Me.Controls.Add(Me.Btm_Somar)
        Me.Controls.Add(Me.Lbl_SegundoNumero)
        Me.Controls.Add(Me.Lbl_PrimeiroNumero)
        Me.Controls.Add(Me.Txt_SegundoNumero)
        Me.Controls.Add(Me.Txt_PrimeiroNumero)
        Me.Name = "Calculadora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "A Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_PrimeiroNumero As Label
    Friend WithEvents Lbl_SegundoNumero As Label
    Friend WithEvents Btm_Somar As Button
    Friend WithEvents Btm_Subtrair As Button
    Friend WithEvents Btm_Multiplicar As Button
    Friend WithEvents Btm_Dividir As Button
    Friend WithEvents Lbl_Resultado As Label
    Friend WithEvents Txt_Resultado As TextBox
    Friend WithEvents Txt_SegundoNumero As TextBox
    Friend WithEvents Txt_PrimeiroNumero As TextBox
End Class
