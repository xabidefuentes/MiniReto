Imports System.Numerics

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub


    Private Sub btAñadir_Click(sender As Object, e As EventArgs) Handles btAñadir.Click

        Dim titulo As String
        Dim plataformas As String
        Dim estudio As String
        Dim speedrun As Double
        Dim speedrunner As String
        Dim año As Integer


        titulo = tbTitulo.Text
        plataformas = tbPlataforma.Text
        estudio = tbestudio.Text
        speedrun = tbSpeedrun.Text
        speedrunner = tbSpeedrunner.Text
        año = tbAño.Text


        Dim videojuego As New Videojuego(titulo, plataformas, estudio, año, speedrun, speedrunner)
        Form1.anadirVideojuego(videojuego)
        MessageBox.Show("Videojuego añadido")
        tbTitulo.Text = ""
        tbPlataforma.Text = ""
        tbestudio.Text = ""
        tbSpeedrun.Text = ""
        tbSpeedrunner.Text = ""
        tbAño.Text = ""




    End Sub



    Private Sub btVolver_Click(sender As Object, e As EventArgs) Handles btVolver.Click
        Dispose()
    End Sub

    Private Sub lbTituloPrincipal_Click(sender As Object, e As EventArgs) Handles lbTituloPrincipal.Click

    End Sub
End Class