<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class colores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btnrojo = New System.Windows.Forms.Button()
        Me.txtcolores = New System.Windows.Forms.TextBox()
        Me.btnverde = New System.Windows.Forms.Button()
        Me.btnazul = New System.Windows.Forms.Button()
        Me.btnmorado = New System.Windows.Forms.Button()
        Me.btbamarillo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btnrojo
        '
        Me.Btnrojo.BackColor = System.Drawing.Color.Red
        Me.Btnrojo.Font = New System.Drawing.Font("Rockwell Extra Bold", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnrojo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Btnrojo.Location = New System.Drawing.Point(85, 44)
        Me.Btnrojo.Name = "Btnrojo"
        Me.Btnrojo.Size = New System.Drawing.Size(102, 37)
        Me.Btnrojo.TabIndex = 0
        Me.Btnrojo.Text = "Rojo"
        Me.Btnrojo.UseVisualStyleBackColor = False
        '
        'txtcolores
        '
        Me.txtcolores.Location = New System.Drawing.Point(237, 44)
        Me.txtcolores.Multiline = True
        Me.txtcolores.Name = "txtcolores"
        Me.txtcolores.Size = New System.Drawing.Size(536, 379)
        Me.txtcolores.TabIndex = 5
        '
        'btnverde
        '
        Me.btnverde.BackColor = System.Drawing.Color.LimeGreen
        Me.btnverde.Font = New System.Drawing.Font("Rockwell Extra Bold", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnverde.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnverde.Location = New System.Drawing.Point(85, 116)
        Me.btnverde.Name = "btnverde"
        Me.btnverde.Size = New System.Drawing.Size(102, 37)
        Me.btnverde.TabIndex = 6
        Me.btnverde.Text = "verde"
        Me.btnverde.UseVisualStyleBackColor = False
        '
        'btnazul
        '
        Me.btnazul.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnazul.Font = New System.Drawing.Font("Rockwell Extra Bold", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnazul.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnazul.Location = New System.Drawing.Point(85, 197)
        Me.btnazul.Name = "btnazul"
        Me.btnazul.Size = New System.Drawing.Size(102, 37)
        Me.btnazul.TabIndex = 7
        Me.btnazul.Text = "Azul"
        Me.btnazul.UseVisualStyleBackColor = False
        '
        'btnmorado
        '
        Me.btnmorado.BackColor = System.Drawing.Color.Indigo
        Me.btnmorado.Font = New System.Drawing.Font("Rockwell Extra Bold", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmorado.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnmorado.Location = New System.Drawing.Point(85, 273)
        Me.btnmorado.Name = "btnmorado"
        Me.btnmorado.Size = New System.Drawing.Size(102, 37)
        Me.btnmorado.TabIndex = 8
        Me.btnmorado.Text = "Rojo"
        Me.btnmorado.UseVisualStyleBackColor = False
        '
        'btbamarillo
        '
        Me.btbamarillo.BackColor = System.Drawing.Color.Gold
        Me.btbamarillo.Font = New System.Drawing.Font("Rockwell Extra Bold", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbamarillo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btbamarillo.Location = New System.Drawing.Point(73, 347)
        Me.btbamarillo.Name = "btbamarillo"
        Me.btbamarillo.Size = New System.Drawing.Size(114, 37)
        Me.btbamarillo.TabIndex = 9
        Me.btbamarillo.Text = "Amarillo"
        Me.btbamarillo.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(694, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Cesar Vargas"
        '
        'colores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btbamarillo)
        Me.Controls.Add(Me.btnmorado)
        Me.Controls.Add(Me.btnazul)
        Me.Controls.Add(Me.btnverde)
        Me.Controls.Add(Me.txtcolores)
        Me.Controls.Add(Me.Btnrojo)
        Me.Name = "colores"
        Me.Text = "colores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btnrojo As Button
    Friend WithEvents txtcolores As TextBox
    Friend WithEvents btnverde As Button
    Friend WithEvents btnazul As Button
    Friend WithEvents btnmorado As Button
    Friend WithEvents btbamarillo As Button
    Friend WithEvents Label1 As Label
End Class
