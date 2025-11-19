Public Class Form2

    Dim gestor As New Fichero("videojuegos.txt")

    Private Sub btAñadir_Click(sender As Object, e As EventArgs) Handles btAñadir.Click

        Dim titulo As String
        Dim plataformas As String
        Dim estudio As String
        Dim speedrun As Double
        Dim speedrunner As String
        Dim año As Integer


        titulo = tbTitulo.Text
        plataformas = tbPlataforma.Text
        estudio = tbPlataforma.Text
        speedrun = tbSpeedrun.Text
        speedrunner = tbSpeedrunner.Text
        año = tbAño.Text

        gestor.CrearFicheroNuevo()

        Dim videojuego As New Videojuego(titulo, plataformas, estudio, año, speedrun, speedrunner)

        gestor.aniadirRegistro(videojuego)






    End Sub
End Class