Imports System.IO
Imports System.Windows.Forms

Public Class Form1

    ' Array de videojuegos
    Private listaVideojuegos(99) As Videojuego
    Private cantidad As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar ejemplos al iniciar
        AñadirEjemplos()
        ActualizarListBox()
    End Sub

    Private Sub AñadirEjemplos()
        listaVideojuegos(cantidad) = New Videojuego("Super Mario 64", "Nintendo 64", "Nintendo", 1996, 3899, "cheese")
        cantidad += 1

        listaVideojuegos(cantidad) = New Videojuego("Portal", "PC", "Valve", 2007, 366, "CantEven")
        cantidad += 1

        listaVideojuegos(cantidad) = New Videojuego("Minecraft", "PC", "Mojang", 2011, 1320, "Illumina")
        cantidad += 1
    End Sub

    Private Sub ActualizarListBox()
        lbVideojuegos.Items.Clear()

        For i As Integer = 0 To cantidad - 1
            lbVideojuegos.Items.Add(
                $"{listaVideojuegos(i).titulo} | " &
                $"{listaVideojuegos(i).plataforma} | " &
                $"{listaVideojuegos(i).estudio} | " &
                $"{listaVideojuegos(i).anio} | " &
                $"{listaVideojuegos(i).tiempoSpeedrun} | " &
                $"{listaVideojuegos(i).recordista}"
            )
        Next
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If lbVideojuegos.SelectedIndex = -1 Then
            MessageBox.Show("Selecciona un videojuego para eliminar.")
            Return
        End If

        Dim index As Integer = lbVideojuegos.SelectedIndex

        ' Desplazar el array hacia arriba
        For i As Integer = index To cantidad - 2
            listaVideojuegos(i) = listaVideojuegos(i + 1)
        Next

        cantidad -= 1

        ActualizarListBox()
    End Sub

    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Form2.Show()
    End Sub
End Class
