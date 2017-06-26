<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnVert = New System.Windows.Forms.Button()
        Me.PicBox = New System.Windows.Forms.PictureBox()
        Me.btnArsitas = New System.Windows.Forms.Button()
        Me.btnGrafo = New System.Windows.Forms.Button()
        Me.btnIni = New System.Windows.Forms.Button()
        Me.btnFin = New System.Windows.Forms.Button()
        Me.btnClean = New System.Windows.Forms.Button()
        Me.btnCamino = New System.Windows.Forms.Button()
        Me.btnResetCam = New System.Windows.Forms.Button()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVert
        '
        Me.btnVert.Location = New System.Drawing.Point(653, 12)
        Me.btnVert.Name = "btnVert"
        Me.btnVert.Size = New System.Drawing.Size(127, 31)
        Me.btnVert.TabIndex = 0
        Me.btnVert.Text = "Vertices"
        Me.btnVert.UseVisualStyleBackColor = True
        '
        'PicBox
        '
        Me.PicBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PicBox.Location = New System.Drawing.Point(12, 12)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(600, 800)
        Me.PicBox.TabIndex = 1
        Me.PicBox.TabStop = False
        '
        'btnArsitas
        '
        Me.btnArsitas.Enabled = False
        Me.btnArsitas.Location = New System.Drawing.Point(653, 59)
        Me.btnArsitas.Name = "btnArsitas"
        Me.btnArsitas.Size = New System.Drawing.Size(127, 33)
        Me.btnArsitas.TabIndex = 2
        Me.btnArsitas.Text = "Aristas"
        Me.btnArsitas.UseVisualStyleBackColor = True
        '
        'btnGrafo
        '
        Me.btnGrafo.Enabled = False
        Me.btnGrafo.Location = New System.Drawing.Point(653, 108)
        Me.btnGrafo.Name = "btnGrafo"
        Me.btnGrafo.Size = New System.Drawing.Size(127, 32)
        Me.btnGrafo.TabIndex = 3
        Me.btnGrafo.Text = "Grafo Visibilidad"
        Me.btnGrafo.UseVisualStyleBackColor = True
        '
        'btnIni
        '
        Me.btnIni.Enabled = False
        Me.btnIni.Location = New System.Drawing.Point(653, 178)
        Me.btnIni.Name = "btnIni"
        Me.btnIni.Size = New System.Drawing.Size(127, 31)
        Me.btnIni.TabIndex = 4
        Me.btnIni.Text = "Punto Inicio"
        Me.btnIni.UseVisualStyleBackColor = True
        '
        'btnFin
        '
        Me.btnFin.Enabled = False
        Me.btnFin.Location = New System.Drawing.Point(653, 215)
        Me.btnFin.Name = "btnFin"
        Me.btnFin.Size = New System.Drawing.Size(127, 30)
        Me.btnFin.TabIndex = 5
        Me.btnFin.Text = "Punto Fin"
        Me.btnFin.UseVisualStyleBackColor = True
        '
        'btnClean
        '
        Me.btnClean.Location = New System.Drawing.Point(653, 543)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(127, 80)
        Me.btnClean.TabIndex = 8
        Me.btnClean.Text = "Limpiar"
        Me.btnClean.UseVisualStyleBackColor = True
        '
        'btnCamino
        '
        Me.btnCamino.Enabled = False
        Me.btnCamino.Location = New System.Drawing.Point(653, 251)
        Me.btnCamino.Name = "btnCamino"
        Me.btnCamino.Size = New System.Drawing.Size(127, 30)
        Me.btnCamino.TabIndex = 9
        Me.btnCamino.Text = "Calcular Camino"
        Me.btnCamino.UseVisualStyleBackColor = True
        '
        'btnResetCam
        '
        Me.btnResetCam.Enabled = False
        Me.btnResetCam.Location = New System.Drawing.Point(787, 178)
        Me.btnResetCam.Name = "btnResetCam"
        Me.btnResetCam.Size = New System.Drawing.Size(71, 103)
        Me.btnResetCam.TabIndex = 10
        Me.btnResetCam.Text = "Recalcular"
        Me.btnResetCam.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 831)
        Me.Controls.Add(Me.btnResetCam)
        Me.Controls.Add(Me.btnCamino)
        Me.Controls.Add(Me.btnClean)
        Me.Controls.Add(Me.btnFin)
        Me.Controls.Add(Me.btnIni)
        Me.Controls.Add(Me.btnGrafo)
        Me.Controls.Add(Me.btnArsitas)
        Me.Controls.Add(Me.PicBox)
        Me.Controls.Add(Me.btnVert)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnVert As Button
    Friend WithEvents PicBox As PictureBox
    Friend WithEvents btnArsitas As Button
    Friend WithEvents btnGrafo As Button
    Friend WithEvents btnIni As Button
    Friend WithEvents btnFin As Button
    Friend WithEvents btnClean As Button
    Friend WithEvents btnCamino As Button
    Friend WithEvents btnResetCam As Button
End Class
