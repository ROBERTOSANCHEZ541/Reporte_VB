<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte
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
        Me.CbTipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PbExcel = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        CType(Me.PbExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CbTipo
        '
        Me.CbTipo.FormattingEnabled = True
        Me.CbTipo.Items.AddRange(New Object() {"E", "I"})
        Me.CbTipo.Location = New System.Drawing.Point(170, 108)
        Me.CbTipo.Name = "CbTipo"
        Me.CbTipo.Size = New System.Drawing.Size(121, 21)
        Me.CbTipo.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(55, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 19)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Tipo Instructor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(89, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 22)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Reporte control de curso"
        '
        'PbExcel
        '
        Me.PbExcel.BackColor = System.Drawing.Color.Transparent
        Me.PbExcel.Image = Global.Reporte_Xlsx.My.Resources.Resources.excel
        Me.PbExcel.Location = New System.Drawing.Point(170, 152)
        Me.PbExcel.Name = "PbExcel"
        Me.PbExcel.Size = New System.Drawing.Size(78, 63)
        Me.PbExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PbExcel.TabIndex = 19
        Me.PbExcel.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(89, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 19)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Exportar"
        '
        'DtpFecha
        '
        Me.DtpFecha.Enabled = False
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(151, 34)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(87, 20)
        Me.DtpFecha.TabIndex = 26
        '
        'Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Reporte_Xlsx.My.Resources.Resources.azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(379, 288)
        Me.Controls.Add(Me.DtpFecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbTipo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PbExcel)
        Me.Name = "Reporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte"
        CType(Me.PbExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CbTipo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PbExcel As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DtpFecha As DateTimePicker
End Class
