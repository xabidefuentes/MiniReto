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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ' Verificar que haya un elemento seleccionado
        If lvVideojuegos.SelectedItems.Count = 0 Then
            MessageBox.Show("Selecciona un videojuego para eliminar.")
            Return
        End If

        ' Mostrar mensaje de confirmación
        Dim resultado As DialogResult = MessageBox.Show(
        "¿Estás seguro de que quieres eliminar este videojuego?",
        "Confirmar eliminación",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning
    )

        If resultado = DialogResult.No Then
            Return ' Cancelar eliminación
        End If

        Dim index As Integer = lvVideojuegos.SelectedItems(0).Index

        ' Mover los elementos a la izquierda para rellenar el hueco
        For i As Integer = index To cantidad - 2
            listaVideojuegos(i) = listaVideojuegos(i + 1)
        Next

        ' Reducimos la cantidad
        cantidad -= 1

        ' Limpiar el último elemento
        listaVideojuegos(cantidad) = Nothing

        ' Actualizar ListView
        ActualizarListView()

        MessageBox.Show("Videojuego eliminado correctamente.")
    End Sub
End Class
