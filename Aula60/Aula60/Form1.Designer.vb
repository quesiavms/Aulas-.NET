<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_texto = New System.Windows.Forms.Button()
        Me.lb_texto = New System.Windows.Forms.Label()
        Me.tb_texto = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_texto
        '
        Me.btn_texto.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_texto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_texto.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_texto.Location = New System.Drawing.Point(12, 40)
        Me.btn_texto.Name = "btn_texto"
        Me.btn_texto.Size = New System.Drawing.Size(154, 54)
        Me.btn_texto.TabIndex = 0
        Me.btn_texto.Text = "Okay"
        Me.btn_texto.UseVisualStyleBackColor = False
        '
        'lb_texto
        '
        Me.lb_texto.AutoSize = True
        Me.lb_texto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_texto.Location = New System.Drawing.Point(22, 97)
        Me.lb_texto.Name = "lb_texto"
        Me.lb_texto.Size = New System.Drawing.Size(126, 25)
        Me.lb_texto.TabIndex = 1
        Me.lb_texto.Text = "@quesiavms"
        '
        'tb_texto
        '
        Me.tb_texto.Location = New System.Drawing.Point(12, 12)
        Me.tb_texto.Name = "tb_texto"
        Me.tb_texto.Size = New System.Drawing.Size(154, 22)
        Me.tb_texto.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 450)
        Me.Controls.Add(Me.tb_texto)
        Me.Controls.Add(Me.lb_texto)
        Me.Controls.Add(Me.btn_texto)
        Me.Name = "Form1"
        Me.Text = "Form da Quesia - Teste"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_texto As Button
    Friend WithEvents lb_texto As Label
    Friend WithEvents tb_texto As TextBox
End Class
