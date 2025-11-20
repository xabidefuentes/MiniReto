Imports System.Numerics

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub


    Private Sub btAñadir_Click(sender As Object, e As EventArgs) Handles btAñadir.Click


        Dim titulo As String = tbTitulo.Text
        Dim plataformas As String = tbPlataforma.Text
        Dim estudio As String = tbestudio.Text
        Dim speedrunner As String = tbSpeedrunner.Text
        Dim speedrun As Double = 0.0
        Dim año As Integer = 0

        ' VALIDACIÓN DE CAMPOS VACÍOS O EN BLANCO 

        If String.IsNullOrWhiteSpace(titulo) Then
            MessageBox.Show("El título no puede estar vacío.")
            tbTitulo.Focus()
            Return ' Usa Return para salir del Sub y NO añadir el videojuego
        End If

        If String.IsNullOrWhiteSpace(plataformas) Then
            MessageBox.Show("La plataforma no puede estar vacía.")
            tbPlataforma.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(estudio) Then
            MessageBox.Show("El estudio no puede estar vacío.")
            tbestudio.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(tbSpeedrun.Text) Then
            MessageBox.Show("El tiempo de Speedrun no puede estar vacío.")
            tbSpeedrun.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(speedrunner) Then
            MessageBox.Show("El speedrunner no puede estar vacío.")
            tbSpeedrunner.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(tbAño.Text) Then
            MessageBox.Show("El año no puede estar vacío.")
            tbAño.Focus()
            Return
        End If

        ' VALIDACIÓN DE TIPO DE DATOS  

        ' Convertir Speedrun a Double
        Try
            speedrun = Convert.ToDouble(tbSpeedrun.Text)
        Catch ex As Exception
            MessageBox.Show("El valor de Speedrun no es un número válido.")
            tbSpeedrun.Focus()
            Return ' Salir si la conversión falla
        End Try

        ' Convertir Año a Integer
        Try
            año = Convert.ToInt32(tbAño.Text)
        Catch ex As Exception
            MessageBox.Show("El valor del año no es un número entero válido.")
            tbAño.Focus()
            Return ' Salir si la conversión falla
        End Try

        ' comprobacion de que metan letras / numeros


        If Not IsLetters(titulo) Then
            MessageBox.Show("El título solo puede contener letras.")
            tbTitulo.Focus()
            Return
        End If

        If Not IsLetters(plataformas) Then
            MessageBox.Show("La plataforma solo puede contener letras.")
            tbPlataforma.Focus()
            Return
        End If

        If Not IsLetters(estudio) Then
            MessageBox.Show("El estudio solo puede contener letras.")
            tbestudio.Focus()
            Return
        End If

        If Not IsLetters(speedrunner) Then
            MessageBox.Show("El speedrunner solo puede contener letras.")
            tbSpeedrunner.Focus()
            Return
        End If

        '  AÑADIR VIDEOJUEGO 

        Dim videojuego As New Videojuego(titulo, plataformas, estudio, año, speedrun, speedrunner)
        Form1.anadirVideojuego(videojuego)

        MessageBox.Show("Videojuego añadido correctamente.")

        ' Limpiar campos
        tbTitulo.Text = ""
        tbPlataforma.Text = ""
        tbestudio.Text = ""
        tbSpeedrun.Text = ""
        tbSpeedrunner.Text = ""
        tbAño.Text = ""

    End Sub

    'Metodo para comprobar que metan letras
    Function IsLetters(text As String) As Boolean
        Return text.All(Function(c) Char.IsLetter(c) Or Char.IsWhiteSpace(c))
    End Function


    Private Sub btVolver_Click(sender As Object, e As EventArgs) Handles btVolver.Click
        Dispose()
    End Sub


End Class