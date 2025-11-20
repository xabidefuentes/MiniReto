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
        ActualizarListView()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvVideojuegos.View = View.Details
        lvVideojuegos.FullRowSelect = True
        lvVideojuegos.GridLines = True

        ' Agregar columnas
        lvVideojuegos.Columns.Add("", 180)
        lvVideojuegos.Columns.Add("", 180)
        lvVideojuegos.Columns.Add("", 200)
        lvVideojuegos.Columns.Add("", 130)
        lvVideojuegos.Columns.Add("", 220)
        lvVideojuegos.Columns.Add("", 230)
        lvVideojuegos.HeaderStyle = ColumnHeaderStyle.None

        ActualizarListView()
    End Sub


    Private Sub ActualizarListView()

        lvVideojuegos.Items.Clear()

        For i As Integer = 0 To cantidad - 1

            Dim v As Videojuego = listaVideojuegos(i)

            Dim item As New ListViewItem(v.titulo) ' celda 1
            item.SubItems.Add(v.plataforma)        ' celda 2
            item.SubItems.Add(v.estudio)           ' celda 3
            item.SubItems.Add(v.anio.ToString())   ' celda 4
            item.SubItems.Add(v.tiempoSpeedrun.ToString()) ' celda 5
            item.SubItems.Add(v.recordista)        ' celda 6

            lvVideojuegos.Items.Add(item)

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
                    Dim v As Videojuego = listaVideojuegos(i)

                    writer.WriteLine(
                        $"{v.titulo};{v.plataforma};{v.estudio};{v.anio};{v.tiempoSpeedrun};{v.recordista}"
                    )
                Next
            End Using

            MessageBox.Show("Archivo guardado correctamente.")
        End If

    End Sub


    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        Form2.Show()
    End Sub

End Class
