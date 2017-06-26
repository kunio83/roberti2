Imports System.Windows.Forms
Imports Caminovisualiz.Form1
Module Module1

    ' Realizar este algoritmo previamente para los vertices fijos
    ' y completar archivo distancias
    Dim Distancias(,) As Double
    Dim Vertices() As Vertice
    Dim Aristas() As Arista
    Dim nVert, nAris As Integer
    Sub Carga_Vertices()
        Dim myPen As New System.Drawing.Pen(System.Drawing.Color.Blue)
        Dim dwFuente As New Font("Arial", 12)
        Dim dwBrush As New SolidBrush(Color.Black)
        Dim vectaux() As String
        FileOpen(1, "vertices.txt", OpenMode.Input)
        nVert = CInt(LineInput(1))
        ReDim Vertices(nVert - 1)
        For i = 0 To nVert - 3
            vectaux = Split(LineInput(1))
            Vertices(i).x = CDbl(vectaux(0))
            Vertices(i).y = CDbl(vectaux(1))
            Form1.DibVert.DrawEllipse(myPen, CInt(Vertices(i).x - 2.5 + 5), CInt(780 - Vertices(i).y - 2.5 + 5), 5, 5)
            Form1.DibVert.DrawString(i, dwFuente, dwBrush, CInt(Vertices(i).x + 4 + 5), CInt(780 - Vertices(i).y))
        Next
        FileClose(1)

    End Sub

    Sub Carga_Aristas()
        Dim myPen As New System.Drawing.Pen(System.Drawing.Color.Blue, 2)
        Dim vectaux() As String
        FileOpen(2, "aristas.txt", OpenMode.Input)
        nAris = CInt(LineInput(2))
        ReDim Aristas(nAris - 1)
        For i = 0 To nAris - 1
            vectaux = Split(LineInput(2))
            Aristas(i).v0 = CInt(vectaux(0))
            Aristas(i).v1 = CInt(vectaux(1))
            Aristas(i).Polig = CInt(vectaux(2)) 'Numero de Objeto
            Form1.DibVert.DrawLine(myPen, CInt(Vertices(Aristas(i).v0).x + 5), CInt(780 - Vertices(Aristas(i).v0).y + 5), CInt(Vertices(Aristas(i).v1).x + 5), CInt(780 - Vertices(Aristas(i).v1).y + 5))

        Next
        FileClose(2)
    End Sub



    Sub Grafo_Visib()
        Dim myPen As New System.Drawing.Pen(System.Drawing.Color.Green)
        'Definir vector de Vertices, Artistas y Matriz de Distancias y Cargar datos
        Dim txtAux As String
        Dim Polv0, Polv1 As Integer
        Dim Dist As Double
        Dim vIni, vEval, aristV0, aristV1 As Vertice
        Dim Visib As Boolean


        ReDim Distancias(nVert - 1, nVert - 1)

        'Evalua visibilidad de los nodos
        For v = 0 To UBound(Vertices) - 1
            vIni.x = Vertices(v).x
            vIni.y = Vertices(v).y
            For i = v + 1 To UBound(Vertices)

                'borrar
                If v = 4 And i = 6 Then
                    Visib = True
                End If
                'borrar


                Visib = True
                vEval.x = Vertices(i).x
                vEval.y = Vertices(i).y

                For j = 0 To UBound(Aristas)
                    If (v = Aristas(j).v0 And i = Aristas(j).v1) Or (v = Aristas(j).v1 And i = Aristas(j).v0) Then ' Si son los vertices de una misma arista
                        GoTo Finaliz
                    End If
                Next

                For j = 0 To UBound(Aristas)
                    If Aristas(j).v0 = v Or Aristas(j).v1 = v Then
                        Polv0 = Aristas(j).Polig
                    End If
                    If Aristas(j).v0 = i Or Aristas(j).v1 = i Then
                        Polv1 = Aristas(j).Polig
                    End If
                    If Aristas(j).v0 = v Or Aristas(j).v1 = v Or Aristas(j).v0 = i Or Aristas(j).v1 = i Then ' No se evaluan las aristas con un vertice coincidente
                        GoTo Siguiente
                    End If
                    aristV0.x = Vertices(Aristas(j).v0).x
                    aristV0.y = Vertices(Aristas(j).v0).y
                    aristV1.x = Vertices(Aristas(j).v1).x
                    aristV1.y = Vertices(Aristas(j).v1).y
                    Visib = Visibilidad(vIni, vEval, aristV0, aristV1)
                    If Visib = False Then Exit For
Siguiente:
                Next

                If Visib = True And Polv0 = Polv1 Then
                    If Interno(vIni, vEval, Polv0, Aristas, Vertices) Then
                        Visib = False
                    End If
                End If

Finaliz:
                If Visib = True Then
                    Dist = Math.Round(Math.Sqrt(Math.Pow(Math.Abs(vIni.x - vEval.x), 2) + Math.Pow(Math.Abs(vIni.y - vEval.y), 2)), 2)
                    Form1.DibVert.DrawLine(myPen, CInt(Vertices(v).x + 5), CInt(780 - Vertices(v).y + 5), CInt(Vertices(i).x + 5), CInt(780 - Vertices(i).y + 5))
                Else
                    Dist = -1
                End If

                Distancias(v, i) = Dist
                Distancias(i, v) = Dist
            Next
        Next
        FileOpen(3, "distancias.txt", OpenMode.Output)
        For i = 0 To nVert - 3
            Distancias(i, i) = -1
            txtAux = ""
            For j = 0 To nVert - 3
                txtAux &= Distancias(i, j)
                If j < nVert - 3 Then
                    txtAux &= " "
                End If
            Next
            PrintLine(3, txtAux)
        Next
        FileClose(3)
    End Sub

    Sub Ini_Fin(vIni As Vertice, vFin As Vertice)
        Vertices(UBound(Vertices) - 1) = vIni
        Vertices(UBound(Vertices)) = vFin
        Dim Camino() As Integer
        Dim aristaV1, aristaV2, vEval As Vertice
        Dim Dist As Double
        Dim Visib As Boolean
        For i = 0 To UBound(Vertices)
            Visib = True
            If i <> UBound(Vertices) - 1 Then
                vEval.x = Vertices(i).x
                vEval.y = Vertices(i).y

                For j = 0 To UBound(Aristas)
                    If i <> Aristas(j).v0 And i <> Aristas(j).v1 Then ' Si el vertice es parte de la Arista, esta no se evalua
                        aristaV1.x = Vertices(Aristas(j).v0).x
                        aristaV1.y = Vertices(Aristas(j).v0).y
                        aristaV2.x = Vertices(Aristas(j).v1).x
                        aristaV2.y = Vertices(Aristas(j).v1).y
                        Visib = Visibilidad(vIni, vEval, aristaV1, aristaV2)
                    End If
                    If Visib = False Then Exit For
                Next
            Else
                Visib = False
            End If
            If Visib = True Then
                Dist = Math.Sqrt(Math.Pow(Math.Abs(vIni.x - vEval.x), 2) + Math.Pow(Math.Abs(vIni.y - vEval.y), 2))
            Else
                Dist = -1
            End If
            Distancias(UBound(Vertices) - 1, i) = Dist
            Distancias(i, UBound(Vertices) - 1) = Dist
        Next


        ' Para los ultimos dos vertices (INICIO y FIN) evaluar visibilidad a los vertices
        ' y completar la matriz distancias con las distancias a los vertices visibles o
        ' -1 a los vertices no visibles

        'Evalua visibilidad de vertice FIN a nodos y agrega distancias a matriz (o -1 si no hay visibilidad)
        For i = 0 To UBound(Vertices)
            Visib = True
            If i <> UBound(Vertices) Then
                vEval.x = Vertices(i).x
                vEval.y = Vertices(i).y

                For j = 0 To UBound(Aristas)
                    If i <> Aristas(j).v0 And i <> Aristas(j).v1 Then ' Si el vertice es parte de la Arista, esta no se evalua
                        aristaV1.x = Vertices(Aristas(j).v0).x
                        aristaV1.y = Vertices(Aristas(j).v0).y
                        aristaV2.x = Vertices(Aristas(j).v1).x
                        aristaV2.y = Vertices(Aristas(j).v1).y
                        Visib = Visibilidad(vFin, vEval, aristaV1, aristaV2)
                    End If
                    If Visib = False Then Exit For
                Next
            Else
                Visib = False
            End If
            If Visib = True Then
                Dist = Math.Sqrt(Math.Pow(Math.Abs(vFin.x - vEval.x), 2) + Math.Pow(Math.Abs(vFin.y - vEval.y), 2))
            Else
                Dist = -1
            End If
            Distancias(UBound(Vertices), i) = Dist
            Distancias(i, UBound(Vertices)) = Dist
        Next

        Camino = Dijkstra(Distancias, UBound(Vertices) - 1, UBound(Vertices))

        Archivo_Salida(Camino, Distancias, Vertices)



        ' En arduino Traducir Distancia/tiempo e implementar medicion de control y correccion de posición
    End Sub

    Function Dijkstra(MatDist(,) As Double, Ini As Integer, Fin As Integer) As Integer()
        Dim MatDij(Fin) As Dijk
        Dim Cola(0) As ColaDijk
        Dim VEval As ColaDijk
        Dim Aux As ColaDijk
        Dim CaminoResul(0) As Integer

        ' Algoritmo de Dijkstra comenzando en vertice INICIO hasta vertice FIN visto.
        For i = 0 To Fin
            MatDij(i).Dist = 1000000
            MatDij(i).Padre = -1
            MatDij(i).Visto = False
        Next
        MatDij(Ini).Dist = 0
        Cola(0).Dist = 0
        Cola(0).Nodo = Ini
        Do While (Cola(0).Dist <> -1)
            For i = 0 To UBound(Cola)
                For j = i + 1 To UBound(Cola)
                    If Cola(i).Dist < Cola(j).Dist Then
                        Aux.Dist = Cola(i).Dist
                        Aux.Nodo = Cola(i).Nodo
                        Cola(i).Dist = Cola(j).Dist
                        Cola(i).Nodo = Cola(j).Nodo
                        Cola(j).Dist = Aux.Dist
                        Cola(j).Nodo = Aux.Nodo
                    End If
                Next
            Next
            VEval = Cola(UBound(Cola))
            If VEval.Nodo = Fin Then GoTo Final 'vertice FIN visto.
            If UBound(Cola) = 0 Then
                Cola(0).Dist = -1
            Else
                ReDim Preserve Cola(UBound(Cola) - 1)
            End If
            MatDij(VEval.Nodo).Visto = True
            For i = 0 To Fin
                If MatDist(VEval.Nodo, i) <> -1 Then
                    If MatDij(i).Visto = False And MatDij(i).Dist > VEval.Dist + MatDist(VEval.Nodo, i) Then
                        MatDij(i).Dist = VEval.Dist + MatDist(VEval.Nodo, i)
                        MatDij(i).Padre = VEval.Nodo
                        If Cola(0).Dist = -1 Then
                            Cola(0).Dist = MatDij(i).Dist
                            Cola(0).Nodo = i
                        Else
                            ReDim Preserve Cola(UBound(Cola) + 1)
                            Cola(UBound(Cola)).Dist = MatDij(i).Dist
                            Cola(UBound(Cola)).Nodo = i
                        End If
                    End If
                End If
            Next
        Loop

Final:
        ' Devolver camino siguiendo en orden inverso los nodos PADRES en matriz Dijkstra desde
        ' FIN hasta INICIO
        CaminoResul(0) = Fin
        Do While MatDij(CaminoResul(UBound(CaminoResul))).Padre <> -1
            ReDim Preserve CaminoResul(UBound(CaminoResul) + 1)
            CaminoResul(UBound(CaminoResul)) = MatDij(CaminoResul(UBound(CaminoResul) - 1)).Padre
        Loop
        Array.Reverse(CaminoResul)
        Return CaminoResul
    End Function

    Sub Archivo_Salida(Camino() As Integer, MatDist(,) As Double, matVert() As Vertice)
        Dim myPen As New System.Drawing.Pen(System.Drawing.Color.Red, 4)
        ' Calcular Angulo de tramos de caminos (VER-> se puede integrar angulo en matriz distancias)
        ' Devolver archivo de indicaciones NODO-ANG-DIST
        Dim p0, p1 As Vertice
        Dim distX, distY, distP, Ang As Double
        FileOpen(4, "Camino_min.txt", OpenMode.Output)
        If Camino.Length = 1 Then
            PrintLine(4, "Sin camino")
            Exit Sub
        Else
            For i = 0 To UBound(Camino) - 1
                p0.x = matVert(Camino(i)).x
                p0.y = matVert(Camino(i)).y
                p1.x = matVert(Camino(i + 1)).x
                p1.y = matVert(Camino(i + 1)).y
                distP = MatDist(Camino(i), Camino(i + 1))
                distX = Math.Abs(p1.x - p0.x)
                distY = Math.Abs(p1.y - p0.y)
                Ang = 0
                If p1.x > p0.x And p1.y >= p0.y Then
                    Ang = Math.Atan(distX / distY) / (Math.PI / 180)
                ElseIf p1.x >= p0.x And p1.y < p0.y Then
                    Ang = 90 + Math.Atan(distY / distX) / (Math.PI / 180)
                ElseIf p1.x < p0.x And p1.y <= p0.y Then
                    Ang = 180 + Math.Atan(distX / distY) / (Math.PI / 180)
                ElseIf p1.x < p0.x And p1.y > p0.y Then
                    Ang = 270 + Math.Atan(distY / distX) / (Math.PI / 180)
                End If
                PrintLine(4, Camino(i + 1) & " " & Math.Round(Ang, 4) & " " & Math.Round(distP, 2))
                Form1.DibVert.DrawLine(myPen, CInt(p0.x + 5), CInt(780 - p0.y + 5), CInt(p1.x + 5), CInt(780 - p1.y + 5))
            Next
        End If

        FileClose(4)

    End Sub

    Function Visibilidad(p0 As Vertice, p1 As Vertice, p2 As Vertice, p3 As Vertice) As Boolean
        Dim mA, mB, IntX, IntY As Double
        Dim PertA, PertB As Boolean
        'Calcula pendiente A en mA
        If p0.x = p1.x Then
            mA = -1
        Else
            mA = (p1.y - p0.y) / (p1.x - p0.x)
        End If
        'Calcula pendiente B en mB
        If p2.x = p3.x Then
            mB = -1
        Else
            mB = (p3.y - p2.y) / (p3.x - p2.x)
        End If
        If mA = mB Then 'Rectas Paralelas
            Return True
        Else
            If p0.x = p1.x Then
                IntX = p0.x
            ElseIf p2.x = p3.x Then
                IntX = p2.x
            Else
                IntX = (mA * p0.x - p0.y - mB * p2.x + p2.y) / (mA - mB)
            End If

            If p0.x = p1.x Then
                IntY = mB * (IntX - p2.x) + p2.y
            Else
                IntY = mA * (IntX - p0.x) + p0.y
            End If

            IntX = Math.Round(IntX, 2)
            IntY = Math.Round(IntY, 2)

            PertA = IntX >= Math.Round(Math.Min(p0.x, p1.x), 2) And IntX <= Math.Round(Math.Max(p0.x, p1.x), 2) And IntY >= Math.Round(Math.Min(p0.y, p1.y), 2) And IntY <= Math.Round(Math.Max(p0.y, p1.y), 2)
            PertB = IntX >= Math.Round(Math.Min(p2.x, p3.x), 2) And IntX <= Math.Round(Math.Max(p2.x, p3.x), 2) And IntY >= Math.Round(Math.Min(p2.y, p3.y), 2) And IntY <= Math.Round(Math.Max(p2.y, p3.y), 2)

            If PertA And PertB Then
                Return False
            Else
                Return True
            End If

        End If

    End Function
    Public Structure Dijk
        Dim Dist As Double
        Dim Padre As Integer
        Dim Visto As Boolean
    End Structure

    Public Structure ColaDijk
        Dim Dist As Double
        Dim Nodo As Integer
    End Structure

    Public Structure Vertice
        Dim x As Double
        Dim y As Double
    End Structure

    Public Structure Arista
        Dim v0 As Integer
        Dim v1 As Integer
        Dim Polig As Integer
    End Structure

    Function Interno(v0 As Vertice, v1 As Vertice, Pol As Integer, Aristas() As Arista, Vertices() As Vertice)
        Dim Vm, Vmf As Vertice 'Vm - Punto medio | punto final prolongacion semirecta
        Dim aristV0, aristV1 As Vertice
        Dim iniPol As Boolean
        Dim ContInt As Integer
        Vm.x = v0.x + ((v1.x - v0.x) / 2)
        Vm.y = v0.y + ((v1.y - v0.y) / 2)
        Vmf.x = Vm.x
        Vmf.y = Vm.y + 10000
        iniPol = False
        ContInt = 0
        For i = 0 To UBound(Aristas)
            If Aristas(i).Polig = Pol Then
                iniPol = True
                aristV0.x = Vertices(Aristas(i).v0).x
                aristV0.y = Vertices(Aristas(i).v0).y
                aristV1.x = Vertices(Aristas(i).v1).x
                aristV1.y = Vertices(Aristas(i).v1).y
                If Visibilidad(Vm, Vmf, aristV0, aristV1) = False Then
                    ContInt += 1
                End If
            Else
                If iniPol Then
                    Exit For
                End If
            End If
        Next
        If ContInt = 0 Or ContInt Mod 2 = 0 Then
            Return False
        Else
            Return True
        End If
    End Function


End Module
