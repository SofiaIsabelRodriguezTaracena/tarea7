<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Labelentrada = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxcomo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxVALOR = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxPESO = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.ListBox6 = New System.Windows.Forms.ListBox()
        Me.ButtonCALCULAR = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonSALIR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Documentos", "Ropa", "Artículos no pedecederos", "Artículos de plástico ", "Lociones"})
        Me.ComboBox1.Location = New System.Drawing.Point(62, 52)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Labelentrada
        '
        Me.Labelentrada.AutoSize = True
        Me.Labelentrada.Location = New System.Drawing.Point(66, 9)
        Me.Labelentrada.Name = "Labelentrada"
        Me.Labelentrada.Size = New System.Drawing.Size(117, 13)
        Me.Labelentrada.TabIndex = 1
        Me.Labelentrada.Text = "ENTRADA DE DATOS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "¿QUE ENVIA?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "¿COMO LO ENVIA?"
        '
        'ComboBoxcomo
        '
        Me.ComboBoxcomo.FormattingEnabled = True
        Me.ComboBoxcomo.Items.AddRange(New Object() {"Camion", "Moto"})
        Me.ComboBoxcomo.Location = New System.Drawing.Point(62, 101)
        Me.ComboBoxcomo.Name = "ComboBoxcomo"
        Me.ComboBoxcomo.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxcomo.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "NOMBRE DE QUIEN ENVIA"
        '
        'TextBoxNOMBRE
        '
        Me.TextBoxNOMBRE.Location = New System.Drawing.Point(62, 158)
        Me.TextBoxNOMBRE.Name = "TextBoxNOMBRE"
        Me.TextBoxNOMBRE.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNOMBRE.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "VALOR DEL PAQUETE"
        '
        'TextBoxVALOR
        '
        Me.TextBoxVALOR.Location = New System.Drawing.Point(62, 209)
        Me.TextBoxVALOR.Name = "TextBoxVALOR"
        Me.TextBoxVALOR.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxVALOR.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "PESO DEL PAQUETE"
        '
        'TextBoxPESO
        '
        Me.TextBoxPESO.Location = New System.Drawing.Point(62, 262)
        Me.TextBoxPESO.Name = "TextBoxPESO"
        Me.TextBoxPESO.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPESO.TabIndex = 10
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(227, 27)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 11
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(362, 27)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 95)
        Me.ListBox2.TabIndex = 12
        '
        'ListBox3
        '
        Me.ListBox3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(488, 27)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(120, 95)
        Me.ListBox3.TabIndex = 13
        '
        'ListBox4
        '
        Me.ListBox4.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(227, 128)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(120, 95)
        Me.ListBox4.TabIndex = 14
        '
        'ListBox5
        '
        Me.ListBox5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.Location = New System.Drawing.Point(362, 128)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(120, 95)
        Me.ListBox5.TabIndex = 15
        '
        'ListBox6
        '
        Me.ListBox6.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ListBox6.FormattingEnabled = True
        Me.ListBox6.Location = New System.Drawing.Point(488, 128)
        Me.ListBox6.Name = "ListBox6"
        Me.ListBox6.Size = New System.Drawing.Size(120, 95)
        Me.ListBox6.TabIndex = 16
        '
        'ButtonCALCULAR
        '
        Me.ButtonCALCULAR.Location = New System.Drawing.Point(227, 241)
        Me.ButtonCALCULAR.Name = "ButtonCALCULAR"
        Me.ButtonCALCULAR.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCALCULAR.TabIndex = 17
        Me.ButtonCALCULAR.Text = "CALCULAR"
        Me.ButtonCALCULAR.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(227, 270)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "LIMPIAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonSALIR
        '
        Me.ButtonSALIR.Location = New System.Drawing.Point(227, 299)
        Me.ButtonSALIR.Name = "ButtonSALIR"
        Me.ButtonSALIR.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSALIR.TabIndex = 19
        Me.ButtonSALIR.Text = "SALIR"
        Me.ButtonSALIR.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonSALIR)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonCALCULAR)
        Me.Controls.Add(Me.ListBox6)
        Me.Controls.Add(Me.ListBox5)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBoxPESO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxVALOR)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxNOMBRE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxcomo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Labelentrada)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Labelentrada As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxcomo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxNOMBRE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxVALOR As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxPESO As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents ListBox6 As ListBox
    Friend WithEvents ButtonCALCULAR As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonSALIR As Button
End Class
