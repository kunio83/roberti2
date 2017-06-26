Imports System.Windows.Input
Public Class Form1
    Public DibVert As System.Drawing.Graphics
    Dim EspInicio, EspFin As Boolean
    Dim pIni, pFin As Vertice

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DibVert = Me.PicBox.CreateGraphics()

        EspFin = False
        EspInicio = False
        'PictureBox2.Location = PictureBox2.Location - PictureBox1.Location
    End Sub

    Private Sub btnVert_Click(sender As Object, e As EventArgs) Handles btnVert.Click
        Module1.Carga_Vertices()
        btnVert.Enabled = False
        btnArsitas.Enabled = True
    End Sub

    Private Sub btnArsitas_Click(sender As Object, e As EventArgs) Handles btnArsitas.Click
        Module1.Carga_Aristas()
        btnArsitas.Enabled = False
        btnGrafo.Enabled = True
    End Sub

    Private Sub btnGrafo_Click(sender As Object, e As EventArgs) Handles btnGrafo.Click
        Module1.Grafo_Visib()
        btnGrafo.Enabled = False
        btnIni.Enabled = True
    End Sub

    Private Sub btnFin_Click(sender As Object, e As EventArgs) Handles btnFin.Click
        If MsgBox("Haga clic para definir el punto final", vbOKCancel) = vbOK Then
            EspFin = True
        End If
    End Sub


    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        PicBox.Refresh()

        btnVert.Enabled = True
        btnArsitas.Enabled = False
        btnGrafo.Enabled = False
        btnIni.Enabled = False
        btnFin.Enabled = False
        btnCamino.Enabled = False
        btnResetCam.Enabled = False
    End Sub

    Private Sub btnCamino_Click(sender As Object, e As EventArgs) Handles btnCamino.Click
        Module1.Ini_Fin(pIni, pFin)
        btnCamino.Enabled = False
        btnResetCam.Enabled = True
    End Sub

    Private Sub btnResetCam_Click(sender As Object, e As EventArgs) Handles btnResetCam.Click
        PicBox.Refresh()
        Module1.Carga_Vertices()
        Module1.Carga_Aristas()
        Module1.Grafo_Visib()
        btnIni.Enabled = True
        btnCamino.Enabled = False
    End Sub

    Private Sub PicBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PicBox.MouseDown
        Dim myPen As New System.Drawing.Pen(System.Drawing.Color.BlueViolet)
        Dim dwFuente As New Font("Arial", 12)
        Dim dwBrush As New SolidBrush(Color.BlueViolet)

        If EspInicio Then
            pIni.x = e.X.ToString
            pIni.y = e.Y.ToString
            EspInicio = False
            DibVert.DrawEllipse(myPen, CInt(pIni.x - 2.5 + 5), CInt(pIni.y - 2.5 + 5), 5, 5)
            DibVert.DrawString("Inicio", dwFuente, dwBrush, pIni.x + 9, pIni.y)
            pIni.y = 780 - pIni.y
            btnIni.Enabled = False
            btnFin.Enabled = True
        End If

        If EspFin Then
            pFin.x = e.X.ToString
            pFin.y = e.Y.ToString
            EspFin = False
            DibVert.DrawEllipse(myPen, CInt(pFin.x - 2.5 + 5), CInt(pFin.y - 2.5 + 5), 5, 5)
            DibVert.DrawString("Fin", dwFuente, dwBrush, pFin.x + 9, pFin.y)
            pFin.y = 780 - pFin.y
            btnFin.Enabled = False
            btnCamino.Enabled = True
        End If

    End Sub
    Private Sub btnIni_Click(sender As Object, e As EventArgs) Handles btnIni.Click
        If MsgBox("Haga clic para definir el punto de inicio", vbOKCancel) = vbOK Then
            EspInicio = True
        End If

    End Sub


End Class
