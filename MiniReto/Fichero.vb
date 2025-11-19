Imports System.IO



Public Class Fichero

        Public pFS As FileStream
        Public pBW As BinaryWriter
        Public pBR As BinaryReader
        Public sFicheroActual As String
        Public iNregs As Integer
        Public iTamanioReg As Integer
        Public bBorrar As Boolean


        ''Constructor

        Public Sub New(nombreFich As String)
            sFicheroActual = nombreFich
        End Sub




        Sub CrearFicheroNuevo()
            Dim bFichAbierto As Boolean = False ' Indica si hay un fichero abierto

            If bFichAbierto Then
                Console.WriteLine("Ya hay un fichero abierto. No se puede crear otro.")
                Return
            End If

            Dim rutaCarpeta As String = AppDomain.CurrentDomain.BaseDirectory '' Esto saca la ruta de la carpeta donde se encuentra el proyecto
            Dim rutaFichero As String = Path.Combine(rutaCarpeta, Me.sFicheroActual)

            Try
                If File.Exists(rutaFichero) Then
                    Console.WriteLine("El fichero ya existe. Introduce otro nombre.")
                Else
                    ' Crear fichero vacío
                    File.Create(rutaFichero).Close()
                    bFichAbierto = True
                    Console.WriteLine("Fichero creado correctamente: " & rutaFichero)
                End If

            Catch ex As Exception
                Console.WriteLine("Error al crear el fichero: " & ex.Message)
            End Try

        End Sub


    Public Sub aniadirRegistro(videojuego As Videojuego)

        Using fs As New FileStream(Me.sFicheroActual, FileMode.Append, FileAccess.Write, FileShare.Read)
            Using bw As New BinaryWriter(fs)
                bw.Write(videojuego.ToString() & Environment.NewLine)  ' Añade salto de línea
                bw.Flush()                             ' Fuerza a escribir
            End Using
        End Using
        Console.WriteLine("Registro añadido correctamente.")
    End Sub










End Class
