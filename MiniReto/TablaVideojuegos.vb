Imports System.IO
Imports System.Windows.Forms

Public Class TablaVideojuego
    Inherits Form

    ' Controles
    Private lvVideojuegos As New ListView()
    Private btnGuardar As New Button()
    Private btnEliminar As New Button()

    ' Array de videojuegos
    Private listaVideojuegos(99) As Videojuego
    Private cantidad As Integer = 0

    Public Sub New()
        ' Configuración básica del formulario
        Me.Text = "Lista de Videojuegos"
        Me.Size = New Drawing.Size(700, 400)

        ' Configurar ListView
        lvVideojuegos.Location = New Drawing.Point(10, 10)
        lvVideojuegos.Size = New Drawing.Size(660, 250)
        lvVideojuegos.View = View.Details
        lvVideojuegos.FullRowSelect = True
        lvVideojuegos.GridLines = True
        lvVideojuegos.Columns.Add("Título", 150)
        lvVideojuegos.Columns.Add("Plataforma", 100)
        lvVideojuegos.Columns.Add("Estudio", 100)
        lvVideojuegos.Columns.Add("Año", 50)
        lvVideojuegos.Columns.Add("Tiempo", 60)
        lvVideojuegos.Columns.Add("Recordista", 100)
        Me.Controls.Add(lvVideojuegos)

        ' Botón Guardar
        btnGuardar.Text = "Guardar"
        btnGuardar.Location = New Drawing.Point(10, 270)
        AddHandler btnGuardar.Click, AddressOf btnGuardar_Click
        Me.Controls.Add(btnGuardar)

        ' Botón Eliminar
        btnEliminar.Text = "Eliminar"
        btnEliminar.Location = New Drawing.Point(100, 270)
        AddHandler btnEliminar.Click, AddressOf btnEliminar_Click
        Me.Controls.Add(btnEliminar)

        ' Añadir ejemplos y mostrar
        AñadirEjemplos()
        ActualizarListView()
    End Sub

    Private Sub AñadirEjemplos()
        listaVideojuegos(cantidad) = New Videojuego("Super Mario 64", "Nintendo 64", "Nintendo", 1996, 3899, "cheese")
        cantidad += 1
        listaVideojuegos(cantidad) = New Videojuego("Portal", "PC", "Valve", 2007, 366, "CantEven")
        cantidad += 1
        listaVideojuegos(cantidad) = New Videojuego("Minecraft", "PC", "Mojang", 2011, 1320, "Illumina")
        cantidad += 1
    End Sub

    Private Sub ActualizarListView()
        lvVideojuegos.Items.Clear()
        For i As Integer = 0 To cantidad - 1
            Dim item As New ListViewItem(listaVideojuegos(i).titulo)
            item.SubItems.Add(listaVideojuegos(i).plataforma)
            item.SubItems.Add(listaVideojuegos(i).estudio)
            item.SubItems.Add(listaVideojuegos(i).anio.ToString())
            item.SubItems.Add(listaVideojuegos(i).tiempoSpeedrun.ToString())
            item.SubItems.Add(listaVideojuegos(i).recordista)
            lvVideojuegos.Items.Add(item)
        Next
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs)
        If cantidad = 0 Then
            MessageBox.Show("No hay datos para guardar")
            Return
        End If

        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Archivos de texto|*.txt"
        saveDialog.FileName = "videojuegos.txt"

        If saveDialog.ShowDialog() = DialogResult.OK Then
            Using writer As New StreamWriter(saveDialog.FileName)
                writer.WriteLine("TÍTULO;PLATAFORMA;ESTUDIO;AÑO;TIEMPO;RECORDISTA")
                For i As Integer = 0 To cantidad - 1
                    writer.WriteLine($"{listaVideojuegos(i).titulo};{listaVideojuegos(i).plataforma};{listaVideojuegos(i).estudio};{listaVideojuegos(i).Año};{listaVideojuegos(i).tiempoSpeedrun};{listaVideojuegos(i).recordista}")
                Next
            End Using
            MessageBox.Show("Guardado correctamente")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)
        If lvVideojuegos.SelectedIndices.Count > 0 Then
            Dim index As Integer = lvVideojuegos.SelectedIndices(0)
            For i As Integer = index To cantidad - 2
                listaVideojuegos(i) = listaVideojuegos(i + 1)
            Next
            cantidad -= 1
            ActualizarListView()
        Else
            MessageBox.Show("Selecciona un videojuego para eliminar")
        End If
    End Sub

    Private Sub InitializeComponent()

    End Sub
End Class
