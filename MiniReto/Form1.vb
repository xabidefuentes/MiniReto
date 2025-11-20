Imports System.IO
Imports System.Windows.Forms

Public Class Form1

    ' Array de videojuegos
    Private listaVideojuegos(99) As Videojuego
    Private cantidad As Integer = 0

    Public Sub anadirVideojuego(videojuego As Videojuego)
        ' Comprobar que no se supera el límite del array
        If cantidad >= listaVideojuegos.Length Then
            MessageBox.Show("No se pueden añadir más videojuegos (límite alcanzado).")
            Return
        End If

        ' Añadir el videojuego al array
        listaVideojuegos(cantidad) = videojuego
        cantidad += 1

        ' Actualizar la interfaz
        ActualizarListBox()
    End Sub

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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If cantidad = 0 Then
            MessageBox.Show("No hay datos para guardar.")
            Return
        End If

        Dim saveDialog As New SaveFileDialog With {
            .Filter = "Archivos de texto|*.txt",
            .FileName = "videojuegos.txt"
        }

        If saveDialog.ShowDialog() = DialogResult.OK Then
            Using writer As New StreamWriter(saveDialog.FileName)
                writer.WriteLine("TÍTULO;PLATAFORMA;ESTUDIO;AÑO;TIEMPO;RECORDISTA")

                For i As Integer = 0 To cantidad - 1
                    writer.WriteLine(
                        $"{listaVideojuegos(i).titulo};" &
                        $"{listaVideojuegos(i).plataforma};" &
                        $"{listaVideojuegos(i).estudio};" &
                        $"{listaVideojuegos(i).anio};" &
                        $"{listaVideojuegos(i).tiempoSpeedrun};" &
                        $"{listaVideojuegos(i).recordista}"
                    )
                Next
            End Using

            MessageBox.Show("Archivo guardado correctamente.")
        End If

    End Sub

    Private Sub btnAnadir_Click_1(sender As Object, e As EventArgs) Handles btnAnadir.Click
        Form2.Show()
    End Sub
End Class
